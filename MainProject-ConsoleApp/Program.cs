using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedSource_ClassLibrary;
using SubProject_ClassLibrary;

namespace MainProject_ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            bool check = true;

            Console.WriteLine("Enter one or many numbers");
            Console.WriteLine("Enter nothing when finished");

            do
            {
                string[] inputs = Console.ReadLine().Split(',', ' ');

                if (inputs.Length == 1 && string.IsNullOrEmpty(inputs[0]))
                {
                    check = false;
                }
                else if (inputs.Length > 1)
                {
                    List<int> outputs = new List<int>() { result };
                    foreach (var input in inputs)
                    {
                        if (int.TryParse(input, out int output))
                        {
                            outputs.Add(output);
                        }

                        result = SubProjectClass.Sum(outputs);
                    }
                }
                else
                {
                    if (int.TryParse(inputs[0], out int output))
                    {
                        result = SharedClass.Add(result, output);
                    }
                }

                Console.WriteLine($"result: {result}");

            } while (check);
        }
    }
}
