using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePoster
{
    [Serializable]
    public class MResponse
    {
        public bool is_success { get; set; }
        public string msg { get; set; }
        public bool transparent { get; set; }
        public bool white_background { get; set; }
        public bool passport { get; set; }
        public MResponse()
        {
            is_success = false;
            msg = string.Empty;
            transparent = false;
            white_background = false;
            passport = false;
        }
    }
}
