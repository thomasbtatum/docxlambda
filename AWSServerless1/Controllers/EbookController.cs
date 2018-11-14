using AWSServerless1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbookController : ControllerBase
    {
        private readonly IEbookService _ebookService;

        public EbookController(IEbookService ebookService)
        {
            _ebookService = ebookService;
        }

        [HttpGet]
        public IActionResult GetEbook()
        {
            var ms = _ebookService.CreatePackage();
            var filename = "sample.docx";
            var fileContentResult = new FileContentResult (ms.ToArray(), "application/octet-stream")
            {
                FileDownloadName = filename
            };
            // I need to delete file after me
            //System.IO.File.Delete(filename);
            return fileContentResult;// Ok();
        }

    }
}