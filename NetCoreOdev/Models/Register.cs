using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreOdev.Models;
namespace NetCoreOdev.Models
{
    public static class Register
    {
        public static List<UserResponse>theaterCourse = new List<UserResponse>();
        public static List<UserResponse> drumCourse = new List<UserResponse>();
        public static List<UserResponse> guitarCourse = new List<UserResponse>();
        public static void Add(UserResponse userResponse)
        {
            if (userResponse.course.Id == 0)
            {
                theaterCourse.Add(userResponse);
            }
            else if(userResponse.course.Id == 1)
            {
                drumCourse.Add(userResponse);
             }
            else
            {
                guitarCourse.Add(userResponse);
            }
            
        }
    }
}
