﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MulticastingUDP
{
    class CAT62I295UserData
    {

        public static void DecodeCAT62I295(byte[] Data)
        {
            // Increase data buffer index so it ready for the next data item.
            CAT48.CurrentDataBufferOctalIndex = CAT48.CurrentDataBufferOctalIndex + 1;
        }
    }
}