using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CooperativaXZ
{
    public class ProjectService
    {
        public async Task<Project[]> GetProjectAsync()
        {
            var baseAddress = "http://localhost:3001/project";
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = client.GetAsync(baseAddress).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var customerJsonString = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject<IList<Project>>(customerJsonString).ToArray();
                            
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

            }
            catch (System.Exception)
            {
                return null;
            }
        }

    }
}
