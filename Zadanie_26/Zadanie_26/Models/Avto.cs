using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_26.Models
{
    public class Avto
    {
       public string marka { get; set; }
       public int year { get; set; }
       public int days { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Marka: {marka}")
                .AppendLine($"Year of manufacturing: {year}")
                .AppendLine($"Days at parking: {days}")
                .ToString();
        }
    }
}
