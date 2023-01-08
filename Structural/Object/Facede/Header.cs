using System.Text;
using System;

namespace Facede
{
    public class Header
    {
        public string CreateHeader( string str = "" )
        {
            StringBuilder sb = new();
            sb.Append("ABC COMPANY\n");
            sb.Append("Annual Report\n");
            sb.Append(str);

            return sb.ToString();

        }
      
    }
}