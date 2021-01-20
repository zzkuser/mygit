using Microsoft.AspNetCore.Mvc;
using netcore01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace netcore01.Controllers
{
    /// <summary>
    /// 2021-01-19
    /// z
    /// content控制器
    /// </summary>
    public class ContentControlle : Controller
    {
        ///<summary>
        ///首页显示
        ///</summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 0; i < 11; i++)
            {
                contents.Add(new Content {Id=i,Title=$"{i}的标题",Content_l= $"{i}的内容",Status=1,Add_time=DateTime.Now.AddDays(-1)});
            }
            return View(new ContentViewModel { Contents=contents});
        }
    }
}
