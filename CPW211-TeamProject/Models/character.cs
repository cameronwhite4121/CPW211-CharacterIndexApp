using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject.Models
{
    /// <summary> 
    /// This class represents a character, be it a villain, hero or side character. 
    /// </summary> 
    [Index(nameof(Name), IsUnique = true)] // Tell EF Core to create an index for the Name column
    public partial class Character
    {
        public Character()
        {
            SuperPower = new List<string>();
        }
        public Character(string name, int age, List<string> powers, 
                         string rival, DateTime debutDate, 
                         string comicDebut) 
        {
            this.Name = name;
            this.Age = age;
            this.SuperPower = powers;
            this.Rival = rival;
            this.DebutDate = debutDate;
            this.ComicBookDebut = comicDebut;
        }

        /// <summary> 
        /// Character's ID as they are stored in the database. 
        /// </summary> 
        [Key] // Tell EF Core that this is the primary key 
        public int Id { get; private set; }

        /// <summary> 
        /// Character's name. 
        /// </summary> 
        [StringLength(30, ErrorMessage = "Character name is too long")]
        public string Name { get; set; }

        /// <summary> 
        /// Character's age, the int max value is 2,147,483,647. 
        /// </summary> 
        [Range(0, int.MaxValue, ErrorMessage = "Age must be greater than 0")]
        public int Age { get; set; }

        /// <summary> 
        /// Character's Superpower, it can be left empty 
        /// in case they do not have one. Handles multiple powers in 
        /// one string
        /// </summary> 
        //[StringLength(100, ErrorMessage = "Power/powers are too long")]
        [NotMapped] // Tell EF Core to ignore this property
        public List<string> SuperPower { get; set; }

        /// <summary>
        /// This property is used to store the SuperPower list as a string
        /// and convert it back to a list when needed
        /// </summary>
        public string SuperPowerString
        {
            get
            {
                return string.Join(", ", SuperPower);
            }
            set
            {
                SuperPower = value.Split(", ").ToList() ?? new List<string>();
            }
        }

        /// <summary> 
        /// Character's Rival, it can be left empty, 
        /// or they can add multiples 
        /// </summary> 
        [StringLength(40, ErrorMessage = "Rival's name is too long")]
        public string? Rival { get; set; }

        /// <summary> 
        /// Character's debut date, using DateTime 
        /// </summary> 
        [DataType(DataType.Date, ErrorMessage = "Debut date must be a valid date")]
        public DateTime DebutDate { get; set; }
        
        /// <summary> 
        /// Character's comic book issue debut 
        /// for example, Spiderman: "Amazing Fantasy #15" 
        /// </summary> 
        [StringLength(100, ErrorMessage = "Debut issue is too long")]
        public string ComicBookDebut { get; set; }
    }
}