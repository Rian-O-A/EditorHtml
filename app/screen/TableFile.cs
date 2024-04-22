namespace EditorHtml
{
    public static class TableFile{
        public static void Show(){

            try{

            string[] files = ManagerFile.ListFile();
            int maxIndexWidth = files.Length;
            int maxNameWidth = files.Max(file => Path.GetFileName(file).Length);
            int maxTypeWidth = files.Max(file => Path.GetExtension(file).Length);
            int maxPathWidth = files.Max(file => Path.GetFullPath(file).Length);
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Imprime o cabeçalho
            Console.WriteLine(new string('-', maxIndexWidth+ maxNameWidth + maxTypeWidth + maxPathWidth + 22));
            Console.WriteLine("| {0,-" + (maxIndexWidth + 2) + "} | {1,-" + (maxNameWidth + 2) + "} | {2,-" + (maxTypeWidth + 2) + "} | {3,-" + (maxPathWidth + 2) + "} |", "Index","Name", "Type", "Path");
            Console.WriteLine(new string('-',maxIndexWidth + maxNameWidth + maxTypeWidth + maxPathWidth + 22)); // Tamanho total dos campos + espaçamento

            // Itera sobre todos os arquivos e os exibe
            for (int i = 0; i < files.Length; i++){
                string file = files[i];
                string fileName = Path.GetFileName(file);
                string fileType = Path.GetExtension(file);
                string filePath = Path.GetFullPath(file);

                Console.WriteLine("| {0,-" + (maxIndexWidth + 4) + "} | {1,-" + (maxNameWidth + 2) + "} | {2,-" + (maxTypeWidth + 2) + "} | {3,-" + (maxPathWidth + 2) + "} |", i+1, fileName, fileType, filePath);
            }

            // Imprime a linha inferior
            Console.WriteLine(new string('-',maxIndexWidth + maxNameWidth + maxTypeWidth + maxPathWidth + 22));
            Console.ResetColor();

            SelectFile(maxIndexWidth);
            }catch(Exception e){
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: List file empty, please try create a new file.");
                Thread.Sleep(2500);
                Menu.Show();
            }
            
        }


        public static void SelectFile(int maxIndex){

        Draw.Lines("+", "-");    
        Console.WriteLine("SELECIONE UM ARQUIVO");
        Draw.Lines("+", "-");
         
        int index = Input.Index(maxIndex); 

        Viewer.Show(ManagerFile.ReadAllText(index));  

        
          
        }
    }
}