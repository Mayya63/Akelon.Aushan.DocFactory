using System.IO;
using System;

namespace Akelon.Auchan.DocFactory
{
    /// <summary>
    /// Класс для работы с файловыми данными
    /// </summary>
    public class StreamHandler
    {
        public static MemoryStream AddResourceToMemoryStream(byte[] resource)
        {
            try
            {
                MemoryStream ms = new MemoryStream(resource);
            
                ms.Position = 0;
                return ms;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }

        public static void WriteMemoryStreamToDisk(MemoryStream ms, string filename)
        {
            if (File.Exists(filename)) File.Delete(filename);

            ms.Position = 0; 

            using (FileStream file = new FileStream(filename, FileMode.Create, System.IO.FileAccess.Write))
                ms.CopyTo(file);
        }

    }
}
