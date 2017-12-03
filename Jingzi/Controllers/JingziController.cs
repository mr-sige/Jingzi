using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Jingzi.Models;
using Newtonsoft.Json;

namespace Jingzi.Controllers
{
    public class JingziController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> Post(RequestDataModel requestDataModel)
        {

            if (!Enum.IsDefined(typeof(HttpStatusCode), requestDataModel.ResponseStatusCode))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            HttpResponseMessage response = Request.CreateResponse((HttpStatusCode)requestDataModel.ResponseStatusCode);

            if (requestDataModel.ResponseBody != null)
            {
                response.Content = new StringContent(JsonConvert.SerializeObject(requestDataModel.ResponseBody),
                    Encoding.UTF8);
            }

            if (requestDataModel.ResponseLatency > 0)
            {
                await Task.Run(
                    async () =>
                    {
                        await Task.Delay(TimeSpan.FromMilliseconds(requestDataModel.ResponseLatency));

                    });
            }

            return response;
        }
    }
}