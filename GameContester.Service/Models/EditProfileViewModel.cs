﻿
namespace GameContester.Service.Models
{
    public class EditProfileViewModel
    {
        public string Id { get; set; }
        public string Picture { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string About { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirmation { get; set; }
    }
}