using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace steven_ashraf.Controllers
{
    public class requstController : ApiController
    {
        [HttpGet]
        [Authorize]
        [Route("api/Request/GetReqType/")]
        public IHttpActionResult GetReqType()
        {
            var arg = "";
            List<docModel> doc = new List<docModel>();

            using (var ctx = new ReportServerTempDBEntities())
            {
                arg = "SELECT   Name FROM   Doc WHERE  (Category = N'ReqType') GROUP BY Name";
                doc = ctx.Database.SqlQuery<docModel>(arg).ToList();
                return Ok(doc);
            }
        }

         
        [HttpGet]
        [Authorize]
        [Route("api/Request/Getsoftware/")]
        public IHttpActionResult Getsoftware()
        {
            var arg = "";
            List<docModel> doc = new List<docModel>();

            using (var ctx = new ReportServerTempDBEntities())
            {
                arg = "SELECT   Name FROM   Doc WHERE  (Category = N'software') GROUP BY Name";
                doc = ctx.Database.SqlQuery<docModel>(arg).ToList();
                return Ok(doc);
            }
        }

        [HttpGet]
        [Authorize]
        [Route("api/Request/Getreq/")]
        public IHttpActionResult Getreq(string cat)
        {
            var arg = "";
            List<docModel> doc = new List<docModel>();

            using (var ctx = new ReportServerTempDBEntities())
            {
                arg = "SELECT   Name FROM   Doc WHERE  (Category = N'"+cat+"') GROUP BY Name";
                doc = ctx.Database.SqlQuery<docModel>(arg).ToList();
                return Ok(doc);
            }
        }

        
        [HttpGet]
        [Authorize]
        [Route("api/Request/GetAllUsers/")]
        public IHttpActionResult GetAllUsers()
            {
            var arg = "";
            List<usersModel> users = new List<usersModel>();

            using (var ctx = new ReportServerTempDBEntities())
            {
                arg = "SELECT Email FROM users GROUP BY Email";
                users = ctx.Database.SqlQuery<usersModel>(arg).ToList();
                return Ok(users);
            }
           
        }
        [HttpGet]
        [Authorize]
        [Route("api/Request/GetAllManegers/")]
        public IHttpActionResult GetAllManegers()
        {
            var arg = "";
            List<userModel> users = new List<userModel>();

            using (var ctx = new ReportServerTempDBEntities())
            {
                arg = "SELECT Maneger FROM users GROUP BY Maneger";
                users = ctx.Database.SqlQuery<userModel>(arg).ToList();
                return Ok(users);
            }

        }
        [HttpGet]
        [Authorize]
        [Route("api/Request/GetUsersWithManagers")]
        public IHttpActionResult GetUsersWithManagers()
        {
            using (var ctx = new ReportServerTempDBEntities())
            {
                var arg = "SELECT Email, Maneger FROM users";
                var users = ctx.Database.SqlQuery<UserWithManagerModel>(arg).ToList();
                return Ok(users);
            }
        }

        public class UserWithManagerModel
        {
            public string Email { get; set; }
            public string Maneger { get; set; }
        }

        [HttpPost]
        [Authorize]
        [Route("api/Request/AddRequest")]
        public IHttpActionResult AddRequest([FromBody] RequestModel model)
        {
            if (model == null)
                return BadRequest("Invalid data");

            using (var ctx = new ReportServerTempDBEntities())
            {
                // هنا بتكتب اسم الجدول بالظبط زي ما هو في الداتا بيز
                var sql = @"INSERT INTO IT_Request
                    (Req, Details, Private, Other, Remarks, Status, Req_type, Site, Date_Time, User_ID) 
                    VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";

                ctx.Database.ExecuteSqlCommand(sql,
                    model.Req,
                    model.Details,
                    model.PrivateRequest,
                    model.Other,
                    model.Remarks,
                    model.Status,
                    model.Req_type,
                    model.Site,
                    model.Date_Time,
                    User.Identity.Name

                );
            }

            return Ok("Save Done");
        }


    }
}




