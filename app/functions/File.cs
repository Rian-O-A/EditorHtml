namespace EditorHtml
{
    public static class ManagerFile
    {
        public static string[] ReadAllText(int index)
         {
        string[] files = ListFile();
        string file = files[index - 1];
        Console.WriteLine("Name: "+Path.GetFileName(file) + "\nPath: "+Path.GetFullPath(file));
        string[] text = File.ReadAllLines(file);

        return text; 
        
    }

        public static bool Salve(string name, string text)
        {
            
            // Obtém o diretório de execução do programa
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            // Cria o caminho completo para o arquivo
            string filePath = Path.Combine(directoryPath, @"..\..\..\app\database\files", $"{name}.txt");

            try{

                using StreamWriter file = new StreamWriter(filePath);
                Console.Clear();
                file.WriteLine(text);
                return true;
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static  string[] ListFile(){
            
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(directoryPath, @"..\..\..\app\database\files\");
            // Obtém todos os arquivos na pasta
            return Directory.GetFiles(folderPath);
                 
    }
    }
}