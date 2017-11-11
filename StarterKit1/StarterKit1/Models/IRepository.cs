﻿using System.Collections.Generic;

namespace StarterKit1.Models
{
	public interface IRepository
	{
		IEnumerable<City> Cities { get; }

		void AddCity(City newCity);
	}
}