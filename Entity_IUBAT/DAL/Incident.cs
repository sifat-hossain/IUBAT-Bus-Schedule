using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Incident : Base
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public int Bus_id { get; set; }

        public int Time_id { get; set; }

        public int Loc_from { get; set; }

        public int Loc_to { get; set; }

        public DateTime Incident_date { get; set; }

        public int Passanger_id { get; set; }

        public string passanger { get; set; }

        public string location_from { get; set; }

        public string location_to { get; set; }

        public string bus { get; set; }

        public string from_date { get; set; }

        public string to_date { get; set; }

        public int report_count { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into incedent(description, incident_date, passanger_id, bus_id, time_id,loc_from, loc_to ) values(@description, @incident_date, @passanger_id, @bus_id, @time_id, @loc_from, @loc_to)");

            Command.Parameters.AddWithValue("@bus_id", Bus_id);
            Command.Parameters.AddWithValue("@time_id", Time_id);
            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@incident_date", Incident_date);
            Command.Parameters.AddWithValue("@passanger_id", Passanger_id);
            Command.Parameters.AddWithValue("@loc_from", Loc_from);
            Command.Parameters.AddWithValue("@loc_to", Loc_to);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update incedent set description= @description, incident_date=@incident_date, passanger_id=@passanger_id where id = @id");
            Command.Parameters.AddWithValue("@id", Id);

            Command.Parameters.AddWithValue("@bus_id", Bus_id);
            Command.Parameters.AddWithValue("@time_id", Time_id);

            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@incident_date", Incident_date);
            Command.Parameters.AddWithValue("@passanger_id", Passanger_id);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from incedent where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, description, incedent_date, passanger_id, time_id, bus_id, loc_from, loc_to from incedent where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Description = Reader["desription"].ToString();
                Incident_date = (DateTime)Reader["incident_date"];
                Passanger_id = Convert.ToInt32(Reader["passanger_id"].ToString());
                Time_id = Convert.ToInt32(Reader["time_id"].ToString());
                Bus_id = Convert.ToInt32(Reader["bus_id"].ToString());
                Loc_from = Convert.ToInt32(Reader["loc_from"]);
                Loc_to = Convert.ToInt32(Reader["loc_to"]);
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder(@"Select  i.id as id, i.incident_date as [date], b.bus_number as bus_number ,  l.name as [from] , l1.name as [to] ,t.schedule_time as [time],  (p.name +' (' + p.std_id + ')') as reportedby, i.description as description 
                                        from incedent as i
                                        left join passanger as p on i.passanger_id = p.id
                                        left join bus as b on i.bus_id = b.id
                                        left join location as l on i.loc_from = l.id
                                        left join location as l1 on i.loc_to = l1.id
                                        left join time_schedule as t on i.time_id = t.id where i.id >0");
            if (passanger != "" && passanger!= "Name or ID Number")
            {
                Command.CommandText += "and p.name  like '%"+passanger+"%' or p.std_id  like  '%"+passanger+"%'";
            }
            if (location_from != "" && location_from != "ALL")
            {
                Command.CommandText += "and l.name= '" + location_from + "'";
            }
            if (location_to != "" && location_to != "ALL")
            {
                Command.CommandText += "and l1.name= '" + location_to + "'";
            }
            if (bus != "" && bus != "ALL")
            {
                Command.CommandText += "and b.bus_number= '" + bus + "'";
            }
            if (from_date != "" && to_date != "")
            {
                Command.CommandText += "and i.incident_date between '"+from_date+"' and '"+to_date+"'";
            }
            return ExecuteDataSet(Command);
        }

     
        public bool report()
        {

            Command = CommandBuilder(@"Select  count(*) as count from incedent as i 
                                        left join bus as b on i.bus_id = b.id
                                        left join location as l on i.loc_from = l.id
                                        left join location as l1 on i.loc_to = l1.id
                                        where i.id > 0 AND i.incident_date   BETWEEN '"+from_date+"' AND '"+to_date+"'  ");

            if (location_from != "" && location_from != "ALL")
            {
                Command.CommandText += "and l.name= '" + location_from + "'";
            }
            if (location_to != "" && location_to != "ALL")
            {
                Command.CommandText += "and l1.name= '" + location_to + "'";
            }
            if (bus != "" && bus != "ALL")
            {
                Command.CommandText += "and b.bus_number= '" + bus + "'";
            }

            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                report_count = Convert.ToInt32(Reader["count"]);
                return true;

            }
            return false;

        }

       


    }
}