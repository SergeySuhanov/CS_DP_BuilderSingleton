using System;

namespace CS_DP_Builder
{
    class Builder
    {
        static void Main(string[] args)
        {
            try
            {
                AircraftBuilder builder;
                //Создаем объект класса директора
                AircraftConstructor shop = new AircraftConstructor();
                //Создаем объект класса строителя.
                //Этот объект умеет создавать дельтапланы
                builder = new HangGliderBuilder();
                //сооружаем дельтаплан
                shop.Construct(builder);
                //показываем информацию о дельтаплане
                builder.Aircraft.Show();
                //Создаем объект класса строителя.
                //Этот объект умеет создавать планеры
                
                builder = new GliderBuilder();
                //сооружаем планер
                shop.Construct(builder);
                //показываем информацию о планере
                builder.Aircraft.Show();
            }
            catch (Exception str)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
