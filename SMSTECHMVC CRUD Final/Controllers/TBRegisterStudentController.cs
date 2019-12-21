using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class TBRegisterStudentController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Upload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
                file.SaveAs(path);
                Session["Imageurl"] = path;

            }

        }
        [HttpGet]
        public ActionResult Insert(string Name, string DOB,string Gender,string Class, string Section, string Status, string DateOfAdmission)
        {
            TB_RegisterStudent trs = new TB_RegisterStudent();
            trs.Name = Name;
            trs.DOB = DOB;
            string path = Session["Imageurl"].ToString();
            Image img = Image.FromFile(path);
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, ImageFormat.Png);
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes = new byte[800000];
            tmpStream.Read(imgBytes, 0, 800000);
            //trs.Image = imgBytes;
            trs.Gender = Gender;
            trs.Class = Class;
            trs.Section = Section;
            trs.Status = Status;
            trs.DateOfAdmission = DateOfAdmission;
            db.TB_RegisterStudent.Add(trs);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}