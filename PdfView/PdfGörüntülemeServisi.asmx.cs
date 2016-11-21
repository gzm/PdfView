using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Services;

namespace PdfGörüntüleme
{
    /// <summary>
    /// Summary description for PdfGörüntülemeServisi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PdfGörüntülemeServisi : System.Web.Services.WebService
    {

        [WebMethod]
        public List<belge> BütünEvraklar(string evrakNo)
        {

            List<belge> belge = new List<belge>();

            if (evrakNo == "227264")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge{belgePdf=pdfBase64});   
            }

            if (evrakNo == "227301")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }

            if (evrakNo == "227302")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227303")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\secube.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227304")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\iytefaaliyet.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227305")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\iyteyazokulu.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227306")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\notes.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227307")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\ibm.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227308")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227309")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227310")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227311")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227312")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            return belge;
    }
       
        public List<belge> UzerindeCalistiklarim(string evrakNo)
        {

            List<belge> belge = new List<belge>();
            if (evrakNo == "227264")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }

            if (evrakNo == "227301")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }

            if (evrakNo == "227302")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            return belge;

        }
        public List<belge> TeslimAlmadiklarim(string evrakNo)
        {

            List<belge> belge = new List<belge>();
            if (evrakNo == "227307")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\ibm.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227308")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            return belge;

        }
        public List<belge> HavaleEttiklerim(string evrakNo)
        {

            List<belge> belge = new List<belge>();
            if (evrakNo == "227307")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\ibm.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227308")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            return belge;

        }
        public List<belge> DosyayaKaldirdiklarim(string evrakNo)
        {

            List<belge> belge = new List<belge>();
            if (evrakNo == "227309")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227310")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            if (evrakNo == "227311")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            return belge;

        }
        public List<belge> IptalEttiklerim(string evrakNo)
        {

            List<belge> belge = new List<belge>();
            if (evrakNo == "227312")
            {
                string path = @"c:\users\pc\documents\visual studio 2013\Projects\PdfGörüntüleme\PdfGörüntüleme\pdf\EBYS-wireframe.pdf";
                var x = File.ReadAllBytes(@path);
                string pdfBase64 = Convert.ToBase64String(x);
                belge.Add(new belge { belgePdf = pdfBase64 });
            }
            return belge;

        }



    public class belge
    {
        public string belgePdf;

    }
}
}
     
