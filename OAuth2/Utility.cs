﻿using System;
using System.Text;

namespace OAuth2
{ 
    public class Utility
    {
        public static string DecodeBase64String(string encodedString)
        {
            byte[] data = Convert.FromBase64String(encodedString);

            return Encoding.UTF8.GetString(data);
        }
    }
}
