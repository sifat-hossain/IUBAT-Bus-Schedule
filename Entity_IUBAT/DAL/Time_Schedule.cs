using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Time_Schedule : Base
    {

        public int Id { get; set; } 

        public string Schedule_time { get; set; }



        public bool Insert()
        {
            Command = CommandBuilder("insert into time_schedule (schedule_time) values (@schedule_time)");
            Command.Parameters.AddWithValue("@schedule_time", Schedule_time);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("Update  time_schedule set schedule_time = @schedule_time where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@schedule_time", Schedule_time);
            return Execute(Command);
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from time_schedule where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, schedule_time from time_schedule where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Schedule_time = Reader["schedule_time"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, schedule_time from time_schedule");
            if (Schedule_time != null && Schedule_time != "")
            {
                Command.CommandText += " where schedule_time like @search";
                Command.Parameters.AddWithValue("@search", "%" + Schedule_time + "%");
            }

            return ExecuteDataSet(Command);
        }

    }
}