using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Zadanie_26.Interfaces;
using Zadanie_26.Models;
using Microsoft.Extensions.Logging;

namespace Zadanie_26.Share
{
    public class IXmlDocumentWorker:IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public IXmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Avto avto)
        {
            var xRoot = _document.DocumentElement;

            XmlElement avtoElem = _document.CreateElement("avto");

            XmlAttribute markaAttribute = _document.CreateAttribute("marka");
            XmlText markaText = _document.CreateTextNode(avto.marka);
            markaAttribute.AppendChild(markaText);

            XmlAttribute yearElem = _document.CreateAttribute("year");
            XmlText yearInnerText = _document.CreateTextNode(avto.year.ToString());
            yearElem.AppendChild(yearInnerText);

            avtoElem.AppendChild(yearElem);

            XmlAttribute daysElem = _document.CreateAttribute("days");
            XmlText daysInnerText = _document.CreateTextNode(avto.days.ToString());
            daysElem.AppendChild(daysInnerText);

            avtoElem.AppendChild(daysElem);

            xRoot.AppendChild(avtoElem);
            _document.Save(_xmlFilePath);

        }

        public void Delete(string marka)
        {
            var xRoot= _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count>0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem("marka");
                    try
                    {
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(marka))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {

                        _logger.LogWarning(ex.Message, nameof(attributeName));
                    }
                }
            }
        }

        public Avto FindBy(string marka)
        {
            Avto avto = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xmlNode in xRoot)
            {
                avto = GetAvto(xmlNode);
                if (avto.marka.Equals(marka))
                {
                    return avto;
                }
            }
            return avto;
        }

        public List<Avto> GetAll()
        {
            List<Avto> avtos = new List<Avto>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var avto = GetAvto(node);
                avtos.Add(avto);
            }
            return avtos;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);

        }

        private Avto GetAvto(XmlNode node)
        {
            var avto = new Avto();
            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("marka");
                avto.marka = attributeName?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("marka"))
                    {
                        avto.marka = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("year"))
                    {
                        avto.year = int.Parse(childNode.InnerText);
                    }
                    if (childNode.Name.Equals("days"))
                    {
                        avto.days = int.Parse(childNode.InnerText);
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return avto;
        }

    }
}
