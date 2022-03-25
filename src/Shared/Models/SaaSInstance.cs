using System;
using System.Collections.Generic;
using System.Text;

namespace SaaSManager.Shared.Models
{
	public class SaaSInstance
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public string CreationDate { get; set; }
		public string Service { get; set; }
		public string AwsAccount { get; set; }
		public string Status { get; set; }
		public List<string> Tags { get; set; }
	}
}
