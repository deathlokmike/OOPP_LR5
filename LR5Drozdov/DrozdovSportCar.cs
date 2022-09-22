using System;



namespace LR5Drozdov
{
    [Serializable]
    public class DrozdovSportCar : DrozdovCar
    {
        public int engine_power = 0;
        public int torque = 0;
        public override void In()
        {
            base.In();
            Console.WriteLine("Введите мощность двигателя: ");
            engine_power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите крутящий момент: ");
            torque = Convert.ToInt32(Console.ReadLine());
        }
        public override void Out()
        {
            base.Out();
            Console.WriteLine("Мощность двигателя: {0}", engine_power);
            Console.WriteLine("Крутящий момент: {0}", torque);
        }
    }
}
