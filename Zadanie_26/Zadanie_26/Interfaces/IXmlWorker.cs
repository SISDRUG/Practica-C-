using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie_26.Models;

namespace Zadanie_26.Interfaces
{
    internal interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Avto avto);
        void Delete(string marka);
        Avto FindBy(string marka);
        List<Avto> GetAll();
    }
}
