namespace CaesarEncryptionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE TEXT TO BE ENCRYPTED");
            string text = Console.ReadLine();
            Console.WriteLine("ENTER THE FREQUENCY");
            int frequency = Convert.ToInt32(Console.ReadLine());

            string encryptedText = encryption(text, frequency);
            Console.WriteLine(encryptedText);
            Console.ReadLine();
           
        }
        static string encryption(string text,int frequency)
        {
            string encryptedText = null;
            for (int i = 0; i < text.Length; i++)
            {
                encryptedText += Convert.ToChar(text[i] + frequency);
            }
           
            return encryptedText;

        }
    }
}
