using HR_Registeration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Registeration.Controllers
{
    public enum SortDirection
    {
        Ascending,
        Descending
    }
    public class Rays_LabController : Controller
    {

        HRDatabaseContext dbContext = new HRDatabaseContext();


        public IActionResult Index(string SortField, String CurrentSortField, SortDirection SortDirection, string SearchByName)
        {
            List<RaysLab> Rays_Lab = dbContext.Rays_Lab.ToList();
            if (!string.IsNullOrEmpty(SearchByName))
                Rays_Lab = Rays_Lab.Where(l => l.Rays_Lab_Name.ToLower().Contains(SearchByName.ToLower())).ToList();
            return View(this.SortRays_Lab(Rays_Lab, SortField, CurrentSortField, SortDirection));

        }



        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(RaysLab model)
        {
            ModelState.Remove("Rays_Lab_ID");
            if (ModelState.IsValid)
            {
                
                dbContext.Rays_Lab.Add(model);
                dbContext.SaveChanges();
                return RedirectToActionPermanent("Index");
            }
            ViewBag.Rays_Lab = this.dbContext.Rays_Lab.ToList();
            return View();
        }

        public IActionResult Delete(int ID)
        {
            RaysLab data = this.dbContext.Rays_Lab.Where(l => l.Rays_Lab_ID == ID).FirstOrDefault();
            if (data != null)
            {
                dbContext.Rays_Lab.Remove(data);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        private List<RaysLab> SortRays_Lab(List<RaysLab> Rays_lab, string sortField, string currentSortField, SortDirection sortDirection)
        {
            if (string.IsNullOrEmpty(sortField))
            {
                ViewBag.Sortfield = "Rays_Lab_Name";
                ViewBag.SortDirection = SortDirection.Ascending;
            }
            else
            {
                if (currentSortField == sortField)
                    ViewBag.SortDirection = sortDirection == SortDirection.Ascending ? SortDirection.Descending : SortDirection.Ascending;
                else
                    ViewBag.SortDirection = SortDirection.Ascending;
                ViewBag.SortField = sortField;
            }

            var propertyInfo = typeof(RaysLab).GetProperty(ViewBag.SortField);
            if (ViewBag.SortDirection == SortDirection.Ascending)
                Rays_lab = Rays_lab.OrderBy(l => propertyInfo.GetValue(l, null)).ToList();
            else
                Rays_lab = Rays_lab.OrderByDescending(l => propertyInfo.GetValue(l, null)).ToList();
            return Rays_lab;


        }

    }
}







