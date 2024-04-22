using System.Text;

namespace EditorHtml
{
    public static class Input{
    
        public static int Index(int maxIndex){
        
            Console.Write("Index: ");
            string responseBrute = Console.ReadLine();

            if(int.TryParse(responseBrute, out int response) && response > 0 && response <= maxIndex){
                return response;
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Index invalid, please try again!");
                Console.ResetColor();
                Thread.Sleep(2500);
                return Index(maxIndex);
                }
        
        }

        public static string Text(){
            var file = new StringBuilder();

            do{
               file.Append(Console.ReadLine()); 
               file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            return file.ToString();
        }

    }
}