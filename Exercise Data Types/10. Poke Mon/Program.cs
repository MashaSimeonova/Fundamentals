using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustinFactor = int.Parse(Console.ReadLine());
            int counter = 0;
            int copyPower = pokemonPower;

            while (pokemonPower>=distance)
            {
                pokemonPower -= distance;
                counter += 1;

                if (pokemonPower == copyPower*0.5 && exhaustinFactor!=0)
                {
                    pokemonPower /= exhaustinFactor;
                }
            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(counter);
        }
    }
}
