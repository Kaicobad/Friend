using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FriendManagement.DAL
{
    class clsFriendInformation:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Duration { get; set; }

        public bool Insert()
        {
            MyCommand = MycommandBuilder("insert into friendInformation (name,type,phone,address,facebook,duration) values (@name,@type,@phone,@address,@facebook,@duration)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@Type", Type);
            MyCommand.Parameters.AddWithValue("@phone", Phone);
            MyCommand.Parameters.AddWithValue("@address", Address);
            MyCommand.Parameters.AddWithValue("@facebook", Facebook);
            MyCommand.Parameters.AddWithValue("@duration", Duration);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MycommandBuilder("update friendInformation set name = @name, type = @type, phone = @phone, address = @address, facebook = @facebook, duration = @duration where id = @id");
            MyCommand.Parameters.AddWithValue("id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@Type", Type);
            MyCommand.Parameters.AddWithValue("@phone", Phone);
            MyCommand.Parameters.AddWithValue("@address", Address);
            MyCommand.Parameters.AddWithValue("@facebook", Facebook);
            MyCommand.Parameters.AddWithValue("@duration", Duration);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MycommandBuilder("delete from friendInformation where id = @id");
            MyCommand.Parameters.AddWithValue("id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelecById()
        {
            MyCommand = MycommandBuilder("select id, name, type, phone, address, facebook, duration from friendInformation where id = @id");
            MyCommand.Parameters.AddWithValue("id", Id);

            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Type = MyReader["type"].ToString();
                Phone = MyReader["phone"].ToString();
                Address = MyReader["address"].ToString();
                Facebook = MyReader["facebook"].ToString();
                Duration = MyReader["duration"].ToString();

                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            return ExecuteDataSet("select id, name, type, phone, address, facebook, duration from friendInformation");
        }
    }
}
