using System;

static class RandomExtensions
{
    public static void Shuffle<T> (this Random rng, T[] array)
    {
        int n = array.Length;
        while (n > 1) 
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
    public static void Main(string[] args) {
        Console.Write("Please enter the number of students in your class: ");
        try {
            int numOfStudents = Convert.ToInt32(Console.ReadLine());
            int[] ids = new int[numOfStudents];
            for (int i = 0;i < numOfStudents;i++) {
                ids[i] = i + 1;
            }
            new Random().Shuffle(ids);
            Console.WriteLine("Your order of students is: ");
            for (int i = 0;i < numOfStudents;i++) {
                Console.WriteLine(ids[i]);
            }
        } catch (Exception e) {
            Console.WriteLine("That is not a number you big dummy!");
            Console.WriteLine("Error = {0}", e);
        }
    }
}
