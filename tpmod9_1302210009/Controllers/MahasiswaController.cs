using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace tpmod9_1302210009.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController
    {
        

            static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("Heru Ikhsan Maulana", "1302210009"),
            new Mahasiswa("Muhammad Vikhan Muharram", "1302213089"),
            new Mahasiswa("Muhammad Fadhil Ardiansyah Supiyan", "1302210006"),
            new Mahasiswa("Faris Siddiq Ramdan Putra", "1302213133"),
            new Mahasiswa("Bimo Zachriansyah Wicaksono Hermawan", "1302213012")
            };

            // GET: api/<MahasiswaController>
            [HttpGet]
            public IEnumerable<Mahasiswa> Get()
            {
                return listMhs;
            }

            // GET api/<MahasiswaController>/5
            [HttpGet("{id}")]
            public Mahasiswa Get(int id)
            {
                return listMhs[id];
            }

            // POST api/<MahasiswaController>
            [HttpPost]
            public void Post([FromBody] Mahasiswa value)
            {
                listMhs.Add(value);
            }


            // DELETE api/<MahasiswaController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                listMhs.RemoveAt(id);
            }
        }
    }
