using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TipCalc.Core;

namespace TipCalc.UI.WindowsPhone.Views
{
    public partial class TipView : MvxPhonePage
    {
        public TipView()
        {
            InitializeComponent();
        }

        public new TipViewModel ViewModel
        {
            get { return (TipViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}