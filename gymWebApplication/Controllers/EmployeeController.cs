using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace gymWebApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        static HttpClient client = new HttpClient();
        public async Task Get()
        {
            client.BaseAddress = new Uri("http://dummy.restapiexample.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = await client.GetAsync("api/v1/employees");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string Get(int id)
        {
            return "value";
        }
    }
}
