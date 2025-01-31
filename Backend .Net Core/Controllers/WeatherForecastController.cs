using Microsoft.AspNetCore.Mvc;

namespace Backend_.Net_Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpPost]
        public decimal Add(Numbers numbers)
        {
            return numbers.A - numbers.B;
        }

        [HttpPut]
        public decimal Edit(decimal a, decimal b)
        {
            return a * b;
        }

        [HttpDelete]
        public decimal Delete(decimal a, decimal b)
        {
            return a / b;
        }
    }

    public class Numbers
    {
      public decimal A { get; set; }
      public decimal B { get; set; }
    }
}
