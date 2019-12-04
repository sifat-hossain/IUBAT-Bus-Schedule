using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Booking:Base
    {

        public int Id { get; set; }

        public int Passanger_id { get; set; }

        public int Schedule_id { get; set; }

        public DateTime Date { get; set; }

        public int Booking_status { get; set; }

        public int Count { get; set; }

        

        public int cancle_count { get; set; }

        public string from_date { get; set; }

        public string to_date { get; set; }

        public int temp  { get; set; }

        public int bus_id { get; set; }

        public int available_count { get; set; }

        public string temporary { get; set; }

        public string Bus_number { get; set; }

        public string Loc_from { get; set; }

        public string Loc_to { get; set; }

        public string time { get; set; }

        public int Report { get; set; }

        
        public bool Insert()
        {
            Command = CommandBuilder("insert into booking(passanger_id, schedule_id, date, booking_status) values(@passanger_id, @schedule_id, @date, @booking_status)");

            Command.Parameters.AddWithValue("@passanger_id", Passanger_id);
            Command.Parameters.AddWithValue("@schedule_id", Schedule_id);
            Command.Parameters.AddWithValue("@date", Date);
            Command.Parameters.AddWithValue("@booking_status", Booking_status);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update booking set booking_status=@booking_status where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@booking_status", Booking_status);


            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from booking where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, passanger_id, schedule_id, date, booking_status from booking where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Passanger_id = Convert.ToInt32(Reader["passanger_id"].ToString());
                Schedule_id = Convert.ToInt32(Reader["schedule_id"].ToString());
                Date = (DateTime)Reader["date"];
                Booking_status = Convert.ToInt32(Reader["booking_status"].ToString());
                return true;

            }
            return false;
        }

        public bool SelectByIdForPenalty()
        {
            Command = CommandBuilder("select id, passanger_id, schedule_id, date, booking_status from booking where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Passanger_id = Convert.ToInt32(Reader["passanger_id"].ToString());
                Schedule_id = Convert.ToInt32(Reader["schedule_id"].ToString());
                Date = (DateTime)Reader["date"];
                Booking_status = Convert.ToInt32(Reader["booking_status"].ToString());
                return true;

            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select b.id, p.name as passanger ,bb.bus_number  as bus, l1.name as [from], l2.name as [to], ts.schedule_time as [time],   b.date from booking as b left join bus_schedule as bs on b.schedule_id= bs.id left join schedule as s on bs.s_id = s.id left join location as l1 on s.l_from = l1.id left join location as l2 on s.l_to =l2.id left join time_schedule as ts on s.t_id = ts.id left  join bus as bb on bs.b_id = bb.id left join passanger as p on b.passanger_id = p.id where  b.booking_status =1");
            if (temporary != null && temporary != "")
            {
                Command.CommandText += " and name like @search or std_id like @search";
                Command.Parameters.AddWithValue("@search", "%" + temporary + "%");
            }
            return ExecuteDataSet(Command);
        }

        public bool Booking_information()
        {
            Command = CommandBuilder("select b.id,bb.bus_number  as bus, l1.name as [from], l2.name as [to], ts.schedule_time as [time],   b.date from booking as b left join bus_schedule as bs on b.schedule_id= bs.id left join schedule as s on bs.s_id = s.id left join location as l1 on s.l_from = l1.id left join location as l2 on s.l_to =l2.id left join time_schedule as ts on s.t_id = ts.id left  join bus as bb on bs.b_id = bb.id where b.passanger_id =@passanger and b.booking_status =1 and b.id =@b_id");
            Command.Parameters.AddWithValue("@b_id", Id);
            Command.Parameters.AddWithValue("@passanger", Passanger_id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Bus_number = Reader["bus"].ToString();
                Loc_from = Reader["from"].ToString();
                Loc_to = Reader["to"].ToString();
                time = Reader["time"].ToString();
                Date = (DateTime)Reader["date"];

                return true;

            }
            return false;
        }


        public bool Return_passanger_ID()
        {
            Command = CommandBuilder("select b.id, p.id as passanger from booking as b left join bus_schedule as bs on b.schedule_id= bs.id left join schedule as s on bs.s_id = s.id  left join bus as bb on bs.b_id = bb.id left join passanger as p on b.passanger_id = p.id where b.booking_status = 1 and b.id = @b_id");
            Command.Parameters.AddWithValue("@b_id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Passanger_id = Convert.ToInt32(Reader["passanger"].ToString());
                return true;

            }
            return false;
        }

        public DataSet BookingOfPassanger()
        {
            Command = CommandBuilder("select b.id,bb.bus_number  as bus, l1.name as [from], l2.name as [to], ts.schedule_time as [time],   b.date from booking as b left join bus_schedule as bs on b.schedule_id= bs.id left join schedule as s on bs.s_id = s.id left join location as l1 on s.l_from = l1.id left join location as l2 on s.l_to =l2.id left join time_schedule as ts on s.t_id = ts.id left  join bus as bb on bs.b_id = bb.id where b.passanger_id =@passanger_id and b.booking_status =1");
            Command.Parameters.AddWithValue("@passanger_id", Passanger_id);
            return ExecuteDataSet(Command);
        }


        public bool SearchBookingForValidation()
        {
            Command = CommandBuilder("select count(*) as [count]  from booking where passanger_id =@passanger_id and [date] = @date");
            Command.Parameters.AddWithValue("@passanger_id", Passanger_id);
            Command.Parameters.AddWithValue("@date", Date);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Count = Convert.ToInt32(Reader["count"].ToString());
                return true;

            }
            return false;
        }

        

        public bool reportbook()
            {
            
            Command = CommandBuilder(@"Select  count(*) as count from booking as b 
                                        left join bus_schedule as bs  on b.schedule_id = bs.id
                                        left join bus as bus on bs.b_id = bus.id
                                        left join schedule as s on bs.s_id = s.id
                                        left join location as l on s.l_from = l.id
                                        left join location as l1 on s.l_to = l1.id
                                        where b.id > 0 AND  b.date  BETWEEN '"+from_date+"' AND '"+to_date+"'  and b.booking_status = 1");

            if (Loc_from != "" && Loc_from != "ALL")
            {
                Command.CommandText += "and l.name= '" + Loc_from + "'";
            }
            if (Loc_to != "" && Loc_to != "ALL")
            {
                Command.CommandText += "and l1.name= '" + Loc_to + "'";
            }
            if (Bus_number != "" && Bus_number != "ALL")
            {
                Command.CommandText += "and bus.bus_number= '" + Bus_number + "'";
            }

            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Report = Convert.ToInt32(Reader["count"]);
                return true;

            }
            return false;


        }
        public bool reportCancle()
        {

            Command = CommandBuilder(@"Select  count(*) as count from booking as b 
                                        left join bus_schedule as bs  on b.schedule_id = bs.id
                                        left join bus as bus on bs.b_id = bus.id
                                        left join schedule as s on bs.s_id = s.id
                                        left join location as l on s.l_from = l.id
                                        left join location as l1 on s.l_to = l1.id
                                        where b.id > 0 AND  b.date  BETWEEN '"+from_date+"' AND '"+to_date+"'  and b.booking_status = 0");
            if (Loc_from != "" && Loc_from != "ALL")
            {
                Command.CommandText += "and l.name= '" + Loc_from + "'";
            }
            if (Loc_to != "" && Loc_to != "ALL")
            {
                Command.CommandText += "and l1.name= '" + Loc_to + "'";
            }
            if (Bus_number != "" && Bus_number != "ALL")
            {
                Command.CommandText += "and bus.bus_number= '" + Bus_number + "'";
            }

            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                cancle_count = Convert.ToInt32(Reader["count"]);
                return true;

            }
            return false;

        }

        public bool available()
        {
            Command = CommandBuilder("Select count(*) as count from booking as b left join bus_schedule as bs  on b.schedule_id = bs.id left join bus as bus on bs.b_id = bus.id where b.id>0 AND  b.date ='"+ from_date+"' and b.booking_status =1 and bs.b_id =@search");
            Command.Parameters.AddWithValue("@search", bus_id);
            
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                available_count = Convert.ToInt32(Reader["count"]);
                return true;

            }
            return false;

        }

       

    }
}