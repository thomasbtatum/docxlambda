using System.IO;

namespace AWSServerless1.Services
{
    public interface IEbookService
    {
       MemoryStream CreatePackage();
    }
}