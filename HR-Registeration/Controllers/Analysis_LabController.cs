using HR_Registeration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Registeration.Controllers
{
    public class Analysis_LabController : Controller
    {
        HRDatabaseContext dbContext = new HRDatabaseContext();
        public IActionResult Index(string SortField, String CurrentSortField, SortDirection SortDirection, string SearchByName)
        {
            List<AnalysisLab> Analysis_Lab = dbContext.Analysis_Lab.ToList();
            if (!string.IsNullOrEmpty(SearchByName))
                Analysis_Lab = Analysis_Lab.Where(a => a.Analysis_Lab_Name.ToLower().Contains(SearchByName.ToLower())).ToList();
            return View(this.SortAnalysis_Lab(Analysis_Lab, SortField, CurrentSortField, SortDirection));

        }
        public IActionResult Create()
        {
            ViewBag.Analysis_Lab = this.dbContext.Analysis_Lab.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(AnalysisLab model)
        {
            ModelState.Remove("Analysis_Lab_ID");
            if (ModelState.IsValid)
            {
                dbContext.Analysis_Lab.Add(model);
                dbContext.SaveChanges();
                return RedirectToActionPermanent("Index");
            }
            ViewBag.Analysis_Lab = this.dbContext.Analysis_Lab.ToList();
            return View();
        }

        public IActionResult Delete(int ID)
        {
            AnalysisLab data = this.dbContext.Analysis_Lab.Where(l => l.Analysis_Lab_ID == ID).FirstOrDefault();
            if (data != null)
            {
                dbContext.Analysis_Lab.Remove(data);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        private List<AnalysisLab> SortAnalysis_Lab(List<AnalysisLab> Analysis_lab, string sortField, string currentSortField, SortDirection sortDirection)
        {
            if (string.IsNullOrEmpty(sortField))
            {
                ViewBag.Sortfield = "Analysis_Lab_Name";
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

            var propertyInfo = typeof(AnalysisLab).GetProperty(ViewBag.SortField);
            if (ViewBag.SortDirection == SortDirection.Ascending)
                Analysis_lab = Analysis_lab.OrderBy(a => propertyInfo.GetValue(a, null)).ToList();
            else
                Analysis_lab = Analysis_lab.OrderByDescending(a => propertyInfo.GetValue(a, null)).ToList();
            return Analysis_lab;


        }
    }
}

