using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

using NewLife.Log;
using NewLife.Xml;


namespace TsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            XTrace.UseConsole(true, false);
            InvtHeadType invtHeadType = new InvtHeadType();
         //   invtHeadType.SeqNo = "1127";

            string xml = xmlserialize(invtHeadType);
         
//Regex below finds strings that start with xmlns, may or may not have :and some text, then continue with =
//and", have a streach of text that does not contain quotes and end with". similar, will happen to an attribute
// that starts with xsi.
           
            xml = Regex.Replace(xml, @" xmlns:xsi*="".*?""","");
             xml = Regex.Replace(xml, @" xmlns:xsd*="".*?""","");
            //var newxml = Regex.Replace(xml, @"xmlns[:xsi|:xsd]*="".*?""","");
          //  xml = Regex.Replace(xml, strXMLPattern,"");
            XTrace.WriteLine(xml);
        }
        
        /// <summary>
        /// 对象序列化成 xml string
        /// </summary>
        public static string xmlserialize(object obj)
        {
            
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("","");
           
            string xmlstring = string.Empty;
            var  xmlserializer = new XmlSerializer(obj.GetType());
            using (var ms = new MemoryStream())
            {
                xmlserializer.Serialize(ms, obj);
                xmlstring = Encoding.UTF8.GetString(ms.ToArray());
            }
            return xmlstring;
        }
        
      
        



    }




    public static class T
    {
        public static XElement WithoutNamespaces(this XElement element)
        {
            if (element == null) return null;
 
            #region delegates:
 
            Func<XNode, XNode> getChildNode = e => (e.NodeType == XmlNodeType.Element) ? (e as XElement).WithoutNamespaces() : e;
 
            Func<XElement, IEnumerable<XAttribute>> getAttributes = e => (e.HasAttributes) ?
                e.Attributes()
                    .Where(a => !a.IsNamespaceDeclaration)
                    .Select(a => new XAttribute(a.Name.LocalName, a.Value))
                :
                Enumerable.Empty<XAttribute>();
 
            #endregion
 
            return new XElement(element.Name.LocalName,
                element.Nodes().Select(getChildNode),
                getAttributes(element));
        }
    }
    
   
    [XmlRoot(Namespace = "http://example.com/xml")]
    public class InvtHeadType
    {
        public string SeqNo { get; set; }
        
    }

  
}