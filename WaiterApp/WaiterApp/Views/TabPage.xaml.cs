﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaiterApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabPage : TabbedPage
	{
		public TabPage ()
		{
			InitializeComponent ();
		}

        private void Refresh_Clicked(object sender, EventArgs e)
        {

        }
    }
}