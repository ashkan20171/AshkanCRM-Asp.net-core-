using Microsoft.AspNetCore.Mvc;

namespace AshkanCrm.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Add User

        #region Create Customer
        public async Task<IActionResult> CreateCustomer()
        {
            return View();
        }

        #endregion

        #region CreateMarketer

        public  async Task<IActionResult> CreateMarketer()
        {
            return View();
        }

        #endregion

        #endregion
    }
}
