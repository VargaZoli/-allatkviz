using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
	internal class Allat
	{
		private string _kerdes;
		private string _v1;
		private string _v2;
		private string _v3;
		private string _v4;

		public Allat(string kerdes, string v1, string v2, string v3, string v4)
		{
			_kerdes = kerdes;
			_v1 = v1;
			_v2 = v2;
			_v3 = v3;
			_v4 = v4;
		}

		public string Kerdes { get => _kerdes; set => _kerdes = value; }
		public string V1 { get => _v1; set => _v1 = value; }
		public string V2 { get => _v2; set => _v2 = value; }
		public string V3 { get => _v3; set => _v3 = value; }
		public string V4 { get => _v4; set => _v4 = value; }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
