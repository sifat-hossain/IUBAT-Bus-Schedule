
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DAL
{
    class BusSchedule :Base
    {
        public int Id { get; set; }

        public int Bus_id { get; set; }

        public int Schedule_id { get; set; }

 


        public bool Insert()
        {
            Command = CommandBuilder("insert into bus_schedule (b_id, s_id) values (@b_id, @s_id)");
            Command.Parameters.AddWithValue("@b_id", Bus_id);
            Command.Parameters.AddWithValue("@s_id", Schedule_id);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("Update  bus_schedule set b_id = @b_id where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@b_id", Bus_id);
            return Execute(Command);
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from bus_schedule where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, b_id, s_id from bus_schedule where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"].ToString());
                Bus_id = Convert.ToInt32(Reader["b_id"].ToString());
                Schedule_id = Convert.ToInt32(Reader["s_id"].ToString());
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder(@"select bs.id as id, t.schedule_time as time, l.name as loc_from , l2.name as loc_to, b.bus_number as bus_no from bus_schedule as bs 
                                        left join schedule as s on bs.s_id = s.id left join time_schedule as t on s.t_id = t.id 
                                        left join location as l on s.l_from = l.id left join location as l2 on s.l_to = l2.id
                                        left join bus as b on bs.b_id =  b.id");
            return ExecuteDataSet(Command);
        }

        public DataSet SelectBus()
        {
            Command = CommandBuilder(@"select b.id as bus_id,b.bus_number as bus_no from bus_schedule as bs left join bus as b on bs.b_id = b.id where bs.s_id =@s_id");
            Command.Parameters.AddWithValue("@s_id", Schedule_id);
            return ExecuteDataSet(Command);
        }

        public bool SelectID()
        {
            Command = CommandBuilder("select id from bus_schedule where b_id =@b_id and s_id = @s_id");
            Command.Parameters.AddWithValue("@b_id", Bus_id);
            Command.Parameters.AddWithValue("@s_id", Schedule_id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"].ToString());
                return true;
            }
            return false;
        }


    }
}
