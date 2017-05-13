using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Ruggeri.Nicolò._5h.WebAccessDatabase.Models;


namespace Ruggeri.Nicolò._5h.WebAccessDatabase.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Query(string query)
        {
            DAL dal = new DAL("PrenotazioniViaggi.accdb");
            DataTable table = dal.Getdata(query);
            return View(table);
        }
    }
}