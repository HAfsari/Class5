using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Class5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class5.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult FileInfo()
        {
            //String dir = Directory.GetCurrentDirectory();
            String dir = @"C:\Users\hejbu\Videos";
            String[] file = Directory.GetFiles(dir);
            List<FileList> list = new List<FileList>();
            int sl = 1;

            foreach (var i in file)
            {
                FileList fileList = new FileList();
                fileList.id = sl;
                fileList.name = Path.GetFileNameWithoutExtension(i);
                fileList.type = Path.GetExtension(i);
                fileList.path = Path.GetFullPath(i);

                list.Add(fileList);
                sl++;
            }
             return View(list);
        }
    }
}
