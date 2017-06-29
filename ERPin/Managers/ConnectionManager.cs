using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPin.Managers
{
    public static class ConnectionManager
    {
        private static bool isConnected = false;

        public static bool IsConnected
        {
            get { return isConnected; }
        }

        public static void ConnectDB()
        {
            NebimV3.ApplicationCommon.V3Application.Context.Globals.Initialize("Nebim","Admin","admin","BERKAY");
            NebimV3.ApplicationCommon.V3Application.Context.Globals.CurrentUser.SelectCompany("NebimV3");
            NebimV3.ApplicationCommon.LocalizationHelper.Load();

            isConnected = true;
        }

        public static string GetVersion
        {
            get
            {
                if (!IsConnected)
                {
                    ConnectDB();
                }
                return NebimV3.ApplicationCommon.V3Application.Context.CurrentCompany.VersionInfo.Version;
            }
        }
    }
}
