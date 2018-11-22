using Fifth.BusHelper;
using System;
using System.Collections.Generic;
using System.IO;

namespace Fifth
{
    public class DataService
    {
        protected readonly string fileName = Path.GetDirectoryName(Environment.CurrentDirectory) + "\\..\\Repo.xml";

        public DataService()
        {

        }

        public DataService(string fileName)
        {
            this.fileName = fileName;
        }

        public virtual IEnumerable<Bus> Load(string day = null)
        {
            return new List<Bus>();
        }

        public virtual void Print()
        {

        }

        public virtual void Add(string id, string destination)
        {

        }

        public virtual void Remove(string id)
        {

        }
    }
}
