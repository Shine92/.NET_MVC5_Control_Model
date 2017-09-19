using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test0919_HelloMVC.Models;

namespace test0919_HelloMVC.Controllers
{
    public class LabController : Controller
    {
        // GET: Lab
        //public ActionResult Index() //方法1
        //{
        //    ViewBag.UserName = "Db UserName";
        //    ViewBag.Account = "Db Account";
        //    ViewBag.Password = "Db Password";
        //    return View();
        //}
        public ActionResult Index() //方法1
        {
            UserDataModel UserData = new UserDataModel(); //建立物件
            UserData.Password = "Db Password";
            return View(UserData); //傳進View
        }

        //[HttpPost]  //方法1 FormCollection
        //public ActionResult Index(FormCollection frm) {
        //    string UserName = frm["UserName"]; //使用變數 減少次數
        //    string Account = frm["Account"];   //使用變數 減少次數
        //    string Password = frm["Password"]; //使用變數 減少次數

        //    ViewBag.UserName = UserName;
        //    ViewBag.Account = Account;
        //    ViewBag.Password = Password;
        //    if (Password == "Db Password" || string.IsNullOrEmpty(Password)) { //若是舊值就回到同一個頁面
        //        return View();
        //    }
        //    return View("SayHello"); //若是已更改現值就到SayHello
        //}
        //[HttpPost]  //方法2 欄位 =>物件屬性
        //public ActionResult Index(UserDataModel UserData) { //讚嘆微軟

        //    if (UserData.Password == "Db Password" || string.IsNullOrEmpty(UserData.Password)) { //若是舊值就回到同一個頁面
        //        return View(UserData); //傳值進去 否則拋出哥沒有女朋友
        //    }
        //    return View("SayHello",UserData); //若是已更改現值就到SayHello ,Model傳進SayHello
        //}
        [HttpPost]  //方法2 欄位 =>物件屬性
        public ActionResult Index(UserDataModel UserData) { //讚嘆微軟

            if (!UserData.IsCheck()) { //若是舊值就回到同一個頁面
                return View(UserData); //傳值進去 否則拋出哥沒有女朋友
            }
            return View("SayHello", UserData); //若是已更改現值就到SayHello ,Model傳進SayHello
        }
    }
}