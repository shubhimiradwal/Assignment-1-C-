using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public float TotalAmount;
        static void Main(string[] args)
        {
            List<Program> pro = new List<Program>();
            pro.Add(new Program { Name = "lettuce", Price = 10.5f, Quantity = 50, Type = "Leafy green" });
            pro.Add(new Program { Name = "cabbage", Price = 20f, Quantity = 100, Type = "Cruciferous" });
            pro.Add(new Program { Name = "Pumpkin", Price = 30f, Quantity = 30, Type = "Marrow" });
            pro.Add(new Program { Name = "cauliflower", Price = 10f, Quantity = 25, Type = "Cruciferous" });
            pro.Add(new Program { Name = "zucchini", Price = 20.5f, Quantity = 50, Type = "Marrow" });
            pro.Add(new Program { Name = "yam", Price = 30f, Quantity = 30, Type = "Root" });
            pro.Add(new Program { Name = "spinach", Price = 10f, Quantity = 100, Type = "Leafy green" });
            pro.Add(new Program { Name = "broccoli", Price = 20.2f, Quantity = 75, Type = "Cruciferous" });
            pro.Add(new Program { Name = "garlic", Price = 30f, Quantity = 20, Type = "Leafy green" });
            pro.Add(new Program { Name = "silverbeet", Price = 10f, Quantity = 50, Type = "Marrow" });

            Console.WriteLine(pro.Count);
            pro.Add(new Program { Name = "Potato", Price = 10f, Quantity = 50, Type = "Root" });

            for (int i = 0; i < pro.Count; i++)
            {
                Console.WriteLine($" Name={ pro[i].Name} Price={pro[i].Price} Quantity={pro[i].Quantity} Type={pro[i].Type}");

            }
            for (int i = 0; i < pro.Count; i++)
            {
                if (pro[i].Type == "Leafy green")
                {
                    Console.WriteLine($" Name={ pro[i].Name} Price={pro[i].Price} Quantity={pro[i].Quantity} Type={pro[i].Type}");
                }

                if(pro[i].Name=="cabbage")
                {
                    pro[i].Quantity +=  50;
                    Console.WriteLine(pro[i].Quantity);
                }
            }
            pro.RemoveAll(v => v.Name == "garlic");
            Console.WriteLine(pro.Count);
            float TotalAmount = (1 * 10.5f) + (2 * 20.5f) + (1 * 20.2f);
            Console.WriteLine(TotalAmount);
        }



}








        }


