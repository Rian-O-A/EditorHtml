using System.Text;
using System.Xml.XPath;

namespace EditorHtml
{
    public static class Editor{
        public static void Show(){
          
           
            Draw.Editor("MODO EDITOR");
            Start();
        }
        public static void Start(){

            string text = Input.Text();
            Draw.Lines("/", "-");
            char option = Draw.Comfirm("Deseja salvar o arquivo?");
            if(option == 'y'){
                string name = Guid.NewGuid().ToString();
                bool result = ManagerFile.Salve(name, text);
                if(result){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Arquivo {name} salvo com sucesso!");
                    Menu.Show();
                }
            }
        }

        
    }
}