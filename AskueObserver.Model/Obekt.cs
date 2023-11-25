using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskueObserver.Model
{
    public class Obekt : ICloneable
    {
        public DateTime Dat { get; set; }
        public DateTime Dat_dog { get; set; }
        public DateTime Dat_likv { get; set; }
        public string Fax { get; set; }
        public string Fio_buh { get; set; }
        public string Fio_dir { get; set; }
        public string Fio_ener { get; set; }
        public int Gr_askp { get; set; }
        public short Gr_tar_2 { get; set; }
        public string Kod { get; set; }
        public int Kod_otr { get; set; }
        public int Kod_podotr { get; set; }
        public int Kod_sp { get; set; }
        public string Kto { get; set; }
        public long N_dog { get; set; }
        public int N_ob { get; set; }
        public int N_ob_k { get; set; }
        public short N_tar_2 { get; set; }
        public int Okpo { get; set; }
        public string Sost_dog { get; set; }
        public short Syb_rnk { get; set; }
        public short Syb_rnk_k { get; set; }
        public string Tel_buh { get; set; }
        public string Tel_dir { get; set; }
        public string Tel_ener { get; set; }
        public string Txt { get; set; }
        public string Typ { get; set; }
        public int Typ_ob { get; set; }
        public string Ur_adr { get; set; }
        public string Urnam { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
