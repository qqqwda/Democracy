﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class Voting
    {
        [Key]
        public int VotingId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Voting description")]
        [StringLength(30, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "State")]
        public int StateId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Date time start")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeStart { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Date time end")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeEnd { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Is for all users?")]
        public bool IsForAllUsers { get; set; }

        [Display(Name = "Is enabled blank vite?")]
        public bool IsEnabledBlankVote { get; set; }
        
        [Display(Name = "Quantity votes")]
        public int QuantityVotes { get; set; }

        [Display(Name = "Quantity blank votes")]
        public int QuantityBlankVotes { get; set; }

        [Display(Name = "Winner")]
        public string CandidateWin { get; set; }

        public virtual State State{ get; set; }
    }
}