using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppWells.Models
{
    public class AgeCalculatorModel
    {
        //declares getter and setters for each variable alone with requirments
        [Required(ErrorMessage ="Please enter your name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Please enter the year you were born.")]
        [Range(0, 2024, ErrorMessage ="Birth year most be between 0 and 2024.")]
        public int? BirthYear { get; set; }
        [Required(ErrorMessage ="Please enter the day you were born")]
        [Range (1,31, ErrorMessage ="Please enter a day between 1 and 31")]
        public int? BirthDay { get; set; }
        [Required(ErrorMessage ="Please enter the month you were born")]
        [Range (1,12, ErrorMessage ="Please enter a month between 1 and 12")]
        public int? BirthMonth { get; set; }

        //calculates age for the current year
        public int? AgeThisYear()
        {
            const int NUM_OF_DAYS_IN_YEAR = 365;
            //gets today's date
            DateTime todaysDate = DateTime.Today;
            //puts user input into a datetime object
            DateTime usersBirthday = new DateTime((int)BirthYear, (int)BirthMonth, (int)BirthDay);
            //calculates age
            TimeSpan usersAge = todaysDate - usersBirthday;
            //Calculates users age in years 
            int? ageOfUserInYears = usersAge.Days/NUM_OF_DAYS_IN_YEAR;
            return ageOfUserInYears;

        }
        

    }
}
