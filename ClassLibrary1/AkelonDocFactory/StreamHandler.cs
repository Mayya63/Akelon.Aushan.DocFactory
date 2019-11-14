using System.IO;

namespace Akelon.Auchan.DocFactory
{
    public class StreamHandler
    {
        public static MemoryStream GetFileAsMemoryStream(string filename)
        {
            MemoryStream ms = new MemoryStream();
            FileStream stream = null;

            try
            {
                stream =  new FileStream(filename, FileMode.Open, FileAccess.Read);
                
                using (stream)
                {
                    stream.CopyTo(ms);
                }            
            }
            catch (IOException)
            {
                if (stream != null)
                    stream.Close();
                throw;
            }
                                  
            ms.Position = 0;
            return ms;   
            
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
