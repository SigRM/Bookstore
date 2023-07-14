using ProyectoV1.Entities;
using ProyectoV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProyectoV1.Files
{
    internal class FileXMLBook : IBookMaintenance
    {
        public string path => Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\FileXML.xml";

        public void Add(Books book)
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (System.IO.File.Exists(path))//Ask if the file exists
            {
                xmlDoc.Load(path);
            }
            else
            {
                xmlDoc.LoadXml("<Books></Books>");//It creates a new root node
            }

            XmlElement nBook = xmlDoc.CreateElement("Books"); //Create Element allow you to create a new node
            nBook.SetAttribute("Title", book.title);
            nBook.SetAttribute("Price", book.price.ToString());

            XmlElement nAuthor = xmlDoc.CreateElement("Author");
            nAuthor.InnerText = book.author;
            nBook.AppendChild(nAuthor);//assign the father

            xmlDoc.DocumentElement.AppendChild(nBook);//assign the father


            xmlDoc.Save(path);
        }

        public List<Books> GetTheBook()
        {
            List<Books> list = new List<Books>();
            if (System.IO.File.Exists(path))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);//El load received the path

                foreach (XmlElement node in xmlDoc.DocumentElement)
                {
                    Books book = new Books();
                    book.title= node.GetAttribute("Title");
                    book.price = int.Parse(node.Attributes["Price"].Value);
                    book.author = node.SelectSingleNode("Author").InnerText;
                    list.Add(book);
                }
            }
            return list;
        }

        public override string ToString()
        {
            return "XML FIle";
        }
    }
}
