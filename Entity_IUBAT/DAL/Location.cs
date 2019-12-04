using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Location:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into location (name, city) values (@name, @city)");
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@city", City);

            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("Update location set name = @name,city = @city where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@city", City);
            return Execute(Command);
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from location where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, name, city from location where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Name = Reader["name"].ToString();
                
                City = Reader["city"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, name, city from location where id >0");
            if (Name != null && Name != "")
            {
                Command.CommandText += " and name like @search or city like @search";
                Command.Parameters.AddWithValue("@search", "%" + Name + "%");
            }


            return ExecuteDataSet(Command);
        }

    }
}