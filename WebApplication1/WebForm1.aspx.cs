using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        XElement svg = new XElement("svg", Request.QueryString["fname"]);

        XDocument SVG = new XDocument();
        SVG.Add(svg);


        var SVGDX = new XAttribute("x", "0");
        var SVGDY = new XAttribute("y", "15");
        svg.Add(SVGDX);
        svg.Add(SVGDY);


        SVG.Save(@"C:\Users\Eren\Desktop\sss.xml");


    }
}