using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject.Models
{
    /// <summary> 
    /// This class represents a character, be it a villain, hero or side character. 
    /// </summary> 
    public partial class Character
    {
        public Character(string name, int age, string? power, 
                         string? rival, DateOnly debutDate, 
                         string comicDebut) 
        {
            this.Name = name;
            this.Age = age;
            this.SuperPower = power;
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
        [Required]
        public required string Name { get; set; }

        /// <summary> 
        /// Character's age, the int max value is 2,147,483,647. 
        /// </summary> 
        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        /// <summary> 
        /// Character's Superpower, it can be left empty 
        /// in case they do not have one. 
        /// </summary> 
        public string? SuperPower { get; set; }

        /// <summary> 
        /// Character's Rival, it can be left empty, 
        /// or they can add multiples 
        /// </summary> 
        [StringLength(1000)]
        public string? Rival { get; set; }

        /// <summary> 
        /// Character's debut date, using DateTime 
        /// </summary> 
        [Required]
        public DateOnly DebutDate { get; set; }
        
        /// <summary> 
        /// Character's comic book issue debut 
        /// for example, Spiderman: "Amazing Fantasy #15" 
        /// </summary> 
        [Required]
        [StringLength(100)]
        public required string ComicBookDebut { get; set; }
    }
}