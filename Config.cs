using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace VRoads.UVP.Base
{
    public static class Config
    {
        public static string GetExpectedStringValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string UvpUrl => GetExpectedStringValue("UVPUrl");
    }
}
