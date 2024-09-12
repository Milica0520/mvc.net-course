using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineVideoRentalStore.DataBase;
using OnlineVideoRentalStore.Models.Enteties;
using OnlineVideoRentalStore.Models.ViewModels;

namespace OnlineVideoRentalStore.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {

        [HttpGet("create")]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }

        [HttpPost("create")]
        public IActionResult CreateUser(CreateUserVM userVM)
        {
            var findUser = InMemoryDb.Users.FirstOrDefault(x => x.UserName == userVM.UserName);

            if (findUser != null)
            {
                TempData["UserMessage"] = $"User with {userVM.UserName} already exist! Try another user name.";
                return RedirectToAction("Index","Home");
            }
            else
            {
                var entity = new User()
                {
                Id = InMemoryDb.Users.Count + 1,
                UserName = userVM.UserName,
                Email = userVM.Email,
                Age = userVM.Age,
                CardNumber = userVM.CardNumber,
                CreatedOn = userVM.CreatedOn,
                IsSubscriptionExpired = userVM.IsSubscriptionExpired,
                SubscriptionType = userVM.SubscriptionType,
                };
                InMemoryDb.Users.Add(entity);
             
            }
            TempData["WellcomeMessage"] = $"Wellcome to movie app, {userVM.UserName} ";
            return RedirectToAction("ShowAllMovies", "Movie");
        }

        [HttpGet("login")]
        public IActionResult LogInUser()
        {
            return View("LoginUser");
        }

        [HttpPost("login")]
        public IActionResult LogInUser(string UserName ,string Email)
        {
            var findUser = InMemoryDb.Users.FirstOrDefault(u => u.UserName.ToLower().Trim() == UserName.ToLower().Trim() &&
            u.Email.ToLower().Trim() == Email.ToLower().Trim());

            if (findUser != null)
            {
                
                HttpContext.Session.SetString("UserId", $"{findUser.Id}");
                TempData["WellcomeMessage"] = $"Wellcome to movie app, {UserName} ";
                return RedirectToAction("ShowAllMovies", "Movie");
            }
            else
            {
                TempData["Message"] = $"Try to log in again or sign up!";
                return RedirectToAction("CreateUser");
            }
        }
    }
}
