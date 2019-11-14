using System.Collections.Generic;

namespace Akelon.Auchan.DocFactory
{
    public static class Placeholders
    {
        /// <summary>
        /// Тэг начала и конца вставки текстового элемента
        /// </summary>
        public static string TextPlaceholderTag { get; set; }
                
        /// <summary>
        /// Тэг перевода строки
        /// </summary>
        public static string NewLineTag { get; set; }
        public static Dictionary<string, string> TextPlaceholders { get; set; }

        static Placeholders()
        {
            TextPlaceholderTag = "#";
            TextPlaceholders = new Dictionary<string, string>();            
            
        }
    }
}
