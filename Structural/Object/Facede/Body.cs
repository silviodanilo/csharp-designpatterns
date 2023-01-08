using System;
using System.Text;

namespace Facede
{
    public class Body
    {
        public string CreateBody( string str = "" )
        {
            StringBuilder sb = new();
            sb.Append(str + "\n");

            return sb.ToString();

        }
    }
}