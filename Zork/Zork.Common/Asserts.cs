﻿using System;
using System.Diagnostics;

namespace Zork.Common
{

    public static class Assert
    {
        [Conditional("Debug")]
        public static void IsTrue(bool expression, string message = null)
        {
            if (expression == false)
            {
                throw new Exception(message);
            }
        }
    }
}