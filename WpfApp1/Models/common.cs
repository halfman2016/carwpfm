using System;
using System.Collections.Generic;
using System.Text;

namespace carm.Models
{
    static class Common
    {
        public static carmangerContext cardb = new carmangerContext();
        public static string username { get; set; }
        public static int? orgid { get; set; }
        public static string orgname { get; set; }

    }
}
