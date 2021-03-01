using System;

namespace Programming_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, N;
            int task;
            Console.Write("Введите номер задачи: ");
            task = Convert.ToInt32(Console.ReadLine());

            if (task == 1)
            {
                /// <summary>
                /// Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
                /// </summary>

                int A1, B1;
                double RES1 = 1;
                Console.Write("Введите число A: ");
                A1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число B: ");
                B1 = Convert.ToInt32(Console.ReadLine());

                if (A1 == 0 && B1 == 0)
                {
                    Console.WriteLine("Неопределенность");
                }
                else if (B1 < 0)
                {
                    for (int i = 0; i > B1; i--)
                    {
                        RES1 /= A1;
                    }
                    Console.WriteLine(RES1);
                }
                else
                {
                    for (int i = 0; i < B1; i++)
                    {
                        RES1 *= A1;
                    }
                    Console.WriteLine(RES1);
                }
            }
            else if (task == 2)
            {
                /// <summary>
                /// Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
                /// </summary>

                int A1;
                Console.Write("Введите число A: ");
                A1 = Convert.ToInt32(Console.ReadLine());

                if (A1 > 0 && A1 <= 1000)
                {
                    for (int i = A1; i <= 1000; i += A1)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Число больше 1000");
                }


            }
            else if (task == 3)
            {
                /// <summary>
                /// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, 
                /// квадрат которых меньше A.
                /// </summary>


            }
            else if (task == 9)
            {
                /// <summary>
                /// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
                /// </summary>

                Console.Write("Введите число N: ");
                N = Convert.ToInt32(Console.ReadLine());
                int number9 = 0;
                for (int i = 0; i < N.ToString().Length; i++)
                {
                    char number = N.ToString()[i];
                    if ((int)Char.GetNumericValue(number) % 2 != 0)
                    {
                        number9++;
                    }
                }
                Console.WriteLine(number9);
            }
            else if (task == 10)
            {
                /// <summary>
                /// Пользователь вводит 1 число. Найти число, которое является зеркальным 
                /// отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
                /// </summary>

                Console.Write("Введите число N: ");
                N = Convert.ToInt32(Console.ReadLine());
                string newAns = "";
                for (int i = N.ToString().Length - 1; i >= 0; i--)
                {
                    newAns += N.ToString()[i];
                }
                Console.WriteLine(newAns);
            }
            else if (task == 11)
            {
                /// <summary>
                /// Пользователь вводит целое положительное  число (N).
                /// Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
                /// </summary>

                Console.Write("Введите число N: ");
                N = Convert.ToInt32(Console.ReadLine());
                string currentNum;
                int sum;
                for (int i = 1; i <= N; i++)
                {
                    currentNum = Convert.ToString(i);
                    sum = 0;
                    for (int j = 0; j < currentNum.Length; j++)
                    {
                        if ((int)(Char.GetNumericValue(currentNum[j])) % 2 == 0)
                        {
                            sum += (int)(Char.GetNumericValue(currentNum[j]));
                        }
                        else
                        {
                            sum -= (int)(Char.GetNumericValue(currentNum[j]));
                        }
                    }
                    if (sum > 0)
                    {
                        Console.Write(i + " ");
                    }
                }

            }
            else if (task == 12)
            {
                /// <summary>
                /// Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
                /// Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
                /// </summary>

                int digitA, tempB;
                bool FLAG = false;
                Console.Write("Введите число A: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число B: ");
                B = Convert.ToInt32(Console.ReadLine());

                if ((A != 0) && (B != 0))
                {
                    while ((A / 10 > 0) || (A % 10 != 0))
                    {
                        digitA = A % 10;
                        tempB = B;
                        while ((tempB / 10 > 0) || (tempB % 10 != 0))
                        {
                            if (tempB % 10 == digitA)
                            {
                                FLAG = true;
                                Console.Write("ДА");
                                break;
                            }
                            tempB /= 10;
                        }
                        if (FLAG) break;
                        A /= 10;
                    }
                    if (!FLAG) Console.Write("НЕТ");
                }
                else if (A != B)
                {
                    tempB = A + B;
                    while ((tempB / 10 > 0) || (tempB % 10 != 0))
                    {
                        if (tempB % 10 == 0)
                        {
                            FLAG = true;
                            Console.Write("ДА");
                            break;
                        }
                        tempB /= 10;
                    }
                    if (!FLAG) Console.Write("НЕТ");
                }
                else
                {
                    Console.Write("ДА");
                }

            }
        }
    }
}
