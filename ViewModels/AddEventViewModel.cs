using System;
using System.ComponentModel.DataAnnotations;

namespace HelloASPDotNET.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a date for your event.")] 
        public string TimeOfEvent { get; set; }

        [EmailAddress]
        //[Required]  //default message =The ContactEmail field is required.
        public string ContactEmail { get; set; }

    }
}
