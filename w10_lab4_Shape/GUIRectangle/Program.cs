﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUIRectangle
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // 프로그램 실행할 때 객체 인스턴스를 만들어둠
        }
    }
}
