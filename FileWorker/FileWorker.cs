using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileService
{
    public class FileWorker
    {
        private static string FileName = Path.GetDirectoryName(Environment.CurrentDirectory) + "\\Repo.txt";

        public FileWorker(string fileName)
        {
                FileName = fileName ?? throw new ArgumentException(nameof(fileName));
        }

        public void Add()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter price");
            var price = Console.ReadLine();

            Console.WriteLine("Enter taste");
            var taste = Console.ReadLine();

            using (var fstr = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fstr.Seek(0, SeekOrigin.End);
                using (var sw = new StreamWriter(fstr))
                {
                    sw.WriteLine(name + " " + price + " " + taste);
                }
            }
        }

        public void Add(string name, string price, string taste)
        {
            using (var fstr = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fstr.Seek(0, SeekOrigin.End);
                using (var sw = new StreamWriter(fstr))
                {
                    sw.WriteLine(name + " " + price + " " + taste);
                }
            }
        }

        public string GetAll()
        {
            using (var fstr = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                fstr.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(fstr))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            var fileList = File.ReadAllLines(FileName).ToList();
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].StartsWith(name ?? throw new ArgumentException()))
                {
                    fileList.RemoveAt(i);
                }
            }

            File.WriteAllLines(FileName, fileList);
        }

        public void Delete(string name)
        {
            var fileList = File.ReadAllLines(FileName).ToList();
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].StartsWith(name ?? throw new ArgumentException()))
                {
                    fileList.RemoveAt(i);
                }
            }

            File.WriteAllLines(FileName, fileList);
        }

        public void Update(string name, string newName, string newPrice, string newTaste)
        {
            var newItem = newName + " " + newPrice + " " + newTaste;

            var fileList = File.ReadAllLines(FileName).ToList();
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].StartsWith(name ?? throw new ArgumentException()))
                {
                    fileList.RemoveAt(i);
                    fileList.Insert(i, newItem);
                }
            }

            File.WriteAllLines(FileName, fileList);
        }

        public void Update()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter new name");
            var newItem = Console.ReadLine() + " ";

            Console.WriteLine("Enter new price");
            newItem += Console.ReadLine() + " ";

            Console.WriteLine("Enter new taste");
            newItem += Console.ReadLine();

            var fileList = File.ReadAllLines(FileName).ToList();
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].StartsWith(name ?? throw new ArgumentException()))
                {
                    fileList.RemoveAt(i);
                    fileList.Insert(i, newItem);
                }
            }

            File.WriteAllLines(FileName, fileList);
        }

        public List<string> Sort()
        {
            var temp = File.ReadAllLines(FileName).ToList();
            temp.Sort();
            return temp;
        }

        public string Search(string name)
        {
            return File.ReadAllLines(FileName).ToList().Find(s => s.StartsWith(name));
        }
    }
}
