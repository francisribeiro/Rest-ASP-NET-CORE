using System.IO;

namespace RestASPNETCORE.Business.Implementations
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {
            string path = Directory.GetCurrentDirectory();
            var fulPath = path + "\\Other\\historico_28309.pdf";

            return File.ReadAllBytes(fulPath);
        }
    }
}
