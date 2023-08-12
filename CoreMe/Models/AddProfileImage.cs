using Microsoft.AspNetCore.Http;

namespace CoreMe.Models
{
    public class AddProfileImage
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAbout { get; set; }
        public IFormFile CustomerImage { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
