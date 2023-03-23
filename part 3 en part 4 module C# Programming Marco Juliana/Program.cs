namespace part_3_en_part_4_module_C__Programming_Marco_Juliana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("select and option");
                Console.WriteLine("1 Login");
                Console.WriteLine("2 Last Part Split");
                Console.WriteLine("3 CSVage");
                Console.WriteLine("4 CSVname");
                Console.WriteLine("5 CSV maxiumname and age ");
                Console.WriteLine("6 Bookclass");
                Console.WriteLine("7 reading strings");
                Console.WriteLine("8 reading int");
                Console.WriteLine("9 guestlist");
                Console.WriteLine("10 quit");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Lastpartsplit();
                        break;
                    case 3:
                        CSVage();
                        break;
                    case 4:
                        CSVname();
                        break;
                    case 5:
                        CSVmax();
                        break;
                    case 6:
                        BookClass();
                        break;
                    case 7:
                        ReadingStrings();
                        break;
                    case 8:
                        ReadingIntegers();
                        break;
                    case 9:
                        Guestlist();
                        break;
                    case 10:
                        running = false;
                        break;
                }
            }
            
        }

        static void Login()
            {
                List<string> loginScreen = new List<string>();
                loginScreen.Add("jarnee");
                loginScreen.Add("bikechain123");
                loginScreen.Add("loek");
                loginScreen.Add("geenrythme");
                Console.WriteLine("type username");
                string username = Console.ReadLine();
                Console.WriteLine("type password");
                string inputpassword = Console.ReadLine();
                string password = "";
                int i = loginScreen.IndexOf(username);
                password = loginScreen[i + 1];



                if (password == inputpassword)
                {
                    Console.WriteLine("Je bent ingelogd!");
                }
                else
                {
                    Console.WriteLine("verkeerde password");
                }
            }

            static void Lastpartsplit()
            {
                Console.WriteLine("input text");
                string textinput = Console.ReadLine();
                if (textinput == "")
                {
                    return;
                }
                string[] pieces = textinput.Split(" ");
                string lastword = pieces[pieces.Length - 1];
                Console.WriteLine(lastword);
            }
            static void CSVage()
            {

                int highestAge = 0;
                List<string> CSVage = new List<string>();

                bool aan = true;
                while (aan)
                {
                    Console.WriteLine("input text");
                    string userTextInput = Console.ReadLine();
                    CSVage.Add(userTextInput);

                    if (userTextInput == "")
                    {
                        aan = false;
                        foreach (string item in CSVage)
                        {
                            if (item == "")
                                continue;

                            int age = Convert.ToInt32(item.Split(",").Last());
                            if (highestAge < age)
                            {
                                highestAge = age;

                            }
                        }
                    }
                }

                Console.WriteLine($"highest age is {highestAge}");

            }

            static void CSVname()
            {

                int highestAge = 0;
                string oldestName = "";
                List<string> CSVage = new List<string>();

                bool aan = true;
                while (aan)
                {
                    Console.WriteLine("input text");
                    string userTextInput = Console.ReadLine();
                    CSVage.Add(userTextInput);

                    if (userTextInput == "")
                    {
                        aan = false;
                        foreach (string item in CSVage)
                        {
                            if (item == "")
                                continue;

                            int age = Convert.ToInt32(item.Split(",").Last());
                            string name = item.Split(",").First();
                            if (highestAge < age)
                            {
                                highestAge = age;
                                oldestName = name;

                            }
                        }
                    }
                }

                Console.WriteLine($"name of oldest {oldestName}");
                DateTime time = DateTime.Now;
                Console.WriteLine(time.Year);

            }
            static void CSVmax()
            {
                int highestAge = 0;
                string longestName = "";
                List<string> CSdata = new List<string>();

                int year = DateTime.Now.Year;


                bool aan = true;
                while (aan)
                {
                    Console.WriteLine("input text");
                    string userTextInput = Console.ReadLine();
                    CSdata.Add(userTextInput);

                    if (userTextInput == "")
                    {
                        aan = false;
                        foreach (string item in CSdata)
                        {
                            if (item == "")
                                continue;

                            int age = year - Convert.ToInt32(item.Split(",").Last());
                            string name = item.Split(",").First();
                            if (highestAge < age)
                            {
                                highestAge = age;

                            }
                            if (longestName.Length < name.Length)
                            {
                                longestName = name;

                            }
                        }
                    }
                }
                Console.WriteLine($"longestname {longestName}");
                Console.WriteLine($"highest age: {highestAge}");
            }

        static void BookClass()
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("enter book name: ");
                string? title = Console.ReadLine();
                if (string.IsNullOrEmpty(title))
                {
                    break;
                }

                Console.Write("enter number of pages: ");
                int numPages = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter publication year: ");
                int pubYear = Convert.ToInt32(Console.ReadLine());

                Book book = new Book(title, numPages, pubYear);
                books.Add(book);
            }

            Console.WriteLine("what information will be printed? ");
            string? printoption = Console.ReadLine();

            if (printoption == "everything")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine("{0} ({1} pages, published in {2})", book.Title, book.NumPages, book.PubYear);
                }
            }
            else if (printoption == "title")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

        static void ReadingStrings()
        {
            int teller = 0;
            bool doortellen = true;

            while (doortellen)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    doortellen = false;
                }
                else
                {
                    teller++;
                }
            }

            Console.WriteLine($"Je hebt {teller} strings geinput!");
        }

        static void ReadingIntegers()
        {

            bool doortellen = true;

            while (doortellen)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    doortellen = false;
                }
                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        int cube = number * number * number;
                        Console.WriteLine($"The cube of {number} is {cube}.");
                    }
                }
            }
        }

        static void Guestlist() {
            // Read a text file line by line.
            while (true)
            {
                Console.WriteLine("Enter names, an empty line quits. ");
                string input = Console.ReadLine();

                if (input == "") {
                    break;
                }
                
                string[] lines = File.ReadAllLines("C:\\Users\\marco\\Desktop\\part-3-en-part-4-module-C-Programming-Marco-Juliana-master\\part 3 en part 4 module C# Programming Marco Juliana\\names.txt");
                string[] lines2 = File.ReadAllLines("C:\\Users\\marco\\Desktop\\part-3-en-part-4-module-C-Programming-Marco-Juliana-master\\part 3 en part 4 module C# Programming Marco Juliana\\other-names.txt");
                List<string> names = new List<string>();   
                foreach (string line in lines.Concat(lines2).ToArray()) {
                    names.Add(line);

                }
                if (names.Contains(input))
                {
                    Console.WriteLine("the name is in the list" + input);
                }
                else {
                    Console.WriteLine("name is not in the list");
                }

            }
        }


    }
}


