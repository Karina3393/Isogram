namespace Isogram
{
    internal class Program
    {
        static void Main()
        {
          
            Console.WriteLine("Введіть слово або фразу:");
            string input = Console.ReadLine().ToLower(); 
           
            string filteredInput = new string(input.Where(c => char.IsLetter(c)).ToArray());

            
            bool isIsogram = filteredInput.Distinct().Count() == filteredInput.Length;

            
            if (isIsogram)
            {
                Console.WriteLine("Це ізограма.");
            }
            else
            {
                Console.WriteLine("Це не ізограма.");
            }
        }
    }
}
