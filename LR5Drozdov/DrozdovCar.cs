using System;


namespace LR5Drozdov
{
    [Serializable]
    public class DrozdovCar
    {
        public string name;
        public int year = 0;
        public double strt_prc = 0;
        public virtual void In()
        {
            Console.WriteLine("\nВведите название: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите год выпуска: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начальную цену: ");
            strt_prc = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Out()
        {
            Console.WriteLine("\nНазвание: {0}", name);
            Console.WriteLine("Год выпуска: {0}", year);
            Console.WriteLine("Начальная цена: {0}", strt_prc);
        }
    }
}
