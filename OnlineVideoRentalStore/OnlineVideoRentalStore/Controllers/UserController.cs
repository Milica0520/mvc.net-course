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
                return RedirectToAction("ShowAllMovies");
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
            return RedirectToAction("ShowAllMovies", "Movie");
        }

        [HttpGet("login")]

        public IActionResult LogInUser()
        {
            return View("LoginUser");
        }


            [HttpPost("login")]
        public IActionResult LogInUser(string userInputName ,string userInputEmail)
        {
            var findUser = InMemoryDb.Users.FirstOrDefault(u => u.UserName == userInputName &&
            u.Email == userInputEmail
            );

            if (findUser != null)
            {
                return RedirectToAction("ShowAllMovies", "Movie");
            }
            else
            {
                return RedirectToAction("CreateUser");
            }
        }



    }
}
