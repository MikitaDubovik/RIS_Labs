using Fifth.BusHelper;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Fifth
{
    public class XmlService : DataService
    {
        public override IEnumerable<Bus> Load(string day = null)
        {
            XDocument xdoc = XDocument.Load(fileName);
            if (string.IsNullOrEmpty(day))
            {
                var items = from xe in xdoc.Element("BusDepot").Elements("Bus")
                            select new Bus
                            {
                                Day = xe.Attribute("day").Value.Trim(),
                                Id = xe.Element("Id").Value.Trim(),
                                Cost = xe.Element("Cost").Value.Trim(),
                                Destination = xe.Element("Destination").Value.Trim(),
                                FreePlace = int.Parse(xe.Element("FreePlace").Value.Trim())
                            };

                return items.Where(i => i.FreePlace > 0).ToList();
            }
            else
            {
                var items = from xe in xdoc.Element("BusDepot").Elements("Bus")
                            select new Bus
                            {
                                Day = xe.Attribute("day").Value.Trim(),
                                Id = xe.Element("Id").Value.Trim(),
                                Cost = xe.Element("Cost").Value.Trim(),
                                Destination = xe.Element("Destination").Value.Trim(),
                                FreePlace = int.Parse(xe.Element("FreePlace").Value.Trim())
                            };

                return items.Where(i => i.FreePlace > 0).ToList();
            }
        }

        public void Update(string id, string decision)
        {
            var xdoc = XDocument.Load(fileName);
            var root = xdoc.Element("BusDepot");

            var element = root.Elements("Bus").ToList().First(b => b.Element("Id").Value.Trim().Equals(id));

            switch (decision)
            {
                case "Reserve":
                    element.Element("FreePlace").Value = (int.Parse(element.Element("FreePlace").Value.Trim()) - 1).ToString();
                    break;
                case "Remove":
                    element.Element("FreePlace").Value = (int.Parse(element.Element("FreePlace").Value.Trim()) + 1).ToString();
                    break;
            }

            xdoc.Save(fileName);
        }

        public string GetDestination(string id)
        {
            XDocument xdoc = XDocument.Load(fileName);
            var items = from xe in xdoc.Element("BusDepot").Elements("Bus")
                        select new Bus
                        {
                            Id = xe.Element("Id").Value.Trim(),
                            Destination = xe.Element("Destination").Value.Trim()
                        };

            return items.Where(i => i.Id.Equals(id)).First().Destination;
        }
    }
}
