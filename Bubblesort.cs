using System;

namespace Bubble
{
	class Schort
	{
		static void print_arr(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + ", ");
			}
			Console.Write("\n");
		}

		static void do_bubble(int[] arr)
		{
			Random rndm = new Random();

            
            for (int i = 0; i < arr.Length-1; i++)
			{
                for (int j = 0; j < arr.Length-1-i; j++)
				{
                    if (arr[j] > arr [j+1])
                    {
                        int bittehelfensiemir = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = bittehelfensiemir;
                    }
                }
            }
        }

		static void Main(String[] args)
		{
			int[] arr = {2,5,1,3,6,8,9,9,4};
			print_arr(arr);
			do_bubble(arr);
			print_arr(arr);
		}
	}
}