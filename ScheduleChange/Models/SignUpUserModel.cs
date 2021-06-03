using System.ComponentModel.DataAnnotations;

namespace ScheduleChange.Models
{
    public class SignUpUserModel
    {
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Bắt buộc phải điền tên của bạn")]
        public string FirstName { get; set; }
        [Display(Name = "Họ")]
        public string LastName { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bắt buộc phải nhập địa chỉ email")]
        [Display(Name = "Địa chỉ email")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hãy nhập mật khẩu mạnh hơn")]
        [Compare("ConfirmPassword", ErrorMessage = "Mật khẩu nhập không chính xác")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Hãy nhập lại mật khẩu xác nhận")]
        [Display(Name = "Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
