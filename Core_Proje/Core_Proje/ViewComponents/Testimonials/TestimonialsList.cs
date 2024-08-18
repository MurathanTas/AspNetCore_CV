using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonials
{
    public class TestimonialsList : ViewComponent
    {
        TestimonialsManager testimonialsManager = new TestimonialsManager(new EfTestimonialsDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialsManager.TGetList();

            return View(values);
        }
    }
}
