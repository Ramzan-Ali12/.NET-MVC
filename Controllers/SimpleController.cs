using Microsoft.AspNetCore.Mvc;
using CRUD.Data;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
namespace CRUD.Controllers
{
    public class SimpleController : Controller
    {
        private readonly ApplicationDbContext _db;
        //Constructor of SimpleController
        public SimpleController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Index Function
        public async Task<IActionResult> Index()
        {
            var books = await _db.Employee.ToListAsync();

            return View(books);
        }
        [HttpGet]
        //Create Function to get Records
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Create function to post Records
        public async Task<IActionResult> Create(Simple book)
        {
            if (ModelState.IsValid)
            {
                    _db.Add(book);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
            }            
            return View(book);
        }
        [HttpGet]
        //Edit Function to edit Records
        public async Task<ActionResult> Edit(long? id)
        {
        if (id == null || _db.Employee == null)
            {
                return NotFound();
            }

            var category = await _db.Employee.FindAsync(id);
            if (category == null)
            {
                return NotFound();
}            return View(category);
        }
        //Edit Function to Post Record
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id,[Bind("Id,Name,Age,Gender")] Simple book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(book);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        private bool CategoryExists(object id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        //Delete function to delete Records
        public async Task<IActionResult> Delete(int id)
        {
            var exist = await _db.Employee.Where(x => x.Id == id).FirstOrDefaultAsync();
            return View();
        }
        //Delete post function fo delete the records
        [HttpPost]
        public async Task<IActionResult> Delete(Int64 id ,Simple book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var exist = await _db.Employee.FindAsync(id);
                    if (exist != null)
                    {
                        _db.Remove(exist);
                        await _db.SaveChangesAsync();
                    }
                    return RedirectToAction("Index");

                    
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View(book);
        }
    }

}