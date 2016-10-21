using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using PortalOgloszeniowy.Resources;

namespace PortalOgloszeniowy.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
        [StringLength(100, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordMinLenght", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "PasswordNew")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "ConfirmPasswordNew")]
        [Compare("NewPassword", ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "PasswordCompareFailed")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "PasswordCurrent")]
        public string OldPassword { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
        [StringLength(100, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordMinLenght", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "PasswordNew")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
           ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "ConfirmPasswordNew")]
        [Compare("NewPassword", ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "PasswordCompareFailed")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
             ErrorMessageResourceName = "FieldRequired")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}