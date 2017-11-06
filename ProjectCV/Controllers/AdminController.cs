using DAL.Repo;
using DAL.VM;
using Entitiy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ProjectCV.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(VMLogin data)
        {
            if (data.Komut == "Gir")
            {
                var islem = LoginRepo.Giris(data);
                if (islem != null)
                {
                    Session["User"] = islem.UserID;
                    Session["Name"] = islem.AdSoyad;
                    return RedirectToAction("Admin",islem);
                }
                else
                {
                    TempData["UyariTipi"] = "text-danger";
                    TempData["Sonuc"] = "Kullanıcı Adı Yada Parolası Hatalı!";
                    return View();
                }
            }
            else if (data.Komut == "Kayit")
            {
                var islem = LoginRepo.Kayit(data);
                if (islem != null)
                {
                    Session["User"] = islem.UserID;
                    Session["Name"] = islem.AdSoyad;
                    return RedirectToAction("Admin",islem);
                }
                else
                {
                    TempData["UyariTipi"] = "text-danger";
                    TempData["Sonuc"] = "Kullanıcı Sisteme Kaydedilemedi!";
                    return View();
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Genel Hata!";
                return View();
            }
        }
        public ActionResult Admin(User Data)
        {
            if (Session["User"] != null)
            {
                return View(Data);
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public ActionResult Admin(VMUser Data, HttpPostedFileBase Resim, HttpPostedFileBase Resim2)
        {
            if (Session["User"] != null)
            {
                if (System.IO.File.Exists(Server.MapPath("~" + Data.Resim)))
                {
                    System.IO.File.Delete(Server.MapPath("~" + Data.Resim));
                }

                WebImage img = new WebImage(Resim.InputStream);
                FileInfo imginfo = new FileInfo(Resim.FileName);
                string newfoto = Guid.NewGuid().ToString() + imginfo.Extension;
                img.Resize(300, 300, false);
                img.Save("~/img/User/" + newfoto);
                Data.Resim = "/img/User/" + newfoto;
                return View(Data);
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult Logoff()
        {
            Session.Abandon();
            return RedirectToAction("Index", "View");
        }
    }
}