﻿using System;
using System.Collections.Generic;
using PropertyChanged;

namespace UptownFunc
{
	[ImplementPropertyChanged]
	public class ActionOption
	{
		public bool IsChecked { get; set; }
		public string Name { get; set; }
		public Action<List<Transformer>> Action { get; set; }
	}
}