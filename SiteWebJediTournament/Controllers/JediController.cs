﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteWebJediTournament.ServiceReference1;
using SiteWebJediTournament.Models;

namespace SiteWebJediTournament.Controllers
{
    public class JediController : Controller
    {
        //
        // GET: /Jedi/
        public ActionResult Index()
        {
            ServiceJediClient service = new ServiceJediClient();
            List<JediModels> list = new List<JediModels>();

            foreach (JediWCF jedi in service.getAllJedi())
            {
                list.Add(new JediModels(jedi));
            }

            return View(list);
        }

        //
        // GET: /Jedi/Details/5
        public ActionResult Details(int id)
        {
            ServiceJediClient service = new ServiceJediClient();
            JediWCF jedi = service.getAllJedi().ToList().Find(x => x.Id == id);
            if (jedi == null)
            {
                return HttpNotFound();
            }
            return View(new JediModels(jedi));
        }

        //
        // GET: /Jedi/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Jedi/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ServiceJediClient service = new ServiceJediClient();
                JediWCF jedi = new JediWCF();
                jedi.Nom = collection["Nom"];
                jedi.IsSith = collection["EstUnSith"].StartsWith("true");

                // service.addJedi(jedi);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Jedi/Edit/5
        public ActionResult Edit(int id)
        {
            ServiceJediClient service = new ServiceJediClient();
            JediWCF jedi = service.getAllJedi().ToList().Find(x => x.Id == id);
            if (jedi == null)
            {
                return HttpNotFound();
            }
            return View(new JediModels(jedi));
        }

        //
        // POST: /Jedi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Jedi/Delete/5
        public ActionResult Delete(int id)
        {
            ServiceJediClient service = new ServiceJediClient();
            JediWCF jedi = service.getAllJedi().ToList().Find(x => x.Id == id);
            if (jedi == null)
            {
                return HttpNotFound();
            }
            return View(new JediModels(jedi));
        }

        //
        // POST: /Jedi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ServiceJediClient service = new ServiceJediClient();
                JediWCF jedi = service.getAllJedi().ToList().Find(x => x.Id == id);
                if (jedi == null)
                {
                    return HttpNotFound();
                }
                service.deleteJedi(jedi);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
