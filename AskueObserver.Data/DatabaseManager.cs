using AskueObserver.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AskueObserver
{
    public class DatabaseManager
    {
        private MySqlConnection connection;
        public bool isConnected { get => connection.State == ConnectionState.Open; }
        public ObservableCollection<Obekt> Obekts { get; set; }
        public ObservableCollection<Fid> Fiders { get; set; }
        public ObservableCollection<Profile> Profiles { get; set; }
        public ObservableCollection<Autoread> Autoreads { get; set; }
        public ObservableCollection<Testseti> Testsetis { get; set; }

        public event EventHandler OnConnected;
        public event EventHandler OnDisconnected;

        public DatabaseManager(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
            Obekts = new ObservableCollection<Obekt>();
            Fiders = new ObservableCollection<Fid>();
            Profiles = new ObservableCollection<Profile>();
            Autoreads = new ObservableCollection<Autoread>();
            Testsetis = new ObservableCollection<Testseti>();
        }

        public string Connect()
        {
            string errorMsg = "";
            try
            {
                connection.Open();
                OnConnected?.Invoke(this, EventArgs.Empty);
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        errorMsg = "Невозможно подключиться к серверу";
                        break;
                    case 1045:
                        errorMsg = "Неверное имя пользователя/пароль";
                        break;
                    default:
                        errorMsg = e.Message;
                        break;
                }
            }
            return errorMsg;
        }
        public MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void CloseConnection()
        {
            connection.Close();
            OnDisconnected?.Invoke(this, EventArgs.Empty);
        }

        public void LoadObekts()
        {
            string sqlExpression = "SELECT * FROM Obekt order by n_ob";
            if (this.isConnected)
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)        // Если есть данные
                    {
                        while (reader.Read())  // Построчно считываем данные
                        {
                            var obekt = new Obekt()
                            {
                                N_ob = int.Parse(reader["n_ob"].ToString()),
                                Txt = reader["txt"].ToString()
                            };
                            Obekts.Add(obekt);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Выборка фидеров подстанции n_ob
        /// </summary>
        /// <param name="n_ob">Номер объекта</param>
        public void LoadFiderList(int n_ob)
        {
            string sqlExpression = $@"select f.n_ob,f.n_fid,f.n_shiny,coalesce(f.disnam, f.txt) disnam,f.kt_1,f.kt_2,f.kn_1,f.kn_2,f.cod_kre,sh.n_sh,sh.k_t,sh.k_n,coalesce(sh.txt, s.name_typ) name_typ,sh.dat_pov,k.txt kl_napr 
            from Fid f
            left join shin sn on sn.syb_rnk = f.syb_rnk and sn.n_ob = f.n_ob and sn.n_shiny = f.n_shiny
            left join kl_napr k on k.kl_napr = sn.kl_napr
            left join sh on sh.syb_rnk = f.syb_rnk and sh.n_ob = f.n_ob and sh.n_fid = f.n_fid
            left join spr_sh s on s.typ_sh = sh.typ_sh
            where f.syb_rnk = 3 and f.n_ob = {n_ob}
            order by f.n_fid";

            if (this.isConnected)
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)        // Если есть данные
                    {
                        Fiders.Clear();
                        while (reader.Read())  // Построчно считываем данные
                        {
                            var fid = new Fid()
                            {
                                Syb_rnk = 3,
                                N_ob = int.Parse(reader["n_ob"].ToString()),
                                N_fid = short.Parse(reader["n_fid"].ToString()),
                                N_shiny = short.Parse(reader["N_shiny"].ToString()),
                                Disnam = reader["disnam"].ToString(),
                                Kt_1 = int.Parse(reader["kt_1"].ToString()),
                                Kt_2 = int.Parse(reader["kt_2"].ToString()),
                                Kn_1 = int.Parse(reader["kn_1"].ToString()),
                                Kn_2 = int.Parse(reader["kn_2"].ToString()),
                                Cod_kre = reader["cod_kre"].ToString(),
                                N_sh = int.Parse(reader["n_sh"].ToString()),
                                Name_typ = reader["name_typ"].ToString(),
                                Kl_napr = reader["kl_napr"].ToString()
                            };
                            DateTime dt;
                            var s = reader["dat_pov"]?.ToString();
                            if (s != "" && DateTime.TryParse(reader["dat_pov"].ToString(), out dt))
                            {
                                fid.Dat_pov = dt;
                            }
                            Fiders.Add(fid);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка профилей мощности счетчика
        /// </summary>
        /// <param name="n_ob">Номер объекта</param>
        /// <param name="n_fid">Номер фидера (ИИК)</param>
        /// <param name="n_gr">Номер канала</param>
        /// <param name="dat">Дата</param>
        public void LoadMeterProfile(int n_ob, int n_fid, int n_gr, DateTime dat)
        {
            string sqlExpression = $@"select syb_rnk,n_ob,n_fid,n_sh,n_gr_ty,n_inter_ras,dd_mm_yyyy,pok_start,rash_poln,date_add(dd_mm_yyyy, interval n_inter_ras*30 minute) dat 
            from askue.buf_v_int 
            where syb_rnk=3 and n_ob={n_ob} and n_fid={n_fid} and n_gr_ty={n_gr} and dd_mm_yyyy=str_to_date('{dat}','%d.%m.%Y')
            order by dd_mm_yyyy,n_inter_ras";

            if (this.isConnected)
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)        // Если есть данные
                    {
                        Profiles.Clear();
                        while (reader.Read())  // Построчно считываем данные
                        {
                            var profile = new Profile()
                            {
                                Syb_rnk = 3,
                                N_ob = int.Parse(reader["n_ob"].ToString()),
                                N_fid = short.Parse(reader["n_fid"].ToString()),
                                N_gr_ty = short.Parse(reader["n_gr_ty"].ToString()),
                                N_inter_ras = short.Parse(reader["n_inter_ras"].ToString()),
                                N_sh = int.Parse(reader["n_sh"].ToString()),
                                Dat = DateTime.Parse(reader["dat"].ToString()),
                                Pok_start = float.Parse(reader["pok_start"].ToString()),
                                Rash_poln = float.Parse(reader["rash_poln"].ToString())
                            };
                            Profiles.Add(profile);
                        }
                    }
                }
            }
        }

        public void LoadMeterAutoread(int n_ob, int n_fid, int typ_pok, DateTime dat)
        {
            string sqlExpression = $@"select syb_rnk,n_ob,n_fid,n_sh,typ_pok,date_format(dd_mm_yyyy,'%d.%m.%Y') dat,akwh,bkwh,ckwh,dkwh,kwha 
            from askue.autoread 
            where syb_rnk=3 and n_ob={n_ob} and n_fid={n_fid} and typ_pok={typ_pok} and extract(year from dd_mm_yyyy)={dat.Year} and extract(month from dd_mm_yyyy)={dat.Month}
            order by dd_mm_yyyy";

            if (this.isConnected)
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)        // Если есть данные
                    {
                        Profiles.Clear();
                        while (reader.Read())  // Построчно считываем данные
                        {
                            var autoread = new Autoread()
                            {
                                Syb_rnk = 3,
                                N_ob = int.Parse(reader["n_ob"].ToString()),
                                N_fid = short.Parse(reader["n_fid"].ToString()),
                                Typ_pok = short.Parse(reader["typ_pok"].ToString()),
                                N_sh = int.Parse(reader["n_sh"].ToString()),
                                Dat = DateTime.Parse(reader["dat"].ToString()),
                                akwh = float.Parse(reader["akwh"].ToString()),
                                bkwh = float.Parse(reader["bkwh"].ToString()),
                                ckwh = float.Parse(reader["ckwh"].ToString()),
                                dkwh = float.Parse(reader["dkwh"].ToString()),
                                kwha = float.Parse(reader["kwha"].ToString())
                            };
                            Autoreads.Add(autoread);
                        }
                    }
                }
            }
        }

        public void LoadMeterTestseti(int n_sh, DateTime dat)
        {
            string sqlExpression = $@"select * from askue.test_seti
            where n_sh={n_sh} and extract(year from testtime)={dat.Year} and extract(month from testtime)={dat.Month} and extract(day from testtime)={dat.Day}
            order by testtime";

            if (this.isConnected)
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)        // Если есть данные
                    {
                        Testsetis.Clear();
                        while (reader.Read())  // Построчно считываем данные
                        {
                            var testseti = new Testseti()
                            {
                                n_sh = int.Parse(reader["n_sh"].ToString()),
                                testtime = DateTime.Parse(reader["testtime"].ToString())
                                //elm = short.Parse(reader["elm"]?.ToString()),
                                //wa = float.Parse(reader["wa"]?.ToString()),
                                //wb = float.Parse(reader["wb"]?.ToString()),
                                //wc = float.Parse(reader["wc"]?.ToString()),
                                //vaa = float.Parse(reader["vaa"]?.ToString()),
                                //vab = float.Parse(reader["vab"]?.ToString()),
                                //vac = float.Parse(reader["vac"]?.ToString()),
                                //freq = float.Parse(reader["freq"]?.ToString()),
                                //ia = float.Parse(reader["ia"]?.ToString()),
                                //ib = float.Parse(reader["ib"]?.ToString()),
                                //ic = float.Parse(reader["ic"]?.ToString()),
                                //ua = float.Parse(reader["ua"]?.ToString()),
                                //ub = float.Parse(reader["ub"]?.ToString()),
                                //uc = float.Parse(reader["uc"]?.ToString()),
                                //pfanga = float.Parse(reader["pfanga"]?.ToString()),
                                //pfangb = float.Parse(reader["pfangb"]?.ToString()),
                                //pfangc = float.Parse(reader["pfangc"]?.ToString()),
                                //phangb = float.Parse(reader["phangb"]?.ToString()),
                                //phangc = float.Parse(reader["phangc"]?.ToString()),
                                //uab = float.Parse(reader["uab"]?.ToString()),
                                //ubc = float.Parse(reader["ubc"]?.ToString()),
                                //uac = float.Parse(reader["uac"]?.ToString()),
                                //uabl = float.Parse(reader["uabl"]?.ToString()),
                                //ucbl = float.Parse(reader["ucbl"]?.ToString()),
                                //pfa = float.Parse(reader["pfa"]?.ToString()),
                                //pfb = float.Parse(reader["pfb"]?.ToString()),
                                //pfc = float.Parse(reader["pfc"]?.ToString()),
                                //vara = float.Parse(reader["vara"]?.ToString()),
                                //varb = float.Parse(reader["varb"]?.ToString()),
                                //varc = float.Parse(reader["varc"]?.ToString()),
                                //i0 = float.Parse(reader["i0"]?.ToString()),
                                //i = float.Parse(reader["i"]?.ToString()),
                                //v = float.Parse(reader["v"]?.ToString()),
                                //t = float.Parse(reader["t"]?.ToString()),
                                //vas = float.Parse(reader["vas"]?.ToString()),
                                //vars = float.Parse(reader["vars"]?.ToString()),
                                //kws = float.Parse(reader["kws"]?.ToString()),
                                //pfs = float.Parse(reader["pfs"]?.ToString())
                            };
                            Testsetis.Add(testseti);
                        }
                    }
                }
            }
        }

        public DataTable LoadOtherObekts()
        {
            string sqlExpression = "SELECT * FROM Obekt order by n_ob";
            DataTable dataTable = new DataTable();
            if (this.isConnected)
            {
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
