namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook NoteBook = new PhoneBook(5);

            NoteBook.AddNumber(0, "Ahmed", 11111152422);
            NoteBook.AddNumber(1, "Mohammed", 11114512789);
            NoteBook.AddNumber(2, "Omar", 1546480001);
            NoteBook.AddNumber(3, "Hassan", 12585456365);
            NoteBook.AddNumber(4, "Mostafa", 12545454554);

            for (int i = 0; i < NoteBook.Size; i++)
            {
                Console.WriteLine(NoteBook[i]);
            }
            Console.WriteLine("---------------------------------------------------");
            NoteBook["Omar"] = 1111111111;
            //Console.WriteLine(NoteBook["Omar"]);

            for(int i = 0; i < NoteBook.Size; i++)
            {
                Console.WriteLine(NoteBook[i]);
            }
        }
    }
}