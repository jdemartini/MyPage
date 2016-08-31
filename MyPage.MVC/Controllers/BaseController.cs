using AutoMapper;
using MyPage.Data.Repositories;
using MyPage.Domain.Entities;
using MyPage.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyPage.MVC.Controllers
{
    public abstract class BaseController<ViewModel, DomainModel> : Controller
        where ViewModel : class, IViewModel
        where DomainModel : class, IEntity
    {
        private readonly RepositoryBase<DomainModel> repo;

        public BaseController(RepositoryBase<DomainModel> repo)
        {
            this.repo = repo;
        }

        //
        // GET: /Event/
        public ActionResult Index()
        {
            var viewModel = Mapper.Map<IEnumerable<DomainModel>, IEnumerable<ViewModel>>(repo.GetAll());
            return View(viewModel);
            
        }

        //
        // GET: /Event/Details/5

        public ActionResult Details(Guid id)
        {
            var v = Mapper.Map<DomainModel, ViewModel>(repo.GetById(id));
            return View(v);
        }

        //
        // GET: /Event/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Event/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViewModel viewModel)
        {

            
            if (ModelState.IsValid)
            {
                var entityModel = Mapper.Map<ViewModel, DomainModel>(viewModel);
                repo.Add(entityModel);
            }

            return RedirectToAction("Index");
           
        }

        //
        // GET: /Event/Edit/5

        public ActionResult Edit(Guid id)
        {
            var domainModel = repo.GetById(id);
            var viewModel = Mapper.Map<DomainModel, ViewModel>(domainModel);

            return View(viewModel);
        }

        //
        // POST: /Event/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                var domainModel = Mapper.Map<ViewModel, DomainModel>(viewModel);
                repo.Update(domainModel);
                return RedirectToAction("Index");
            }
             
            return View(viewModel);
            
        }

        //
        // GET: /Event/Delete/5
        public ActionResult Delete(Guid id)
        {
            var domainModel = repo.GetById(id);
            var viewModel = Mapper.Map<DomainModel, ViewModel>(domainModel);
            
            return View(viewModel);
        }

        //
        // POST: /Event/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            
            var domainModel = repo.GetById(id);
            repo.Remove(domainModel);

            return RedirectToAction("Index");
            
        }
    }
}
