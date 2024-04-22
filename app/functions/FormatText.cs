using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class FormatText{
        public static Regex Strong(){

            return new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");;
        }


    }
}