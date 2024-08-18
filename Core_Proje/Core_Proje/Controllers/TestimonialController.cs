using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        TestimonialsManager testimonialsManager = new TestimonialsManager(new EfTestimonialsDal());
        public IActionResult Index()
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }

        [HttpGet]   
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonials p)
        {
            testimonialsManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonials(int id)
        {
            var values = testimonialsManager.TGetByID(id);
            testimonialsManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonials(int id)
        {
            var values = testimonialsManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonials(Testimonials testimonials)
        {
            testimonialsManager.TUpdate(testimonials);
            return RedirectToAction("Index");
        }

    }
}
