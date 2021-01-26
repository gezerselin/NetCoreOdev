using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

 namespace NetCoreOdev.Models
{
    public  class UserResponse
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz ")]
        [MinLength(2,ErrorMessage ="En az iki harf girmeniz gerekmektedir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz ")]
        [MinLength(2, ErrorMessage = "En az iki harf girmeniz gerekmektedir")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Lütfen mail adresinizi girin")]
        [EmailAddress(ErrorMessage ="E-posta formatı doğru değil")]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
        public Course course { get; set; }

    }
}
