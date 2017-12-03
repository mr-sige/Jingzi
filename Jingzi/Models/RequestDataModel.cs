using System.ComponentModel.DataAnnotations;

namespace Jingzi.Models
{
    public class RequestDataModel
    {
        public object ResponseBody { get; set; }

        [Required]
        public int ResponseStatusCode { get; set; }

        public int ResponseLatency { get; set; }

        public bool IsSuccessStatusCode => ResponseStatusCode >= 200 && ResponseStatusCode <= 299;
    }

}