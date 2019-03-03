﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace AzadiSoft.UserManager.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int User_ID { get; set; }

        [Required]
        [StringLength(80)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(80)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public bool? Gender { get; set; }

        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(50)]
        public string NationalCode { get; set; }

        [StringLength(50)]
        public string MobileNumber { get; set; }

        [StringLength(50)]
        public string HomePhoneNumber { get; set; }

        [StringLength(50)]
        public string WorkPhoneNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateLastUpdated { get; set; }

        [StringLength(512)]
        public string Notes { get; set; }

        public int? EducationLevel_ID { get; set; }

        public IList<SelectListItem> EducationLevelListItems { get; set; }

        [StringLength(512)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        public int? Role_ID { get; set; }

        public IList<SelectListItem> RoleListItems { get; set; }

        public UserViewModel()
        {
            EducationLevelListItems = new List<SelectListItem>();

            RoleListItems = new List<SelectListItem>();
        }

    }
}