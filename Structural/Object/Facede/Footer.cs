using System;
using System.Text;

namespace Facede
{
    public class Footer
    {
        public string CreateFooter( string str = "" )
        {
            StringBuilder sb = new();
            sb.Append(str + "\n");
            sb.Append($"{DateTime.Now:dddd, dd \\de MMMM \\de yyyy HH:mm}");

            return sb.ToString();

        }
    }
}