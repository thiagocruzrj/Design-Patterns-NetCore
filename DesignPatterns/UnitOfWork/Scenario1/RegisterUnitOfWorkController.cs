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
    }
}