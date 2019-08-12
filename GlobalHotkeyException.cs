﻿using System;
using System.Runtime.Serialization;

namespace GlobalHotkeys
{
    public class GlobalHotkeyException : Exception
    {
        public GlobalHotkeyException(string message) : base(message) {}
        public GlobalHotkeyException(string message, Exception inner) : base(message, inner) {}
    }
}
