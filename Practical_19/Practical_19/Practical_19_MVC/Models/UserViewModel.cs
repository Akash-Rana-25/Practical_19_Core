﻿namespace Practical_19_MVC.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
        public IEnumerable<string>? Claims { get; set; }
    }
}
