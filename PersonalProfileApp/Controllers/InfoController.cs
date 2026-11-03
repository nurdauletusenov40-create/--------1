using Microsoft.AspNetCore.Mvc;
using PersonalProfileApp.Models;

namespace PersonalProfileApp.Controllers;

public class InfoController : Controller
{
    public IActionResult Index()
    {
        return View(CreateStudentProfile());
    }

    public IActionResult About()
    {
        return View(CreateStudentProfile());
    }

    public IActionResult Portfolio()
    {
        return View(CreateStudentProfile());
    }

    private static StudentProfile CreateStudentProfile()
    {
        return new StudentProfile
        {
            FullName = "Үсенов Нұрдаулет",
            University = "Абай атындағы Қазақ ұлттық педагогикалық университеті",
            Group = "ИСК-242",
            Course = "3-курс",
            City = "Шымкент",
            Major = "Ақпараттық жүйелер",
            Interests =
            [
                "Бағдарламалау",
                "Веб-әзірлеу",
                "Киберқауіпсіздік",
                "IT технологиялары"
            ],
            Skills =
            [
                "C#",
                "Python",
                "C++",
                "HTML",
                "CSS",
                "JavaScript",
                "SQL",
                "ASP.NET Core MVC (үйрену үстінде)"
            ],
            Projects =
            [
                new PortfolioProject
                {
                    Name = "Linkora",
                    Description = "Студенттерге тәлімгер таңдауға арналған веб-жүйе.",
                    Technologies = ["Веб-технологиялар"]
                },
                new PortfolioProject
                {
                    Name = "PersonalProfileApp",
                    Description = "ASP.NET Core MVC көмегімен жасалған жеке визитка сайты.",
                    Technologies = ["C#", "ASP.NET Core MVC", "Razor", "HTML", "CSS", "Bootstrap 5"]
                },
                new PortfolioProject
                {
                    Name = "Python және C++ тапсырмалары",
                    Description = "Университеттегі практикалық бағдарламалау тапсырмалары.",
                    Technologies = ["Python", "C++"]
                }
            ]
        };
    }
}
