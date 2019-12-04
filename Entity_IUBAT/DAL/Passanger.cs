using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Passanger:Base
    {
        public int Id { get; set; }
        
        public string Student_Id { get; set; }  

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
            Command = CommandBuilder("Insert into passanger (std_id, name, password, contact, email, gender, joinDate, address) values (@std_id, @name, @password, @contact, @email, @gender, @joinDate, @address)");
            Command.Parameters.AddWithValue("@std_id", Student_Id);
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
            Command = CommandBuilder("Select  id, std_id, name, password, contact, email, gender, joinDate, address from passanger where std_id = @std_id and password= @password");
            Command.Parameters.AddWithValue("@password", Password);
            Command.Parameters.AddWithValue("@std_id", Student_Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"].ToString());
                Name = Reader["name"].ToString();
                LogPassword = Reader["password"].ToString();
                Contact = Reader["contact"].ToString();
                Email = Reader["email"].ToString();
                LogID = Reader["std_id"].ToString();
                Gender = Convert.ToInt32(Reader["gender"].ToString());
                JoinDate = (DateTime)Reader["joinDate"];
                Address = Reader["address"].ToString();
            }
        }


        public bool Update()
        {
            Command = CommandBuilder("Update  passanger set std_id= @std_id, name = @name , contact=@contact, email=@email, address=@address  where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@std_id", Student_Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@contact", Contact);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@address", Address);
            //Command.Parameters.AddWithValue("@type", Type);
            return Execute(Command);
        }
        public bool UpdatePassword()
        {
            Command = CommandBuilder("Update  passanger set password= @password  where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@password", Password);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from passanger where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, std_id, name, password, contact, email, gender, joinDate, address from passanger where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Student_Id = Reader["std_id"].ToString();
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

        public bool SelectByStudentId()
        {
            Command = CommandBuilder("select id, std_id, name, password, contact, email, gender, joinDate, address from passanger where std_id = @std_id");
            Command.Parameters.AddWithValue("@std_id", Student_Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"]);
                Student_Id = Reader["std_id"].ToString();
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
            Command = CommandBuilder(@"select id, std_id, name, password, contact, email, 
                                    (CASE gender
                                     WHEN 0 THEN 'Male'
                                     WHEN 1 THEN 'Female'
                                     END) as gn ,
                                     joinDate, address from passanger where id>0");

            if (Name != null && Name != "")
            {
                Command.CommandText += " and name like @search or std_id like @search";
                Command.Parameters.AddWithValue("@search", "%" + Name + "%");
            }

            return ExecuteDataSet(Command);
        }


    }
}