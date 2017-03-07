using AdventureWorksCenter.BusinessServices.Interfaces;
using AdventureWorksCenter.DataAccess.UnitOfWork;
using System.Web.Http;

namespace AdventureWorksCenter.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService _service;
        
        public  ProductController(IProductService service)
        {
            _service = service;
        }


        public IHttpActionResult GetByID(int? Id)
        {
            try
            {
                if (!Id.HasValue)
                    BadRequest();

               var product = _service.GetProductsByID(Id);

                if(product == null)
                    return NotFound();

                return Ok(product);
            }
            catch (System.Exception ex)
            {

                return InternalServerError(ex);
               
            }
        }
        

    }
}
