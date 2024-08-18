using BusinessLayer.Concrete;
using Core_Proje.Areas.Writer.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string receiverEmail = "admin@gmail.com";
            // var values = writerMessageManager.GetListReceiverMessage(receiverEmail).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            using (var context = new Context())
            {
                var result = from message in context.WriterMessages
                             join user in context.Users on message.Sender equals user.Email
                             where message.Receiver == receiverEmail
                             select new WriterMessageImageUrl
                             {
                                 WriterMessageID = message.WriterMessageID,
                                 SenderName = message.SenderName,
                                 Message = message.MessageContent,
                                 Date = message.Date,
                                 SenderImageUrl = user.ImageUrl
                             };
                var values = result.OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
                return View(values);
            }
           
           
        }
    }
}

