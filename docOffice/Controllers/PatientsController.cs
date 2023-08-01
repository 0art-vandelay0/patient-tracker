using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DocOffice.Models;
using System.Collections.Generic;
using System.Linq;

namespace DocOffice.Controllers
{
    public class PatientsController : Controller
    {
        private readonly DocOfficeContext _db;

        public PatientsController(DocOfficeContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Patient> model = _db.Patients.ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            Patient thisPatient = _db.Patients.FirstOrDefault(patient => patient.PatientId == id);
            return View(thisPatient);
        }
    }
}
