using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEmployeeFinger.src.Class.CodeMessage
{
    class Code
    {
        // ERROR
        public static string ERR_OP_DEV_FAILED = "Error : Failed to Open Device.";
        public static string ERR_INIT_DB_FAILED = "Error : Failed to Initialize Database.";
        public static string ERR_INIT_FAILED = "Error : Initialize Device Failed";

        // SUCCESS
        public static string SUCC_OP_DEV = "Successfully Open Device.";
        public static string SUCC_INIT_DEV = "Initialize Device Succeed.";
        public static string SUCC_CL_DEV = "Device is closed.";
    }
}
