using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskueObserver.Model
{
    /// <summary>
    /// Профиль мощности эл. счётчика
    /// </summary>
    public class Profile
    {
        public short Syb_rnk { get; set; }
        public int N_ob { get; set; }
        public short N_fid { get; set; }
        public int N_sh { get; set; }
        public short N_gr_ty { get; set; }
        public short N_inter_ras { get; set; }
        public DateTime Dat { get; set; }
        public float Pok_start { get; set; }
        public float Rash_poln { get; set; }
    }
}
