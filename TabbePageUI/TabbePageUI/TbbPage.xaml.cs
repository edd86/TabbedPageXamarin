﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbePageUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TbbPage : TabbedPage
    {
        public TbbPage()
        {
            InitializeComponent();
        }
    }
}