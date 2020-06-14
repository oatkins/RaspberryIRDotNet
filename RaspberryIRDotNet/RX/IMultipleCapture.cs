﻿using System;

namespace RaspberryIRDotNet.RX
{
    public interface IMultipleCapture
    {
        /// <summary>
        /// Ready for the user to press a button.
        /// </summary>
        event EventHandler Waiting;

        /// <summary>
        /// Captured an IR message.
        /// </summary>
        event EventHandler Hit;

        /// <summary>
        /// IR noise got in the way of a capture.
        /// </summary>
        event EventHandler Miss;

        TimeSpan CaptureDelay { get; }
    }
}
