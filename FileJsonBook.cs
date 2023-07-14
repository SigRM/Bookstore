using Newtonsoft.Json;
using ProyectoV1.Entities;
using ProyectoV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Files
{
    internal class FileJsonBook : IBookMaintenance
    {
        public string path => Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\FileJson.json";

        public void Add(Books book)
        {
            List<Books> list = GetTheBook();
            list.Add(book);

            string json = JsonConvert.SerializeObject(list);//This list serialized itself to a json file and save the string in a file
            System.IO.File.WriteAllText(path, json);
        }

        public List<Books> GetTheBook()
        {
            if (System.IO.File.Exists(path))
            {
                string json = System.IO.File.ReadAllText(path);
                List<Books> list = JsonConvert.DeserializeObject<List<Books>>(json);
                return list;
            }
            else
            {
                return new List<Books>();
            }

        }

        public override string ToString()
        {
            return "Json File";
        }
    }
}
