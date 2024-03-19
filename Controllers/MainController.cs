using Microsoft.AspNetCore.Mvc;
using CRUD_MVC_ASP.Data;
using CRUD_MVC_ASP.Models;

namespace CRUD_MVC_ASP.Controllers
{
    public class MainController : Controller
    {

        DataContact _dataContact = new DataContact();

        /// <summary>
        /// Show a list of contacts.
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            var List = _dataContact.GetListOfContacts();
            return View(List);
        }

        /// <summary>
        /// Return the Save view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Save()
        {
            return View();
        }

        /// <summary>
        /// receives an object and saves it to the database.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Save(ContactModel Contact)
        {
            var answer = _dataContact.CreateContact(Contact);

            if (answer)
            {
                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// Return the Edit view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit(int Id)
        {
            var Contact = _dataContact.GetContact(Id);
            return View(Contact);
        }

        /// <summary>
        /// receives an object and update it to the database.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(ContactModel Contact)
        {
            if (!ModelState.IsValid) return View();

            var answer = _dataContact.UpdateContact(Contact);

            if (answer)
            {
                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }
        
        /// <summary>
        /// Return the Edit view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete(int Id)
        {
            var Contact = _dataContact.GetContact(Id);
            return View(Contact);
        }

        /// <summary>
        /// receives an object and update it to the database.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(ContactModel Contact)
        {
            var answer = _dataContact.DeleteContact(Contact.Id);

            if (answer)
            {
                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }
    }
}
