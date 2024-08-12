﻿using System;
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
                         string? rival, DateTime debutDate, 
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
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        /// <summary> 
        /// Character's age, the int max value is 2,147,483,647. 
        /// </summary> 
        [Required(ErrorMessage = "Age is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Age must be greater than 0")]
        public int Age { get; set; }

        /// <summary> 
        /// Character's Superpower, it can be left empty 
        /// in case they do not have one. Handles multiple powers in 
        /// one string
        /// </summary> 
        [StringLength(100, ErrorMessage = "Power/powers are too long")]
        public string? SuperPower { get; set; }

        /// <summary> 
        /// Character's Rival, it can be left empty, 
        /// or they can add multiples 
        /// </summary> 
        [StringLength(40, ErrorMessage = "Rival's name is too long")]
        public string? Rival { get; set; }

        /// <summary> 
        /// Character's debut date, using DateTime 
        /// </summary> 
        [Required(ErrorMessage = "DebutDate is required")]
        [DataType(DataType.Date, ErrorMessage = "Debut date must be a valid date")]
        public DateTime DebutDate { get; set; }
        
        /// <summary> 
        /// Character's comic book issue debut 
        /// for example, Spiderman: "Amazing Fantasy #15" 
        /// </summary> 
        [Required(ErrorMessage = "Debut issue is required")]
        [StringLength(100, ErrorMessage = "Debut issue is too long")]
        public required string ComicBookDebut { get; set; }
    }
}