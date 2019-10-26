using System.Net.Http;
using System.Threading.Tasks;

namespace CooperativaXZ
{
    public class ProjectService
    {
        private HttpClient httpClient;
        public async Task<Project[]> GetProjectAsync()
        {
            var response = await httpClient.GetAsync("http://localhost:3001/project");

            if (response.IsSuccessStatusCode)
            {
                var r = response;
            }

            Project[] projects = new Project()[];
            return projects;
        }
    }
}
