using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Penalty : Base
    {
        public int Id { get; set; }

        public int Booking_id { get; set; }

        public int Amount { get; set; }

        public int Penalty_Status { get; set; }



        public string from_date { get; set; }

        public string to_date { get; set; }

        public int report_count { get; set; }

        public int temp { get; set; }

        public string location_from { get; set; }

        public string location_to { get; set; }

        public string bus { get; set; }

        public string passanger { get; set; }

        public DateTime date { get; set; }

        public int pas_id { get; set; }

        public int notification_count { get; set; }



        public bool Insert()
        {
            Command = CommandBuilder("insert into penalty (booking_id, amount, penalty_status) values (@booking_id, 50,1)");
            Command.Parameters.AddWithValue("@booking_id", Booking_id);
         
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("Update  penalty set penalty_status = 0 where id=@id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from penalty where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }
        public bool SelectById()
        {
            Command = CommandBuilder("select id, booking_id, amount, penalty_status from penalty where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Booking_id = Convert.ToInt32(Reader["booking_id"].ToString());
                Amount = Convert.ToInt32(Reader["amount"].ToString());
                Penalty_Status = Convert.ToInt32(Reader["penalty_status"]);
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder(@"select p.id,pas.name as passanger, l1.name as [from], l2.name as [to] , t.schedule_time as [time], b.date as [date], bus.bus_number as bus, p.amount as amount, p.penalty_status from penalty as p 
                                        left join booking as b on p.booking_id = b.id
                                        left join passanger as pas on b.passanger_id = pas.id
                                        left join bus_schedule as bs on  b.schedule_id = bs.id
                                        left join schedule as s on bs.s_id = s.id
                                        left join location as l1 on s.l_from = l1.id
                                        left join location as l2 on s.l_to = l2.id
                                        left join time_schedule as t on s.t_id = t.id
                                        left join bus as bus on bs.b_id = bus.id
                                        where penalty_status = 1");

            if (location_from != "" && location_from != "ALL")
            {
                Command.CommandText += "and l1.name= '"+location_from+"'";
            }
            if (location_to != "" && location_to != "ALL")
            {
                Command.CommandText += "and l2.name= '"+location_to+"'";
            }
            if (bus != "" && bus != "ALL")
            {
                Command.CommandText += "and bus.bus_number= '"+bus+"'";
            }
            if (passanger != "" && passanger != "Name or ID Number")
            {
                Command.CommandText += "and (pas.name like '%"+passanger+ "%' or pas.email like '%" + passanger + "%' or pas.std_id like '%" + passanger + "%')";
            }
            return ExecuteDataSet(Command);
        }

        public DataSet SelectbyId()
        {
            Command = CommandBuilder(@"select p.id,pas.name as passanger, l1.name as [from], l2.name as [to] , t.schedule_time as [time], b.date as [date], bus.bus_number as bus, p.amount as amount from penalty as p 
                                        left join booking as b on p.booking_id = b.id
                                        left join passanger as pas on b.passanger_id = pas.id
                                        left join bus_schedule as bs on  b.schedule_id = bs.id
                                        left join schedule as s on bs.s_id = s.id
                                        left join location as l1 on s.l_from = l1.id
                                        left join location as l2 on s.l_to = l2.id
                                        left join time_schedule as t on s.t_id = t.id
                                        left join bus as bus on bs.b_id = bus.id
                                        where penalty_status = 1 And pas.id = @passenger");

            Command.Parameters.AddWithValue("@passenger", pas_id);

            return ExecuteDataSet(Command);
        }


        public bool notification()
        {

            Command = CommandBuilder(@" select count(*) as count from penalty as p 
                                        left join booking as b on p.booking_id = b.id
                                        left join passanger as pas on b.passanger_id = pas.id
                                        left join bus_schedule as bs on  b.schedule_id = bs.id
                                        left join schedule as s on bs.s_id = s.id
                                        left join location as l1 on s.l_from = l1.id
                                        left join location as l2 on s.l_to = l2.id
                                        left join time_schedule as t on s.t_id = t.id
                                        left join bus as bus on bs.b_id = bus.id
                                        where penalty_status = 1 And pas.id = @passanger");

            Command.Parameters.AddWithValue("@passanger", pas_id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                notification_count = Convert.ToInt32(Reader["count"]);
                return true;

            }
            return false;

        }





        public bool report()
        {

            Command = CommandBuilder(@" Select count(*) as count from penalty as p 
                                        left join booking as b  on p.booking_id = b.id
                                        left join bus_schedule as bs on b.schedule_id = bs.id
                                        left join schedule as s on bs.s_id = s.id
                                        left join bus as bus on bs.b_id = bus.id
                                        left join location as l on s.l_from = l.id
                                        left join location as l1 on s.l_to = l1.id
                                        where b.date  BETWEEN '"+from_date+"' AND '"+to_date+"' ");

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
                Command.CommandText += "and bus.bus_number= '" + bus + "'";
            }

            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                report_count = Convert.ToInt32(Reader["count"]);
                return true;

            }
            return false;

        }




        public bool PenaltyAlreadyExist()
        {
            int i = 0;
            Command = CommandBuilder("Select * from penalty where booking_id = @booking_id");
            Command.Parameters.AddWithValue("@booking_id", Booking_id);
         
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