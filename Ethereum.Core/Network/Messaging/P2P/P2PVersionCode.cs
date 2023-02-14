﻿using System.Collections.Generic;

namespace Ethereum.Network.Messaging
{
    public static class P2PVersionCode
    {
        public static int PoC1 = 0x00;
        public static int PoC2 = 0x01;
        public static int PoC3 = 0x07;
        public static int PoC4 = 0x09;
        public static int PoC5 = 0x17;
        public static int PoC6 = 0x1c;

        public static IEnumerable<int> Values
        {
            get
            {
                yield return PoC1;
                yield return PoC2;
                yield return PoC3;
                yield return PoC4;
                yield return PoC5;
                yield return PoC6;
            }
        }
    }
}
