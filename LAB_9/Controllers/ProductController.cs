using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab9_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab9_.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public ProductController(IProductRepository _ProductRepository)
        {
            this._ProductRepository = _ProductRepository;
        }

        [AllowAnonymous]
        public IActionResult Home()
        {
            var model = _ProductRepository.GetAllProducts();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                Product Product = new Product()
                {
                    Name = model.Name,
                    Details=model.Details,
                    Price=model.Price
                };
                _ProductRepository.Add(Product);

                return RedirectToAction("Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _ProductRepository.GetProduct(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Product model)
        {
            Product product= _ProductRepository.GetProduct(model.Id);
            product.Name = model.Name;
            product.Details = model.Details;
            product.Price = model.Price;
            _ProductRepository.Update(product);
            return RedirectToAction("Home");
        }
        public IActionResult Delete(int id)
        {
            _ProductRepository.Delete(id);
            return RedirectToAction("Home");
        }
    }
}
