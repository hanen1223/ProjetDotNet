using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;

namespace AM.UI.WEB.Controllers
{
    public class FlightController : Controller
    {  
        IServiceFlight serviceFlight;//attribut
        IServiceplane serviceplane;
        public FlightController(IServiceFlight serviceflight, IServiceplane serviceplane)//ctrl+espace l IServiceFlight
        {
            this.serviceFlight = serviceflight;
            this.serviceplane = serviceplane;
        }
        // GET: FlightController
        public ActionResult Index(string Destination,string Departure)
        {
            var flight = serviceFlight.GetAll();
            if (Destination != null && Departure!=null)
            {
            //    return View(flight);
            //}
            //else
            //{
               // var flight = serviceFlight.GetAll().Where(f=>f.Destination.Contains(Destination));
                flight = flight.Where(f=>f.Destination.Contains(Destination)&& f.Departure.Contains(Departure));
            }
            else if (Destination!=null)
            {
                flight = flight.Where(f => f.Destination.Contains(Destination));
            }
            else if( Departure!= null)
            {
                flight = flight.Where(f => f.Departure.Contains(Departure));
            }
            return View(flight.ToList());
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            var flight = serviceFlight.GetById(id);
            return View(flight);
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {    
            ViewBag.planes = new SelectList(serviceplane.GetAll(),"PlaneId","Information");// selectlist = tselecti ml liste ay k3ba t7b 3leha
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection,IFormFile PiloteFile)
        {

            try
            { var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","img",PiloteFile.FileName); //var path = Path.Combine(Directory.GetCurrentDirectory())==>C:/AM.UI.WEB
              var stream = new FileStream(path,FileMode.Create);//objet pour manipuler le file
                PiloteFile.CopyTo(stream);//pour enregistrement
                collection.Pilote=PiloteFile.FileName;
            serviceFlight.Add(collection);
            serviceFlight.Commit();
            return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            var flight = serviceFlight.GetById(id);
            return View(flight);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight collection)
        {
            try
            {
                serviceFlight.Update(collection);
                serviceFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            var flight = serviceFlight.GetById(id);
            return View(flight);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Flight collection)
        {
            try
            {
                var flight = serviceFlight.GetById(id);
                serviceFlight.Delete(flight);
                serviceFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
