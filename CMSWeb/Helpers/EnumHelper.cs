namespace CMSWeb
{
	using System;
	using System.Collections.Generic;
	
	public static class EnumHelper
	{
		public static T EnumParse<T>(this string value)
		{
			return EnumHelper.EnumParse<T>(value, false);
		}
		
		public static T EnumParse<T>(this string value, bool ignoreCase)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			
			value = value.Trim();
			
			if (value.Length == 0)
			{
				throw new ArgumentException("Must specify valid information for parsing in the string.", "value");
			}
			
			Type t = typeof(T);
			
			if (!t.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "T");
			}
			
			T enumType = (T)Enum.Parse(t, value, ignoreCase);
			return enumType;
		}
		
		// convert enum to list
		public static List<T> EnumToList<T>()
        {
            Type enumType = typeof (T);

            // Can't use type constraints on value types, so have to do check like this
            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T must be of type System.Enum");
            
            Array enumValArray = Enum.GetValues(enumType);

            List<T> enumValList = new List<T>(enumValArray.Length);

            foreach (int val in enumValArray) {
                enumValList.Add((T)Enum.Parse(enumType, val.ToString()));
            }

            return enumValList;
        }
		
		public static string EnumToString<T>(T value)
	    {
	        return Enum.GetName(typeof(T), value);
	    }
	}
}

