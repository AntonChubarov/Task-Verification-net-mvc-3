using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;
using Entity.Repository.Interface;

namespace PhoneSaleSite.Controllers
{
    public class PhonePriceController : Controller
    {
        private IPhoneRepository _phoneRepo;
        private IOrderRepository _orderRepo;

        public PhonePriceController(IPhoneRepository phoneRepo, IOrderRepository orderRepo)
        {
            _phoneRepo = phoneRepo;
            _orderRepo = orderRepo;
        }

        // GET: Phone
        public IActionResult Phone()
        {
            var phones = _phoneRepo.GetPhoneListAsync();
            return View(phones.Result);
        }

        // POST: Buy
        [HttpPost]
        public IActionResult Buy(Phone phone)
        {
            var order = new Order();
            order.PhoneId = phone.Id;
            _orderRepo.AddOrderAsync(order);
            return View(null);
        }
    }
}
