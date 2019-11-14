using System.Collections.Generic;

namespace Akelon.Auchan.DocFactory
{
    public static class Placeholders
    {
        /// <summary>
        /// Тэг начала вставки текстового элемента
        /// </summary>
        public static string TextPlaceholderStartTag { get; set; }
        
        /// <summary>
        /// Тэг окончания вставки текстового элемента
        /// </summary>
        public static string TextPlaceholderEndTag { get; set; }

        /// <summary>
        /// Тэг перевода строки
        /// </summary>
        public static string NewLineTag { get; set; }
        public static Dictionary<string, string> TextPlaceholders { get; set; }

        static Placeholders()
        {
            TextPlaceholderStartTag = "#";
            TextPlaceholderEndTag = ">";
            NewLineTag = "<br/>";
            TextPlaceholders = new Dictionary<string, string>();            
            
        }
    }
}
