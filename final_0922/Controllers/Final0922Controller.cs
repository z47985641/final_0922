using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_0922.Controllers
{
    public class Final0922Controller : Controller
    {
        // GET: Final0922
        public ActionResult Room()
        {
            MingSuEntities db = new MingSuEntities();
            var R_datas = from p in db.Room
                          select p;  
            return View(R_datas);
        }
        public ActionResult Room_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Room_Create(Room Data_R)
        {
            MingSuEntities db = new MingSuEntities();
            db.Room.Add(Data_R);
            db.SaveChanges();
            return RedirectToAction("Room");
        }
        public ActionResult Room_Edit(int? R_id)
        {
            MingSuEntities db = new MingSuEntities();
            Room R_data = db.Room.FirstOrDefault(R => R.RoomID == R_id);
            if (R_data != null)
                return View(R_data);
            return RedirectToAction("Room");
        }
        [HttpPost]
        public ActionResult Room_Edit(Room Data_R)
        {
            MingSuEntities db = new MingSuEntities();
            Room R_data = db.Room.FirstOrDefault(R => R.RoomID == Data_R.RoomID);
            if (R_data != null)
            {
                R_data.RoomName = Data_R.RoomName;
                R_data.RoomPrice = Data_R.RoomPrice;
                R_data.RoomIntrodution = Data_R.RoomIntrodution;
                R_data.MemberID = Data_R.MemberID;
                R_data.RoomstatusID = Data_R.RoomstatusID;
                R_data.Address = Data_R.Address;
                R_data.CreateDate = Data_R.CreateDate;
                db.SaveChanges();
            }
                
            return RedirectToAction("Room");
        }
            public ActionResult Order()
        {
            MingSuEntities db = new MingSuEntities();
            var O_datas = from p in db.Order
                          select p;


            return View(O_datas);
        }
        public ActionResult Activity()
        {
            MingSuEntities db = new MingSuEntities();
            var A_datas = from p in db.Activity
                          select p;


            return View(A_datas);
        }
        public ActionResult Discount()
        {
            MingSuEntities db = new MingSuEntities();
            var D_datas = from p in db.Discount
                          select p;


            return View(D_datas);
        }
        public ActionResult Member()
        {
            MingSuEntities db = new MingSuEntities();
            var M_datas = from p in db.Member
                          select p;


            return View(M_datas);
        }
    }
}