using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DocOffice.Models;
using System.Collections.Generic;
using System.Linq;

namespace DocOffice.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly DocOfficeContext _db;

        public DoctorsController(DocOfficeContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Doctor> model = _db.Doctors.ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            Doctor thisDoctor = _db.Doctors.FirstOrDefault(doctor => doctor.DoctorId == id);
            return View(thisDoctor);
        }
    }
}
