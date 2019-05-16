using System;
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

        public string catagori_name { get; internal set; }

        private void Refresh_Clicked(object sender, EventArgs e)
        {

        }
    }
}