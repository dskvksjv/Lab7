using Lab7.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace Lab7.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(FileDownloadModel model)
        {
            string content = $"First Name: {model.FirstName}\nLast Name: {model.LastName}";

            byte[] bytes = Encoding.ASCII.GetBytes(content);

            // Використовуйте назву файлу з моделі або за замовчуванням, якщо вона не вказана
            string fileName = string.IsNullOrEmpty(model.FileName) ? "default.txt" : $"{model.FileName}.txt";

            return File(bytes, "text/plain", fileName);
        }
    }
}
