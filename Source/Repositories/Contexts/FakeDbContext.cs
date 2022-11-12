using Source.Models;
using System.Collections.Generic;

namespace Source.Repositories.Contexts;

public class FakeDbContext
{
    public static List<Car> Cars { get; set; } = new()
    {
        new Car { Id = 1, Make = "Chevrolet", Model = "Cruze" , Year = 2013 },
		new Car { Id = 2, Make = "Kia", Model = "Cerato", Year = 2013 },
		new Car { Id = 3, Make = "BMW", Model = "X5", Year = 2014 },
    };
}