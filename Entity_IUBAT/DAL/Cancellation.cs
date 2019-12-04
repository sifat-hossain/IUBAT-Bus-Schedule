using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Cancellation:Base
    {

        public int Id { get; set; }

        public int Canceled_id { get; set; }


        public bool Insert()
        {
            Command = CommandBuilder("insert into cancellation (canceled_id) values (@canceled_id)");
            Command.Parameters.AddWithValue("@canceled_id", Canceled_id);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("Update  cancellation set canceled_id = @canceled_id where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@canceled_id", Canceled_id);
            return Execute(Command);
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from cancellation where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, canceled_id from cancellation where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Canceled_id = Convert.ToInt32(Reader["canceled_id"].ToString());
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, canceled_id from cancellation");
            return ExecuteDataSet(Command);
        }

    }
}