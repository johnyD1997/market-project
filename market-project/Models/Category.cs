﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks
namespace market_project.Models
{
	public class Category
	{
		[Key] // atribute that used for identificate next field as Key
		public int Id { get; set; }

		public string Name { get; set; }

		public int DisplayOrder { get; set; }

	}
}

