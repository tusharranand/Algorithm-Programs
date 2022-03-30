using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class Permutation
    {
        StringBuilder perms;
        string[] List_of_Permutations;
        int Fact = 1;
        public Permutation()
        {
            Console.Write("Enter the string: ");
            string Str = Console.ReadLine();
            for (int i = 1; i <= Str.Length; i++)
                Fact = Fact * i;
            List_of_Permutations = new string[Fact];
            Fact = 0;

            char[] Letters = Str.ToCharArray();

            int A = 0;
            int B = Letters.Length - 1;

            Begin(Letters, A, B);
            Display();
        }

        public void Begin(char[] Letters, int A, int B)
        {
            if (A == B)
            {
                perms = new StringBuilder();
                foreach (char c in Letters)
                    perms.Append(c);
                List_of_Permutations[Fact] = perms.ToString();
                Fact++;
            }
            else
            {
                for (int i = A; i <= B; i++)
                {
                    Swap(Letters, A, i);
                    Begin(Letters, A + 1, B);
                    Swap(Letters, A, i);
                }
            }
        }
        public void Swap(char[] Letters, int x, int y)
        {
            char temp = Letters[x];
            Letters[x] = Letters[y];
            Letters[y] = temp;
        }
        public void Display()
        {
            foreach (string Perm in List_of_Permutations)
                Console.WriteLine(Perm);
        }
    }
}
