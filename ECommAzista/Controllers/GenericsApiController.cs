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

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericsApiController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GenericsApiController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"Select Id,GenericCode,GenericName,GenericSynonyms from 
                            dbo.GenericMaster
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
        
        [Route("GetById/{Id}")]
       // [HttpGet("{Id:int}")]
        public JsonResult GetById(int Id)
        {
            string query = @"Select Id,GenericCode,GenericName,GenericSynonyms from 
                            dbo.GenericMaster where Id=@Id
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Id", Id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
        [HttpPost]
        public JsonResult Post(GenericMaster generic)
        {
            string query = @"Insert into dbo.GenericMaster(GenericCode,GenericName,GenericSynonyms,isactive,CreatedBy,CreatedDate)
                            values(@GenericCode,@GenericName,@GenericSynonyms,0,'1','2023-02-09')
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, mycon))
                {

                    myCommand.Parameters.AddWithValue("@GenericCode", generic.GenericCode);
                    myCommand.Parameters.AddWithValue("@GenericName", generic.GenericName);
                    myCommand.Parameters.AddWithValue("@GenericSynonyms", generic.GenericSynonyms);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
        [HttpPut]
        public JsonResult Put(GenericMaster generic)
        {
            string query = @"Update dbo.GenericMaster
                             set GenericCode=@GenericCode , GenericName=@GenericName , GenericSynonyms=@GenericSynonyms
                             where Id=@Id                            
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, mycon))
                {

                    myCommand.Parameters.AddWithValue("@Id", generic.Id);
                    myCommand.Parameters.AddWithValue("@GenericCode", generic.GenericCode);
                    myCommand.Parameters.AddWithValue("@GenericName", generic.GenericName);
                    myCommand.Parameters.AddWithValue("@GenericSynonyms", generic.GenericSynonyms);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
        [HttpDelete]
        public JsonResult Delete(int Id)
        {
            string query = @"delete from dbo.GenericMaster
                             
                             where Id=@Id                            
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AzistaAppCon");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, mycon))
                {

                    myCommand.Parameters.AddWithValue("@Id", Id);
                   
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }
    }
}
