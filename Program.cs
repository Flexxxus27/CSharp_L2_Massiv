namespace CSharp_L2_Massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Массивы и строки
            //обычный массив
            int[,] Arr = new int[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };
            //Зубчатый массив
            int[][] Arr2 = new int[3][];
            Arr2[0] = new int[] { };
            //перебор массиваИ
            /*
        int[] ss = new int[] { 1, 2, 3, 4, 5 };
        foreach (int i in ss) 
        {
            Console.WriteLine(i);
        }
            */

            // Задача 1.
            /*
            int[] Arr3 = new int[] { 1761, 21, 32, 65, 12, 51, 85, 5643, 864, 98, 4316, 7837 };
            int chet = 0, nechet = 0, unique = 0;

            foreach (int i in Arr3) 
            {
                if (i % 2 == 0) chet++;
                else nechet++;
            }

            for (int i = 0; i < Arr3.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < Arr3.Length; j++)
                {
                    if(i != j && Arr3[i] == Arr3[j])
                    {
                        isUnique = false;break;

                    }
                }
                if (isUnique) unique++;
            }

            Console.WriteLine(chet);
            Console.WriteLine(nechet);
            Console.WriteLine(unique);
            */

            //Задача 2.
            /*
            int Num, count = 0;
            int[] Arr4 = new int[] { 1, 65, 32, 12, 64, 3, 23, 55, 91, 36 };
            Num = Convert.ToInt32(Console.ReadLine());

            foreach(int i in Arr4) 
            {
                if (i < Num) count++;
            }
            Console.WriteLine(count);
            */

            //Задача 3.
            /*
            int[,] Arr5 = new int[3, 5] { {45, 38, 76,22, 67 }, {56, 75, 25, 13, 87 }, {43, 5, 28, 43, 98 } };

            int rows = Arr5.GetLength(0);
            int cols = Arr5.GetLength(1);

            int min = Arr5[0, 0], max = Arr5[0,0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Arr5[i, j] > max) max = Arr5[i, j];
                    if (Arr5[i, j] < min) min = Arr5[i, j];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            */

            //Строки

            //string str = "adasda";
            //char[] a = str.ToCharArray();

            //Задача 1.
            /*
            string str1 = Console.ReadLine();
            string[] words = str1.Split(" ");

            Console.WriteLine(words.Length);
            */

            //Задача 2.
            /*
            string str2 = Console.ReadLine();
            string[] RWords = str2.Split(" ");

            foreach (string i in RWords) {

                char[] charArray = i.ToCharArray();
                Array.Reverse(charArray);
                string reversWords = new string (charArray);
                Console.Write(reversWords + " ");

            }
            */


            //1. Интерполяция 

            int num1 = 10;
            string str3 = $"цена: {num1}";

            //2. Метод string.Format

            string str4 = string.Format("Qwerty11 {0}, {1}", num1, str3);

            // 3. Метод concat

            string str5 = string.Concat("asdasda", num1);

            //4. Сложение строк

            string str6 = str5 + str4;
    
        }

            //enum En {el1 = 1,el2 = 5 };

    }
}
