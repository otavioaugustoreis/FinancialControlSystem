﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entity
{
    public class EntityPattern
    {
        [Key]
        [Column("pk_id")]
        public int Id { get; set; }

        [Required]
        [Column("dh_inclusao")]
        public DateTime DateOfInclusion { get; set; }

        public EntityPattern() { }

        protected EntityPattern(int id, DateTime dateOfInclusion) 
        {
            Id = id;
            DateOfInclusion = dateOfInclusion;
        }
    }
}
