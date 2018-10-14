using Fifth.UserHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fifth.Service
{
    public partial class FileService : DataService
    {
        public FileService() : base()
        {
        }

        public FileService(string fileName) : base(fileName)
        {
        }

        public string FileName
        {
            get => fileName;
        }
    }

    public partial class FileService : DataService
    {
        private const int NumberOfTrips = 3;

        public override void Add(string id, string destination)
        {
            var fileList = File.ReadAllLines(FileName).ToList();
            bool isExist = false;
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].Contains("UserInfo - Name: " + User.Name))
                {
                    isExist = true;
                    var index = i + 1;
                    if (!fileList[index].StartsWith("ID - "))
                    {
                        fileList[index] = "ID - " + id + "; Destination - " + destination;
                        fileList.Insert(index + 1, "");
                    }
                    else
                    {
                        while (!fileList[index].StartsWith("ID - "))
                        {
                            index++;
                        }

                        fileList[index + 1] = "ID - " + id + "; Destination - " + destination;
                        fileList.Insert(index + 2, "");
                    }
                }
            }
            if (!isExist)
            {
                fileList.Add(
                    "UserInfo - Name: " + User.Name +
                    "; Surname: " + User.Surname +
                    "; Patronymic: " + User.Patronymic +
                    "; Phone: " + User.PhoneNumber +
                    "; Series of passport: " + User.SeriesOfPassport +
                    "; Number of passport: " + User.NumberOfPassport);

                fileList.Add("ID - " + id + "; Destination - " + destination);
                fileList.Add("");
            }

            File.WriteAllLines(FileName, fileList);
        }

        public override void Remove(string id)
        {
            var fileList = File.ReadAllLines(FileName).ToList();
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].StartsWith("UserInfo - Name: " + User.Name))
                {
                    var index = 1 + i;
                    while (fileList[index].StartsWith("ID - "))
                    {
                        if (fileList[index].StartsWith("ID - " + id))
                        {
                            fileList.RemoveAt(index);
                        }

                        index++;
                    }
                }
            }

            File.WriteAllLines(FileName, fileList);
        }

        public List<string> Find()
        {
            var fileList = File.ReadAllLines(FileName).ToList();
            var items = new List<string>();
            for (var i = fileList.Count - 1; i >= 0; i--)
            {
                if (fileList[i].StartsWith("UserInfo - Name: " + User.Name))
                {
                    var index = 1 + i;
                    while (fileList[index].StartsWith("ID - "))
                    {
                        items.Add(fileList.ElementAt(index));
                        index++;
                    }
                }
            }

            return items;
        }
    }
}
