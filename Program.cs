namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lektioner utifrån Codic videos");
            IfElse();
        }

        static void Variables()        
        {
           //kommentarer, kollegor, sig själv osv
            //variable är en behållare, med data i
            //olika typer av data i olika typer av variable
            
            int heltal; //har ett namn och typ, en siffra. ental 
            heltal = 1; //har ett innehåll 
            int störstaTalet = 2147483647;
            int smallestTalet = -2147483648;

            float decimaltal; 
            decimaltal = 132.3435f;

            char tecken;
            tecken = 'H';

            string mångaTecken = ("Här är en mening!");

            bool statement = true;

        }

        static void Constants()             
        {
            //const gör om en variable till en constant. kan inte ändras
            //
            int canChange = 43;
            canChange = 1234;

            const int cantChange = 42;
            //röd markerat cantChange = 12; 

        }

        static void Operatorer()       
        {
             //matte som i gymnasiet, kombinera variabler i uttryck. statement
             //math operators 
             //samma som de man är van vid / * - +
             //orkar inte nu
        }
       
        static void IfElse()
        {
            //alternativ 
            // use if/else to do something different depending on user input. 
            Console.WriteLine("Type the secret password: ");
            string input = Console.ReadLine();

            if (input == "Banana")
                Console.WriteLine("Hey! you knew the password!");
            else
                Console.WriteLine("This is what you wrote: \"" + input + "\"");


        }

        static void DoWhile()
        {
            //
            string hälsning = "Hejdå!";

        }
    }
}