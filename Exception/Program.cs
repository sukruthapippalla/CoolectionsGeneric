namespace Exception
{
    public class Program
    {
        public static void Main(string[] args)
        {
			try
			{
                int a = 1;
                int b = 0;
                int res = a / b;
                Console.WriteLine(res);
			}
			catch (DivideByZeroException ex)
			{

                Console.WriteLine(ex.Message);
			}

			//try
			//{
			//	object x;
   //             Console.WriteLine(x);
			//}
			//catch (NullReferenceException ex)
			//{
   //             Console.WriteLine(ex.Message);
			//}

			try
			{
				int[] arr = [1, 2, 3, 4, 5];
				Console.WriteLine(arr[6]);
			}
			catch (IndexOutOfRangeException ex)
			{
                Console.WriteLine(ex.Message);
			}

			try
			{
				long x = 2334456742245;
				//int y = x;
			}
			catch (OverflowException ex)
			{

                Console.WriteLine(ex.Message);
			}

			try
			{
				int x = 0;
				int y = 1;
				int z = y / x;
			}
			catch (System.Exception)
			{

				throw;
			}
			finally
			{
                Console.WriteLine("Done");
			}
        }
    }
}
