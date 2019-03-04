using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using AzadiSoft.UserManager.Resources;

namespace AzadiSoft.UserManager.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int User_ID { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "PleaseEnterMessage")]
        [StringLength(80)]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "PleaseEnterMessage")]
        [StringLength(80)]
        public string LastName { get; set; }

        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "PleaseEnterMessage")]
        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [Display(Name = "جنسیت")]
        [Required(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "PleaseSelectMessage")]
        public int? Gender { get; set; }

        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "PleaseEnterMessage")]
        [StringLength(128)]
        [EmailAddress(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName="InvalidEmail")]
        public string Email { get; set; }

        [Display(Name = "کد ملی")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string NationalCode { get; set; }

        [Display(Name = "شماره موبایل")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string MobileNumber { get; set; }

        [Display(Name = "تلفن منزل")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string HomePhoneNumber { get; set; }

        [Display(Name = "تلفن محل کار")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string WorkPhoneNumber { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime? DateLastUpdated { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "توضیحات")]
        [StringLength(512, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string Notes { get; set; }

        [Display(Name = "میزان تحصیلات")]
        public int? EducationLevel_ID { get; set; }

        public IList<SelectListItem> EducationLevelListItems { get; set; }

        [Display(Name = "آدرس")]
        [StringLength(512, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string Address { get; set; }

        [Display(Name = "کشور")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string Country { get; set; }

        [Display(Name = "شهر")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string City { get; set; }

        [Display(Name = "ناحیه")]
        [StringLength(50, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        public string Region { get; set; }

        [Display(Name = "نوع کاربر")]
        public int? Role_ID { get; set; }

        public IList<SelectListItem> RoleListItems { get; set; }

        [Display(Name = "شناسه کاربری")]
        [StringLength(128, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage")]
        [Required(ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "PleaseEnterMessage")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [StringLength(128, ErrorMessageResourceType = typeof(MessageText), ErrorMessageResourceName = "StringLengthMessage", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "جنسیت")]
        public string Gender_Title => Gender.HasValue ? (Gender == (int) EGender.Male ? MessageText.Male : MessageText.Female) : MessageText.NotSpecified;

        [Display(Name = "میزان تحصیلات")]
        public string EducationLevel_Title { get; set; }

        [Display(Name = "نوع کاربر")]
        public string Role_TitleFa { get; set; }

        public IList<SelectListItem> Gender_ListItems { get; set; }


        public UserViewModel()
        {
            EducationLevelListItems = new List<SelectListItem>();

            RoleListItems = new List<SelectListItem>();

            Gender_ListItems = new List<SelectListItem>();
        }

    }
}