using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test0919_HelloMVC.Models {
    public class UserDataModel {
        public string UserName { set; get; }
        public string Account { set; get; }
        public string Password { set; get; }
        public bool IsCheck() {
            //bool Result = false; 方法1
            int Error = 0;
            if (string.IsNullOrEmpty(this.Password)) {
                Error++; //若有Error +1 Error = 1 return false
            }
            if (this.Password == "Db Password") {
                Error++;
            }
            return (Error == 0); //true 
        }
    }
}