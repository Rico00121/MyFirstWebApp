using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.ViewModels;

namespace LanzhouBeefNoodles.controllers
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;
        public HomeController(INoodleRepository noodleRepository,IFeedbackRepository feedbackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }
    
        public IActionResult Index()
        {
            //var noodles=_noodleRepository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList()

            };
            return View(viewModel);
        }
     
        public String About()
        {
            return "hello from about";
        }
        public IActionResult Detail(int id)
        {
            var noodle=_noodleRepository.GetNoodleById(id);
            return View(noodle);
        }
    }
}
