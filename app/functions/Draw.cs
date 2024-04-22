 namespace EditorHtml{


 public static class Draw{

     public static void Lines(string border, string middle){
            Console.Write(border);
            for (int i = 0; i <= 30; i++)
                Console.Write(middle);
            
            Console.Write(border);
            Console.Write("\n");
     }

     public static char Comfirm(string message){
         Console.WriteLine(message + " [y/n]");
         Console.Write("> ");
         char option = 'n';
         switch(Console.ReadLine()!.ToLower()){
             case "y": {
                option = 'y'; 
                break;
             }
             case "n": {
                option = 'n'; 
                break;
             }
             default: {
                 Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option, please try again!");
                Console.ForegroundColor = ConsoleColor.Black;
                Comfirm(message); break;
             }
         }

         return option;
         
     }

     public static void Editor(string message){
        
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine(message);
        Lines("/", "-");
     }
 }
 }