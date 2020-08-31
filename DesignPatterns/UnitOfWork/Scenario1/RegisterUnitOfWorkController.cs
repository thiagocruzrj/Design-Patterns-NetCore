using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.UnitOfWork.Scenario1
{
    public class RegisterUnitOfWorkController : Controller
    {
        private readonly IRegisterUnitOfWork _unitOfWork;

        public RegisterUnitOfWorkController(IRegisterUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Together()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            var payment = new Payment()
            {
                Id = 1,
                Name = "payment 1",
                ProductId = product.Id
            };

            _unitOfWork.Insert(product, payment);

            return Content("Unit of Work Pattern");
        }
    }
}