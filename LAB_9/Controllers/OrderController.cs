using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab9_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab9_.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [AllowAnonymous]
        public IActionResult Home()
        {
            IEnumerable<Order> model = _orderRepository.GetAllOrders();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order model)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order()
                {
                    CustomerId = model.CustomerId,
                    ProductId=model.ProductId,
                    Amount=model.Amount,
                    OrderDate=model.OrderDate
                };
                _orderRepository.Add(order);
                return RedirectToAction("Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _orderRepository.GetOrder(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Order model)
        {
            Order order = _orderRepository.GetOrder(model.Id);
            order.Amount = model.Amount;
            order.CustomerId = model.CustomerId;
            order.ProductId = model.ProductId;
            order.OrderDate = model.OrderDate;
            _orderRepository.Update(order);
            return RedirectToAction("Home");
        }

        public IActionResult Delete(int id)
        {
            _orderRepository.Delete(id);
            return RedirectToAction("Home");
        }
    }
}
