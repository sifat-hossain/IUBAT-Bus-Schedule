using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity.DAL
{
    public class Bus:Base
    {
        public int Id { get; set; }

        public string Bus_Number { get; set; }

        public string Number_Plate { get; set; }

        public int Max_Capacity { get; set; }


        public bool Insert()
        {
            Command = CommandBuilder("insert into bus(bus_number, number_plate, max_capacity) values(@bus_number, @number_plate, @max_capacity)");

            Command.Parameters.AddWithValue("@bus_number", Bus_Number);
            Command.Parameters.AddWithValue("@number_plate", Number_Plate);
            Command.Parameters.AddWithValue("@max_capacity", Max_Capacity);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update bus set bus_number = @bus_number, number_plate= @number_plate, max_capacity=@max_capacity where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@bus_number", Bus_Number);
            Command.Parameters.AddWithValue("@number_plate", Number_Plate);
            Command.Parameters.AddWithValue("@max_capacity", Max_Capacity);


            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from bus where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, bus_number, number_plate, max_capacity from bus where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Bus_Number = Reader["bus_number"].ToString();
                Number_Plate = Reader["number_plate"].ToString();
                Max_Capacity = (int)Reader["max_capacity"];

                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, bus_number, number_plate, max_capacity from bus where id>0");

            if (Bus_Number != null && Bus_Number != "")
            {
                Command.CommandText += " and bus_number like @search or number_plate like @search";
                Command.Parameters.AddWithValue("@search", "%" + Bus_Number + "%");
            }


            return ExecuteDataSet(Command);
        }
    }
}