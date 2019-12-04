using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DAL
{
    class Schedule : Base
    {
        public int Id { get; set; }

        public int Time_ID { get; set; }

        public int Location_From { get; set; }

        public int LOC_FROM { get; set; }

        public int Location_To { get; set; }


        public bool Insert()
        {
            Command = CommandBuilder("insert into schedule (t_id, l_from, l_to) values (@t_id, @l_from, @l_to)");
            Command.Parameters.AddWithValue("@t_id", Time_ID);
            Command.Parameters.AddWithValue("@l_from", Location_From);
            Command.Parameters.AddWithValue("@l_to", Location_To);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("Update  schedule set t_id = @t_id, l_from = @l_from, l_to = @l_to where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@t_id", Time_ID);
            Command.Parameters.AddWithValue("@l_from", Location_From);
            Command.Parameters.AddWithValue("@l_to", Location_To);
            return Execute(Command);
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from schedule where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, t_id, l_from, l_to from schedule where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"].ToString());
                Time_ID = Convert.ToInt32(Reader["t_id"].ToString());
                Location_From = Convert.ToInt32(Reader["l_from"].ToString());
                Location_To = Convert.ToInt32(Reader["l_to"].ToString());
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select s.id, t.schedule_time as time_id, l.name as location_from, l2.name as location_to  from schedule as s left join time_schedule as t on s.t_id= t.id left join location as l on s.l_from = l.id left join location as l2 on s.l_to = l2.id");
            return ExecuteDataSet(Command);
        }


        public DataSet SelectLocTo()
        {
            Command = CommandBuilder("select  l.id as loc_id, l.name as loc_name from schedule as s left join location as l on s.l_to = l.id where t_id=@t_id and l_from=@l_from");
            Command.Parameters.AddWithValue("@t_id", Time_ID);
            Command.Parameters.AddWithValue("@l_from", Location_From);
            return ExecuteDataSet(Command);
        }

        public DataSet SelectLocFrom()
        {
            Command = CommandBuilder("select  l.id as loc_id, l.name as loc_name from schedule as s left join location as l on s.l_from = l.id where t_id=@t_id and l_to=@l_to");
            Command.Parameters.AddWithValue("@t_id", Time_ID);
            Command.Parameters.AddWithValue("@l_to", Location_To);
            return ExecuteDataSet(Command);
        }

        public bool SelectId()
        {
            Command = CommandBuilder("Select id from schedule where t_id = @t_id and l_from =@l_from and l_to = @l_to");
            Command.Parameters.AddWithValue("@t_id", Time_ID);
            Command.Parameters.AddWithValue("@l_from", LOC_FROM);
            Command.Parameters.AddWithValue("@l_to", Location_To);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"].ToString());
                return true;
            }
            return false;
        }

        public bool ScheduleAlreadyExist()
        {
            int i = 0;
            Command = CommandBuilder("Select * from schedule where t_id = @t_id and l_from =@l_from and l_to = @l_to");
            Command.Parameters.AddWithValue("@l_from", Location_From);
            Command.Parameters.AddWithValue("@l_to", Location_To);
            Command.Parameters.AddWithValue("@t_id", Time_ID);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                if (Reader.HasRows == true)
                {
                    i++; 
                }
            }
            if (i > 0)
                return true;

            return false;
        }
    }
}
