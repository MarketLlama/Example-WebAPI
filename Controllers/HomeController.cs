using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webdb.Controllers;
using webdb.Models;
public class HomeController : Controller
{
    private readonly IVehicleRepository _vehicleRepository;

    public HomeController (IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }
    public IActionResult Index()
    {
        var model = _vehicleRepository.GetAllVehicle();
        return View(model);
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Error()
    {
        return View();
    }
}