﻿using System;
using System.Windows.Forms;

namespace Clock;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormClock());
    }
}
