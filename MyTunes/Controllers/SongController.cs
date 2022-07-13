using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTunes.Models;

namespace MyTunes.Controllers
{
    public class SongController : Controller
    {
        private MyTunesContext _db { get; set; }
        public SongController(MyTunesContext context)
        {
            _db = context;
        }



        // GET: Song
        public ActionResult Index()
        {
            return View(_db.Songs.ToList());
        }

        // GET: Song/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                Song song = _db.Songs.First(a => a.Id == id );
                return View(song);
            }catch(Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
            
        }

        // GET: Song/Create
        public ActionResult Create()
        {           
            return View();
        }

        // POST: Song/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Song/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Song/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Song/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Song/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
