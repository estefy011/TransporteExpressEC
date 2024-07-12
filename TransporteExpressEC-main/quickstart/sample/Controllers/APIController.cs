using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SampleMvcApp.Data;
using SampleMvcApp.KMS;
using SampleMvcApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvcApp.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class APIController : ControllerBase
    {
        
        private readonly EncryptDataExample _encryption; 
        private readonly DecryptDataExample _decrypt;
        private readonly ApplicationDbContext _context;
       


        public APIController(ApplicationDbContext context, EncryptDataExample encryption, DecryptDataExample decrypt)
        {
            _decrypt = decrypt;
            _context = context;
            _encryption= encryption;
        }

        [HttpGet("get-data")]
        public async Task<IActionResult> GetData()
        {
            

            

            List < Viaje > viajes = _context.Viaje.ToList();

            string viajesJson = JsonConvert.SerializeObject(viajes);

            string encryptedData = _encryption.EncryptSymmetric(viajesJson);

            return Ok(encryptedData);
        }

        [HttpPost("enc")]
        public async Task<IActionResult> PostData(Response data)
        {
            
            var decripted = _decrypt.DecryptSymmetric(data.data);

            return Ok(decripted);
 
        }

    }
}
