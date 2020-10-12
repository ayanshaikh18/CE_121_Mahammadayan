using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab9_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab9_.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository _customerRepository)
        {
            this._customerRepository = _customerRepository;
        }

        [AllowAnonymous]
        public IActionResult Home()
        {
            var model = _customerRepository.GetAllCustomer();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer()
                {
                    Name = model.Name,
                    Email = model.Email,
                    MobileNo = model.MobileNo
                };
                _customerRepository.Add(customer);
               
                return RedirectToAction("Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _customerRepository.GetCustomer(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Customer model)
        {
            Customer customer = _customerRepository.GetCustomer(model.Id);
            customer.Name = model.Name;
            customer.Email = model.Email;
            customer.MobileNo = model.MobileNo;
            _customerRepository.Update(customer);
            return RedirectToAction("Home");
        }
        public IActionResult Delete(int id)
        {
            _customerRepository.Delete(id);
            return RedirectToAction("Home");
        }
    }
}
