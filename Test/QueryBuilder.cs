using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Test
{
	class QueryBuilder
	{
		[DisplayName("Операция над множествами")]
		static Dictionary<string, string> MultitudeOps { get; } = new Dictionary<string, string> {
			{ "Union", "Объединение" },
			{ "Intersect", "Пересечение" },
			{ "Except", "Разность" }
		};

		static Dictionary<string, string> BaseOps { get; } = new Dictionary<string, string> {
		};

		QueryBuilder() { List<object> s = new List<object>();
		
		}

	}
}
