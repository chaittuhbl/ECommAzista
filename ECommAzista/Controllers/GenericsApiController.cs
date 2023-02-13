using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using ECommAzista.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericsApiController : ControllerBase
    {
        // private readonly IConfiguration _configuration;
        // public GenericsApiController(IConfiguration configuration)
        // {
        //     _configuration = configuration;
        // }
        // [HttpGet]
        // public JsonResult Get()
        // {
        //     string query = @"Select Id,GenericCode,GenericName,GenericSynonyms from 
        //                     dbo.GenericMaster
        //                     ";
        //     DataTable table = new DataTable();
        //     string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
        //     SqlDataReader myReader;
        //     using (SqlConnection mycon = new SqlConnection(sqlDataSource))
        //     {
        //         mycon.Open();
        //         using (SqlCommand myCommand = new SqlCommand(query, mycon))
        //         {
        //             myReader = myCommand.ExecuteReader();
        //             table.Load(myReader);
        //             myReader.Close();
        //             mycon.Close();
        //         }
        //     }

        //     return new JsonResult(table);
        // }

        // [Route("GetById/{Id}")]
        //// [HttpGet("{Id:int}")]
        // public JsonResult GetById(int Id)
        // {
        //     string query = @"Select Id,GenericCode,GenericName,GenericSynonyms from 
        //                     dbo.GenericMaster where Id=@Id
        //                     ";
        //     DataTable table = new DataTable();
        //     string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
        //     SqlDataReader myReader;
        //     using (SqlConnection mycon = new SqlConnection(sqlDataSource))
        //     {
        //         mycon.Open();
        //         using (SqlCommand myCommand = new SqlCommand(query, mycon))
        //         {
        //             myCommand.Parameters.AddWithValue("@Id", Id);
        //             myReader = myCommand.ExecuteReader();
        //             table.Load(myReader);
        //             myReader.Close();
        //             mycon.Close();
        //         }
        //     }

        //     return new JsonResult(table);
        // }
        // [HttpPost]
        // public JsonResult Post(GenericMaster generic)
        // {
        //     string query = @"Insert into dbo.GenericMaster(GenericCode,GenericName,GenericSynonyms,isactive,CreatedBy,CreatedDate)
        //                     values(@GenericCode,@GenericName,@GenericSynonyms,0,'1','2023-02-09')
        //                     ";
        //     DataTable table = new DataTable();
        //     string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
        //     SqlDataReader myReader;
        //     using (SqlConnection mycon = new SqlConnection(sqlDataSource))
        //     {
        //         mycon.Open();
        //         using (SqlCommand myCommand = new SqlCommand(query, mycon))
        //         {

        //             myCommand.Parameters.AddWithValue("@GenericCode", generic.GenericCode);
        //             myCommand.Parameters.AddWithValue("@GenericName", generic.GenericName);
        //             myCommand.Parameters.AddWithValue("@GenericSynonyms", generic.GenericSynonyms);
        //             myReader = myCommand.ExecuteReader();
        //             table.Load(myReader);
        //             myReader.Close();
        //             mycon.Close();
        //         }
        //     }

        //     return new JsonResult(table);
        // }
        // [HttpPut]
        // public JsonResult Put(GenericMaster generic)
        // {
        //     string query = @"Update dbo.GenericMaster
        //                      set GenericCode=@GenericCode , GenericName=@GenericName , GenericSynonyms=@GenericSynonyms
        //                      where Id=@Id                            
        //                     ";
        //     DataTable table = new DataTable();
        //     string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
        //     SqlDataReader myReader;
        //     using (SqlConnection mycon = new SqlConnection(sqlDataSource))
        //     {
        //         mycon.Open();
        //         using (SqlCommand myCommand = new SqlCommand(query, mycon))
        //         {

        //             myCommand.Parameters.AddWithValue("@Id", generic.Id);
        //             myCommand.Parameters.AddWithValue("@GenericCode", generic.GenericCode);
        //             myCommand.Parameters.AddWithValue("@GenericName", generic.GenericName);
        //             myCommand.Parameters.AddWithValue("@GenericSynonyms", generic.GenericSynonyms);
        //             myReader = myCommand.ExecuteReader();
        //             table.Load(myReader);
        //             myReader.Close();
        //             mycon.Close();
        //         }
        //     }

        //     return new JsonResult(table);
        // }
        // [HttpDelete]
        // public JsonResult Delete(int Id)
        // {
        //     string query = @"delete from dbo.GenericMaster

        //                      where Id=@Id                            
        //                     ";
        //     DataTable table = new DataTable();
        //     string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
        //     SqlDataReader myReader;
        //     using (SqlConnection mycon = new SqlConnection(sqlDataSource))
        //     {
        //         mycon.Open();
        //         using (SqlCommand myCommand = new SqlCommand(query, mycon))
        //         {

        //             myCommand.Parameters.AddWithValue("@Id", Id);

        //             myReader = myCommand.ExecuteReader();
        //             table.Load(myReader);
        //             myReader.Close();
        //             mycon.Close();
        //         }
        //     }

        //     return new JsonResult(table);
        // }
        public AzistaEcommContext _azistaEcommContext;
        public GenericsApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var generics = await _azistaEcommContext.GenericMaster.ToListAsync();
            return Ok(generics);
        }
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var generic = await _azistaEcommContext.GenericMaster.FindAsync(Id);
            return Ok(generic);
        }
        [HttpPut]
        public async Task<ActionResult<GenericMaster>> UpdateGenerics(GenericMaster generic)
        {
            _azistaEcommContext.GenericMaster.Update(generic);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteGenerics(int Id)
        {
            if (_azistaEcommContext.GenericMaster == null)
            {
                return NotFound();
            }
            var generic = _azistaEcommContext.GenericMaster.Find(Id);
            _azistaEcommContext.GenericMaster.Remove(generic);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
