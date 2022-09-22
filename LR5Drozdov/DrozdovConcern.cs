using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace LR5Drozdov
{
    [Serializable]
    public class DrozdovConcern 
    {
        List<DrozdovCar> motorshow = new List<DrozdovCar>();
        public void add()
        {
            DrozdovCar car = new DrozdovCar();
            car.In();
            motorshow.Add(car);
        }
        public void add_sportcar()
        {
            DrozdovCar car = new DrozdovSportCar();
            car.In();
            motorshow.Add(car);
        }
        public void clear()
        {
            motorshow.Clear();
            Console.WriteLine("\nСписок очищен.\n");
        }
        public void show()
        {
            if (motorshow.Count() != 0)
            {
                foreach (var i in motorshow)
                {
                    i.Out();
                }
            }
            else
            {
                Console.WriteLine("\nСписок пуст.\n");
            }
        }
        public void ToFile()
        {
            if (motorshow.Count() != 0)
            {
                Console.WriteLine("Введите название файла: ");
                string way = Console.ReadLine();
                //var bf = new BinaryFormatter();
                var xc = new XmlSerializer(typeof(List<DrozdovCar>), new[] { typeof(DrozdovCar), typeof(DrozdovSportCar) });
                using (FileStream fout = new FileStream(way, FileMode.OpenOrCreate))
                {
                    //bf.Serialize(fout, motorshow);
                    xc.Serialize(fout, motorshow);
                }
                Console.WriteLine("\nДанные сохранены в файл. \n");
            }
            else
            {
                Console.WriteLine("\nСписок пуст.\n");
            }
        }
        public void FromFile()
        {
            Console.WriteLine("Введите название файла: ");
            string way = Console.ReadLine();
            if (File.Exists(way))
            {
                //var bf = new BinaryFormatter();
                var xc = new XmlSerializer(typeof(List<DrozdovCar>), new[] { typeof(DrozdovCar), typeof(DrozdovSportCar) });
                using (FileStream fin = new FileStream(way, FileMode.Open))
                {
                    motorshow = xc.Deserialize(fin) as List<DrozdovCar>;
                    //motorshow = bf.Deserialize(fin) as List<DrozdovCar>;
                }
                Console.WriteLine("\nДанные считаны из файла. \n");
            }
            else
            {
                Console.WriteLine("\nОшибка открытия файла, возможно, такого файла не существует.\n");
            }
        }
    }
}

