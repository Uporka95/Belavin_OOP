using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Test
{
	class RuntimeTools
	{
			public static readonly MethodInfo CastMethod = typeof(Enumerable).GetMethod("Cast");           // Достаем метаданные метода приведения
			public static readonly MethodInfo ToListMethod = typeof(Enumerable).GetMethod("ToList");
			public static object CastToList(IEnumerable list, Type type)
			{
				var casted = (IEnumerable)CastMethod.MakeGenericMethod(new Type[] { type })  // Инстанцируем новый метод нужным типом и получаем 
										  .Invoke(null, new[] { list });
				var nlist = ToListMethod.MakeGenericMethod(new Type[] { type })            // Приводим IEnumerable к списку нужного типа тем же 
							  .Invoke(null, new object[] { casted });

				return nlist;

			}


		public static List<string> GetPropertiesDispNames(Type type)
		{
			List<string> prop_list = new List<string>();
			var props = type.GetProperties();
			foreach (var prop in type.GetProperties())
			{
				
				prop_list.Add((string)prop.CustomAttributes.First().ConstructorArguments.First().Value);
			}
			return prop_list;
			
		}
		public static string GetPropertyName(Type type, string dispname)
		{
			PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(type);

			foreach (var prop in pdc)
			{
				if ((prop as PropertyDescriptor).DisplayName == dispname)
					return (prop as PropertyDescriptor).Name;
			}
			return "Default";
		}

		public static string GetPropertyDispName(Type type, string name)
		{
			PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(type);

			foreach (var prop in pdc)
			{
				if ((prop as PropertyDescriptor).Name == name)
					return (prop as PropertyDescriptor).DisplayName;
			}
			return "Default";
		}

		public static Type GetUpperBaseType(Type type)
		{
			while(type.BaseType != typeof(object))
			{
				type = type.BaseType;
			}

			return type;
		}
	}
	
}
