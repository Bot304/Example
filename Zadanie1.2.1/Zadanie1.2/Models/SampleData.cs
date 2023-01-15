using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie1._2.Models
{
    public class SampleData
    {
        public static void Initialize(ShapeContext context)
        {
            if (!context.Shapes.Any())
            {
                context.Shapes.AddRange(
                    new Shape
                    {
                        Name = "Алег",
                        Surname = "Вуйчич",
                        Patronymic = "Владимирович",
                        DateBirth = new DateTime(1960, 1, 1),
                        
                        Number = "88005553535",
                        Email = "Aleg@mail.ru"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
