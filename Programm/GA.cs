using System;
using System.Collections.Generic;
using System.Linq;

namespace FR_GA
{
    static internal class GA
    {
        public static decimal cross_probability = 0.9m;
        public static decimal mutation_probability = 0.1m;
        public static int mutation_value = 64; //intial value
        public struct chromosome
        {
            public int x0;
            public int y0;
            public int a;
            public int b;
        }
        
        public static List<chromosome> Initialize_population(int individual_count)
        {
            Random r = new Random();
            List<chromosome> lst = new List<chromosome>();

            for (int i = 0; i < individual_count; i++)
            {
                lst.Add(new chromosome { x0 = r.Next(256), y0 = r.Next(256), a = r.Next(256), b = r.Next(256)});

            }
            return lst;
        }

        public static decimal Ellipse_Coordinates(int x, int y, int x0, int y0, int a, int b)
        {
            if (a == 0 && b == 0)
                return 0;
            else if (a == 0 && b != 0)
                return Convert.ToDecimal(Math.Pow(y - y0, 2) / Math.Pow(b, 2));
            else if (a != 0 && b == 0)
                return Convert.ToDecimal(Math.Pow(x - x0, 2) / Math.Pow(a, 2));
            else
                return Convert.ToDecimal(Math.Pow(x - x0, 2) / Math.Pow(a, 2) + Math.Pow(y - y0, 2) / Math.Pow(b, 2));
        }

        public static int Fitness(chromosome chromo, int[,] pixels)
        {
            int result = 0;
            for (int i = 0; i < pixels.GetLength(0); i++)
            {
                for (int j = 0; j < pixels.GetLength(1); j++)
                {
                    if (pixels[i,j] < mutation_value)
                    {
                        decimal val = Ellipse_Coordinates(i, j, chromo.x0, chromo.y0, chromo.a, chromo.b);

                        if (Math.Abs(2 - val) < 1)// why this ????
                        {
                            result += 1;
                        }
                    }
                }
            }
            return result;
        }

        public static void Crossover(ref chromosome chromo1, ref chromosome chromo2)
        {
            Random r = new Random();
            int x = r.Next(4);
            int value1, value2;
            switch (x)
            {
                case 0:
                    value1 = chromo1.x0;
                    value2 = chromo2.x0;
                    chromo1.x0 = value2;
                    chromo2.x0 = value1;
                    break;
                case 1:
                    value1 = chromo1.y0;
                    value2 = chromo2.y0;
                    chromo1.y0 = value2;
                    chromo2.y0 = value1;
                    break;
                case 2:
                    value1 = chromo1.a;
                    value2 = chromo2.a;
                    chromo1.a = value2;
                    chromo2.a = value1;
                    break;
                case 3:
                    value1 = chromo1.b;
                    value2 = chromo2.b;
                    chromo1.b = value2;
                    chromo2.b = value1;
                    break;
            }
        }

        public static List<chromosome> Cross(List<chromosome> population, ref List<int> fitness_values)
        {
            Random r = new Random();
            List<chromosome> new_population = new List<chromosome>();

            for (int i = 0; i < fitness_values.Count; i++)
            {
                int index_of_max_fitness = fitness_values.IndexOf(fitness_values.Max());
                new_population.Add(population[index_of_max_fitness]);
                fitness_values.RemoveAt(index_of_max_fitness);
            }

            int new_population_count = new_population.Count;

            for (int i = 0; i < fitness_values.Count; i++)
            {
                decimal cross_option =  (decimal) r.NextDouble();

                if (cross_option < cross_probability)
                {
                    if (i == new_population_count - 1)
                    {
                        chromosome chromo1 = population[i];
                        chromosome chromo2 = population[0];
                        Crossover(ref chromo1, ref chromo2);
                        population[i] = chromo1;
                        population[0] = chromo2;
                    }
                    else
                    {
                        chromosome chromo1 = population[i];
                        chromosome chromo2 = population[i+1];
                        Crossover(ref chromo1, ref chromo2);
                        population[i] = chromo1;
                        population[i+1] = chromo2;
                    }
                }
            }         
            return new_population;
        }

        public static void Mutation(ref chromosome chromo)
        {

            Random r = new Random();
            int x = r.Next(4);
            switch (x)
            {
                case 0:
                    if (chromo.x0 < mutation_value)
                        chromo.x0 += 1;
                    break;
                case 1:
                    if (chromo.y0 < mutation_value)
                        chromo.y0 += 1;
                    break;
                case 2:
                    if (chromo.a < mutation_value)
                        chromo.a += 1;
                    break;
                case 3:
                    if (chromo.b < mutation_value)
                        chromo.b += 1;
                    break;
            }
        }

        public static void Mutations(ref List<chromosome> population)
        {
            Random r = new Random();
            for (int i = 0; i < population.Count; i++)
            {
                decimal mutate_option  = (decimal)r.NextDouble();
                if (mutate_option < mutation_probability)
                {
                    chromosome chromo = population[i];
                    Mutation(ref chromo);
                    population[i] = chromo;
                }
            }
        }
    }
}
