﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Calender.Services
{
    internal class DialogService : IDialogService
    {
        public void ShowDialog(string message)
        {
            MessageBox.Show(message);
        }
    }
}
