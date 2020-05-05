using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        

        public ViewResult Getmyview()
        {
            List<Empdetails> listobj = new List<Empdetails>();

            Empdetails obj = new Empdetails();
            obj.Empid = 1;
            obj.EmpName = "Sheshu";
            obj.Empsal = 1000;
            obj.Empaddress = "Hyd";

            Empdetails obj1 = new Empdetails();
            obj1.Empid = 2;
            obj1.EmpName = "AAAA";
            obj1.Empsal = 15000;
            obj1.Empaddress = "Bang";

            Empdetails obj2 = new Empdetails();
            obj2.Empid = 3;
            obj2.EmpName = "BBBBB";
            obj2.Empsal = 20000;
            obj2.Empaddress = "Vij";

            Empdetails obj3 = new Empdetails();
            obj3.Empid = 4;
            obj3.EmpName = "CCCC";
            obj3.Empsal = 30000;
            obj3.Empaddress = "Che";

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);
            listobj.Add(obj3);


            return View(listobj);
        }
    }
}