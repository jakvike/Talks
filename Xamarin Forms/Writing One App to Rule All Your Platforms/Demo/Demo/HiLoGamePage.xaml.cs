﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
	public partial class HiLoGamePage : ContentPage
	{
		public HiLoGamePage()
		{
			InitializeComponent();
			this.BindingContext = new HiLoGamePageViewModel();
		}
	}
}