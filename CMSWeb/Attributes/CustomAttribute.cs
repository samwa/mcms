using System;

namespace CMSWeb
{
	public class CustomAttribute : Attribute
	{
		public string CustomValue { get; set; }
		
		public CustomAttribute(string customValue)
		{
			CustomValue = customValue;
		}
	}
}

