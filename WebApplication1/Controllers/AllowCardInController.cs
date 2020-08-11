using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// 允许进卡
    /// </summary>
    public class AllowCardInController : ApiController
    {
        // GET api/allowcardin
        public string Get()
        {
            return "1";
            //R<string> result = new R<string>();
            //try
            //{
            //    bool flag = HardWareService.AllowCardIn();
            //    if (flag)
            //    {

            //        result.Code = 200;
            //        result.Data = "SUCCESS";
            //        result.Message = "允许进卡成功";
            //    }
            //    return result;
            //}
            //catch (Exception e)
            //{
            //    result.Code = 500;
            //    result.Data = "Exception";
            //    result.Message = e.Message;
            //    return result;
            //}


        }


    }
}