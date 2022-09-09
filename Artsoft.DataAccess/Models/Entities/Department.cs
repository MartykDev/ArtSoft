﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artsoft.DataAccess.Models.Entities
{
    //TODO Must be record instead class. Current version of automapper don't support records
    [Table("Department")]
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Floor { get; init; }
    }
}