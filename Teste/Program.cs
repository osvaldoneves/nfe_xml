using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\exemplo.xml");

            XmlNode root = doc.DocumentElement;
            String nameSpace = root.Attributes["xmlns"].Value;
            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("ns", nameSpace);

            XmlNode ideNode = doc.SelectSingleNode("//ns:ide", namespaces);

            XmlNode no = ideNode.SelectSingleNode("cUF");
            */

            /*
             * XmlDocument doc = new XmlDocument();
            doc.LoadXml(strXml);
            XmlNode root = doc.DocumentElement;
            XmlNode ideNode = root["atr"];
             */

            String strXml = "<det nItem=\"1\"><imposto>imposto</imposto><infAdProd>infAdProd</infAdProd><infAdProd>infAdProd</infAdProd></det>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strXml);
            XmlNode ideNode = doc.DocumentElement;
            XmlNodeList list = ideNode.SelectNodes("//det/infAdProd");
            

        }
    }   
}
