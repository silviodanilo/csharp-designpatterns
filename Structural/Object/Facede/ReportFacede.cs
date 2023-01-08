using System;
using System.Text;

namespace Facede
{
    public class ReportFacede
    {
        public static string CreateReport( Header header, Body body, Footer footer )
        {
            StringBuilder sb = new();
            sb.Append(header.CreateHeader());
            sb.Append(body.CreateBody("\nMy text"));
            sb.Append(footer.CreateFooter());

            return sb.ToString();
        }
        
    }
}