using ExpenseTrackerServer.Data;
using ExpenseTrackerServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ExpenseTrackerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseTrackerController : ControllerBase
    {
        private readonly ExpenseTrackerDbContext _context;


        public ExpenseTrackerController(ExpenseTrackerDbContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult createAndEdit(Expenses expenses)
        {
            if (expenses.Id == 0)
            {
                _context.Expenses.Add(expenses);
            }
            else
            {
                var expenseInDb = _context.Expenses.Find(expenses.Id);

                if (expenseInDb == null)
                    return new JsonResult("400");

                expenseInDb = expenses;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(expenses));

        }


        // Get all
        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Expenses.ToList();

            return new JsonResult(Ok(result));
        }

        // Get
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var result = _context.Expenses.Find(id);

            if (result == null)
                return new JsonResult("400");

            return new JsonResult(Ok(result));
        }





        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Expenses.Find(id);

            if (result == null)
                return new JsonResult("400");

            _context.Expenses.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }


    }


}

