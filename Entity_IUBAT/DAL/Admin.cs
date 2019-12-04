using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DAL
{
    class Admin :Base

    {
        public int Id { get; set; }

        public string Admin_Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public int Gender { get; set; }

        public DateTime JoinDate { get; set; }

        public string Address { get; set; }

        public string LogID { get; set; }

        public string LogPassword { get; set; }




        public bool Insert()
        {
            Command = CommandBuilder("Insert into admin (ad_id, name, password, contact, email, gender, joinDate, address) values (@ad_id, @name, @password, @contact, @email, @gender, @joinDate, @address)");
            Command.Parameters.AddWithValue("@ad_id", Admin_Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@password", Password);
            Command.Parameters.AddWithValue("@contact", Contact);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@gender", Gender);
            Command.Parameters.AddWithValue("@joinDate", JoinDate);
            Command.Parameters.AddWithValue("@address", Address);
            // Command.Parameters.AddWithValue("@type", Type);
            return Execute(Command);
        }
        public void LogIn()
        {
            Command = CommandBuilder("Select id,ad_id, name, password, contact, email, gender, joinDate, address from admin where ad_id = @ad_id and password= @password");
            Command.Parameters.AddWithValue("@password", Password);
            Command.Parameters.AddWithValue("@ad_id", Admin_Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"]);
                Email = Reader["email"].ToString();
                Name = Reader["name"].ToString();
                LogPassword = Reader["password"].ToString();
                Contact = Reader["contact"].ToString();
                LogID = Reader["ad_id"].ToString();
                Gender = Convert.ToInt32(Reader["gender"].ToString());
                JoinDate = (DateTime)Reader["joinDate"];
                Address = Reader["address"].ToString();
            }
    

        }


        public bool Update()
        {
            Command = CommandBuilder("Update  admin set ad_id= @ad_id, name = @name , contact=@contact, email=@email, address=@address  where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@ad_id", Admin_Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@password", Password);
            Command.Parameters.AddWithValue("@contact", Contact);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@address", Address);
            //Command.Parameters.AddWithValue("@type", Type);
            return Execute(Command);
        }
        public bool UpdatePassword()
        {
            Command = CommandBuilder("Update  admin set password= @password  where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@password", Password);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from admin where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, ad_id, name, password, contact, email, gender, joinDate, address from admin where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Admin_Id = Reader["ad_id"].ToString();
                Name = Reader["name"].ToString();
                Password = Reader["password"].ToString();
                Contact = Reader["contact"].ToString();
                Email = Reader["email"].ToString();
                Gender = Convert.ToInt32(Reader["gender"].ToString());
                JoinDate = (DateTime)Reader["joinDate"];
                Address = Reader["address"].ToString();
                return true;
            }
            return false;
        }
        public bool SelectByAdminId()
        {
            Command = CommandBuilder("select id, ad_id, name, password, contact, email, gender, joinDate, address from admin where ad_id = @ad_id");
            Command.Parameters.AddWithValue("@ad_id", Admin_Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"]);
                Admin_Id = Reader["ad_id"].ToString();
                Name = Reader["name"].ToString();
                Password = Reader["password"].ToString();
                Contact = Reader["contact"].ToString();
                Email = Reader["email"].ToString();
                Gender = Convert.ToInt32(Reader["gender"].ToString());
                JoinDate = (DateTime)Reader["joinDate"];
                Address = Reader["address"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder(@"select id, ad_id, name, password, contact, email, 
                                    (CASE gender
                                     WHEN 0 THEN 'Male'
                                     WHEN 1 THEN 'Female'
                                     END) as gn, 
                                     joinDate, address from admin");
            return ExecuteDataSet(Command);
        }


    }
}
