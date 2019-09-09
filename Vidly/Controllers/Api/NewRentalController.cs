using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        public ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult CreateNewRentals(NewRentalDto rentalDto)
        {
            //if (rentalDto.MovieIds.Count == 0)
            //    return BadRequest("No Movie Ids have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == rentalDto.CustomerId);


            //if (customer == null)
            //    return BadRequest("CustomerId is not valid.");

            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            //if (movies.Count == rentalDto.MovieIds.Count)
            //    return BadRequest("One or more MovieId is invalid.");

            foreach (var movie in movies)
            {
                if (movie.AailableNumber == 0)
                    return BadRequest("Movie is not available.");

                movie.AailableNumber--;

                _context.Rentals.Add(new Rental {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                });

                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
