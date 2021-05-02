using System;

//9. Результаты соревнований фигуристов по одному из видов многоборья представлены 
//оценками 7 судей в баллах (от 0,0 до 6,0). По
//результатам оценок судьи определяется место каждого участника у
//этого судьи. Места участников определяются далее по сумме мест,
//которые каждый участник занял у всех судей. Составить программу,
//определяющую по исходной таблице оценок фамилии и сумму мест
//участников в порядке занятых ими мест

namespace lesson
{
	struct Judge 
	{
		public int[,] results1;
	}
    
	class Matrix
    {   
		static void Main(string[] args)
        {
			Judge judge;
			const int n = 7; // число судей
        	const int m = 4; // число участников
			// исходная таблица оценок судей
            int[,] results = new int[n, m]
            {
				// построчно расположены оценки 1-го - m-го участника
                { 1, 2, 3, 1 }, // оценки первого судьи
				{ 2, 6, 5, 3 }, // оценки второго судьи
				{ 3, 4, 5, 2 }, // оценки третьего судьи
				{ 4, 6, 5, 4 }, // оценки червёртого судьи
				{ 5, 4, 5, 1 }, // оценки пятого судьи
				{ 6, 1, 5, 3 }, // оценки шестого судьи
				{ 1, 3, 5, 2 }  // оценки седьмого судьи
            };
			judge.results1 = results;
			Console.WriteLine("таблица оценок:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write("{0,3}", results[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			
			int[,] output = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				int[] marks = new int[m];
				for (int j = 0; j < m; j++)
				{
					marks[j] = results[i, j];
				}
				Sort(marks);
				// в изначальную таблицу оценок записываем места фигуристов
				for (int k = 0; k < m; k++)
				{
					int num = 0;
					for (int q = 0; q < m; q++)
					{
						if (results[i, k] == marks[q] && marks[q] != num)
						{
							num = marks[q];
							output[i, k] = q + 1;
						}
					}
				}
			}

			int[] sum = new int[m]; // Массив с суммой мест каждого участника

			// таблица мест
			Console.WriteLine("таблица мест:");
			for (int k = 0; k < m; k++)
			{
				Console.Write("{0,3}", $"№{k + 1}");
			}
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write("{0,3}", output[i, j]);
					sum[j] = sum[j] + output[i, j];
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			
			int[] sum_copy = new int[m]; // копия до сортировки
			for (int i = 0; i < m; i++)
			{
				sum_copy[i] = sum[i];
			}

			// сортировка массива с суммой мест
			Sort(sum); // массив сортирован по убыванию
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if (sum_copy[j] == sum[m - i - 1])
					{
						Console.WriteLine("Competitor №{0}) {1}", j + 1, sum[m - i - 1]);
					}
				}
			}

            Console.ReadKey();
        }
		
		// сортирующий метод
		static int[] Sort(int[] ar)
        {
            for(int i = 0; i < ar.Length; i++)
            {
                int max = i;
                for(int j = i + 1; j < ar.Length; j++)
				{
                    if(ar[j] > ar[max])
                        {
							max = j;
						}
				}
				int temp = ar[i];
                ar[i] = ar[max];
                ar[max] = temp;
            }
			return ar;
        }
    }
}
