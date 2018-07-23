using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using SPA2.Model;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SPA2.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "http://localhost:53268/";
        public async Task<ActionResult> Index()
        {
            List<AspNetUsers> UserInfo = new List<AspNetUsers>();
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/AspNetUsers/");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    UserInfo = JsonConvert.DeserializeObject<List<AspNetUsers>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(UserInfo);
            }
            
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
