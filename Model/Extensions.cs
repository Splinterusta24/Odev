using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Model
{
    internal static class Extensions
    {
       public static string TarihDuzenle(this DateTime date)
        {
            return date.ToString("dd/MM/yy").Replace('/', '.');

        } 


    }
}
