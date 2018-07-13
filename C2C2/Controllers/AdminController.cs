using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C2C2.Abstract;
using C2C2.Entities;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using C2C2.Models;
using C2C2.Models.ManageViewModels;
using C2C2.Services;

namespace C2C2.Controllers
{
    public class AdminController : Controller
    {
       
        private IQuestionRepository repository;
        [Authorize]
        public ActionResult Index()
        { 
            return View(repository.Question);
        }

        public AdminController(IQuestionRepository repo)
        {
            repository = repo;
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Question question)
        {
            if (ModelState.IsValid)
            {
                repository.SaveQuestion(question);
                TempData["message"] = string.Format("{0} has been saved", question.QuestionText);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(question);
            }
        }

           /** public ViewResult Edit(int questionId)
            {
                Question question1 = repository.Question.FirstOrDefault(p => p.que == questionId);

                return View(question1);
            }**/

            [HttpPost]
        public ActionResult Edit(Question question)
        {
            if (ModelState.IsValid)
            {
                repository.SaveQuestion(question);
                TempData["message"] = string.Format("{0} has been saved", question.QuestionText);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(question);
            }
        }


        [HttpPost]
        public ActionResult Delete(int QuestionId)
        {
            Question deletedProduct = repository.DeleteQuestion(QuestionId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedProduct.QuestionText);
            }
            return RedirectToAction("Index");
        }
    }
    }
