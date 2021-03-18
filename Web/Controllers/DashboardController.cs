using System.Reflection.Metadata;
using System.Reflection.Emit;
using System.Reflection;
using System;
using System.Linq;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using ViewModels;

namespace Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolio;
        private readonly IWebHostEnvironment _hosting;

        public DashboardController(IUnitOfWork<Owner> owner, 
                                   IUnitOfWork<PortfolioItem> portfolio,
                                   IWebHostEnvironment hosting)
        {
            _owner = owner;
            _portfolio = portfolio;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
             {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            return View(homeViewModel.PortfolioItems);
        }

         // GET: Dashboard/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolioItem = _portfolio.Entity.GetById(id);
            if (portfolioItem == null)
            {
                return NotFound();
            }

            return View(portfolioItem);
        }

        // GET: Dashboard/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create(PortfolioViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = "inter.jpg";
                if (model.File != null)
                {
                    string extFile = Path.GetExtension(model.File.FileName);
                    if(extFile != ".jpg" && extFile != ".png")
                    {
                        ModelState.AddModelError("","Invalid File Format");
                        return View(model);
                    }
                    uniqueFileName = CreateFilePhotoPortfolio(model);
                   
                }

                PortfolioItem portfolioItem = new PortfolioItem
                {
                    ProjectName = model.ProjectName,
                    Description = model.Description,
                    ImageUrl = uniqueFileName
                };

                _portfolio.Entity.Insert(portfolioItem);
                _portfolio.Save();
                return RedirectToAction(nameof(Index));
            }

            return  View(model);
        }

        // GET: Dashboard/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolioItem = _portfolio.Entity.GetById(id);
            if (portfolioItem == null)
            {
                return NotFound();
            }

            PortfolioViewModel portfolioViewModel = new PortfolioViewModel
            {
                Id = portfolioItem.Id,
                Description = portfolioItem.Description,
                ImageUrl = portfolioItem.ImageUrl,
                ProjectName = portfolioItem.ProjectName
            };

            return View(portfolioViewModel);
        }

        // POST: Dashboard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public IActionResult Edit(Guid id, PortfolioViewModel model)
        {
            if (ModelState.IsValid)
            {  
                PortfolioItem portf = _portfolio.Entity.GetById(id);
                portf.ProjectName = model.ProjectName;
                portf.Description = model.Description;
                     
                string uniqueFileName= null;
                if (model.File != null)
                {
                    string extFile = Path.GetExtension(model.File.FileName);
                    if (extFile != ".jpg" && extFile != ".png")
                    {
                        ModelState.AddModelError("", "Invalid File Format");
                        return View(model);
                    }
                    uniqueFileName = CreateFilePhotoPortfolio(model);
                    //wwwroot/assets/img/portfolio/nom.png
                    if (portf.ImageUrl != null)
                    {
                        string oldPhotoPortfolio = Path.Combine(_hosting.WebRootPath, @"assets\img\portfolio", portf.ImageUrl);
                        System.IO.File.Delete(oldPhotoPortfolio);
                    }

                    portf.ImageUrl = uniqueFileName;

                    _portfolio.Entity.Update(portf);
                    _portfolio.Save();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        private string CreateFilePhotoPortfolio(PortfolioViewModel model)
        {
            string uniqueFileName;
            //uploads = wwwroot/assets/img/portfolio
            string uploads = Path.Combine(_hosting.WebRootPath, @"assets\img\portfolio");
            //model.File.FileName= nom de l'image
            uniqueFileName = Guid.NewGuid() + "_" + model.File.FileName;//FileName retourne le nom de l'image selectionnée

            //fullPath=uploads+model.File.FileName
            string fullPath = Path.Combine(uploads, uniqueFileName);
            //Création de l'image 
            
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                model.File.CopyTo(fileStream);
            }

            return uniqueFileName;
        }

        // GET: Dashboard/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolioItem = _portfolio.Entity.GetById(id);
            if (portfolioItem == null)
            {
                return NotFound();
            }

            return View(portfolioItem);
        }

        // POST: Dashboard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _portfolio.Entity.Delete(id);
            _portfolio.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PortfolioItemExists(Guid id)
        {
            return _portfolio.Entity.GetAll().Any(e => e.Id == id);
        }
    }
}