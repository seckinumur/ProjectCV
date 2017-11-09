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
                    TempData["Veri"] = "Hosgeldin();";
                    TempData["Uyari"] = null;
                    return RedirectToAction("Admin");
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
                    TempData["Veri"] = "BildirimVarUyarisi();";
                    TempData["Uyari"] = null;
                    return RedirectToAction("Admin");
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
        public ActionResult Admin()
        {
            if (Session["User"] != null)
            {
                ViewBag.Sifirla = UserRepo.AdminKontrol(Session["User"].ToString());
                var gonder = UserRepo.KullaniciBul(Session["User"].ToString());
                return View(gonder);
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public ActionResult Admin(VMUser Data, HttpPostedFileBase image)
        {
            if (Session["User"] != null)
            {
                if (System.IO.File.Exists(Server.MapPath("~" + Data.Resim)))
                {
                    System.IO.File.Delete(Server.MapPath("~" + Data.Resim));
                }

                WebImage img = new WebImage(image.InputStream);
                FileInfo imginfo = new FileInfo(image.FileName);
                string newfoto = Guid.NewGuid().ToString() + imginfo.Extension;
                img.Resize(300, 300, false);
                img.Save("~/img/User/" + newfoto);
                Data.Resim = "/img/User/" + newfoto;

                ViewBag.Sifirla = UserRepo.AdminKontrol(Session["User"].ToString());
                var gonder = UserRepo.KaydetGuncelle(Data);
                return View(gonder);
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult Proje()
        {
            if (Session["User"] != null)
            {
                var gonder = UserRepo.UserFindViewID(Session["User"].ToString());
                if (gonder == null)
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Admin");
                }
                else
                {
                    return View(gonder);
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public ActionResult Proje(VMProje Data)
        {
            if (Session["User"] != null)
            {
                bool sonuc = false;
                if (Data.Komut == "Kaydet")
                {
                    sonuc = ProjeRepo.Kaydet(Data);
                }
                if (Data.Komut == "Guncelle")
                {
                    sonuc = ProjeRepo.Guncelle(Data);
                }
                if (sonuc == true)
                {
                    TempData["Uyari"] = "Basarili();";
                    return RedirectToAction("Proje");
                }
                else
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Proje");
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult ProjeSil(int id)
        {
            if (Session["User"] != null)
            {
                bool gonder = ProjeRepo.Sil(id);
                if (gonder == true)
                {
                    TempData["Uyari"] = "Basarili();";
                    return RedirectToAction("Proje");
                }
                else
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Proje");
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult IsDeneyimi()
        {
            if (Session["User"] != null)
            {
                var gonder = UserRepo.UserFindViewID(Session["User"].ToString());
                if (gonder == null)
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Admin");
                }
                else
                {
                    return View(gonder);
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public ActionResult IsDeneyimi(VMIs Data)
        {
            if (Session["User"] != null)
            {
                bool sonuc = false;
                if (Data.Komut == "Kaydet")
                {
                    sonuc = IsRepo.Kaydet(Data);
                }
                if (Data.Komut == "Guncelle")
                {
                    sonuc = IsRepo.Guncelle(Data);
                }
                if (sonuc == true)
                {
                    TempData["Uyari"] = "Basarili();";
                    return RedirectToAction("IsDeneyimi");
                }
                else
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("IsDeneyimi");
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult IsDeneyimiSil(int id)
        {
            if (Session["User"] != null)
            {
                bool gonder = IsRepo.Sil(id);
                if (gonder == true)
                {
                    TempData["Uyari"] = "Basarili();";
                    return RedirectToAction("IsDeneyimi");
                }
                else
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("IsDeneyimi");
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult Egitim()
        {
            if (Session["User"] != null)
            {
                var gonder = UserRepo.UserFindViewID(Session["User"].ToString());
                if (gonder == null)
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Admin");
                }
                else
                {
                    return View(gonder);
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public ActionResult Egitim(VMEgitim Data)
        {
            if (Session["User"] != null)
            {
                bool sonuc = false;
                if (Data.Komut == "Kaydet")
                {
                    sonuc = EgitimRepo.Kaydet(Data);
                }
                if (Data.Komut == "Guncelle")
                {
                    sonuc = EgitimRepo.Guncelle(Data);
                }
                if (sonuc == true)
                {
                    TempData["Uyari"] = "Basarili();";
                    return RedirectToAction("Egitim");
                }
                else
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Egitim");
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult EgitimSil(int id)
        {
            if (Session["User"] != null)
            {
                bool gonder = EgitimRepo.Sil(id);
                if (gonder == true)
                {
                    TempData["Uyari"] = "Basarili();";
                    return RedirectToAction("Egitim");
                }
                else
                {
                    TempData["Uyari"] = "Basarisiz();";
                    return RedirectToAction("Egitim");
                }
            }
            else
            {
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Tarayıcıda Oturum Süreniz Dolmuş! Lütfen Tekrar Oturum Açın!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult AdminKontrol()
        {
            var kontrol = UserRepo.AdminKontrol(Session["User"].ToString());
            if(kontrol == true)
            {
                bool sonuc = ResetRepo.Sifirla();
                if(sonuc == true)
                {
                    string Sil = Server.MapPath(@"~/img/User");
                    Directory.Delete(Sil, true);
                    string Sil2 = Server.MapPath(@"~/img/Work");
                    Directory.Delete(Sil2, true);
                    DirectoryInfo dir = new DirectoryInfo(Server.MapPath(@"~/img/Backup/"));
                    Directory.CreateDirectory(Server.MapPath(@"~/img/User"));
                    Directory.CreateDirectory(Server.MapPath(@"~/img/Work"));
                    foreach (var item in dir.GetFiles())
                    {
                        System.IO.File.Copy(item.FullName, Server.MapPath(@"~/img/User" + item.Name), true);
                    }
                    
                    Session.Abandon();
                    TempData["UyariTipi"] = "text-danger";
                    TempData["Sonuc"] = "Site Sıfırlandı!";
                    return RedirectToAction("Login", "Admin");
                }
                else
                {
                    Session.Abandon();
                    TempData["UyariTipi"] = "text-danger";
                    TempData["Sonuc"] = "Site Sıfırlanamadı!";
                    return RedirectToAction("Login", "Admin");
                }
            }
            else
            {
                Session.Abandon();
                TempData["UyariTipi"] = "text-danger";
                TempData["Sonuc"] = "Yetkisiz Giriş!";
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