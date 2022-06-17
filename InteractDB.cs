using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStat
{
    internal class InteractDB
    {
        private static byte[] converImgToByte(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }
        private static Image ByteToImg(string byteString)
        {
            if (byteString != "")
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            else
            {
                Image image = Properties.Resources._65756;
                return image;
            }
        }
        public static int InsertData(Phone phone)
        {
            SqlConnection conn = new SqlConnection(Program.conStr);
            conn.Open();
            string convertedByteStr = "";
            if(phone.image != null)
            {
                convertedByteStr = Convert.ToBase64String(converImgToByte(phone.image));
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Phone(name, brand, chipset, RAM, ROM, hasSDCard, battery, resolution, displaySize, refreshRate, cameraResolution, frontCameraResolution, image) " +
                "values (N'" + phone.name + "',N'" + phone.brand + "', N'" + phone.chipset + "','" + phone.RAM + "', '" + phone.ROM + "','" + phone.hasSDCard + "'" + ",'" +
                phone.battery + "',N'" + phone.resolution + "','" + phone.displaySize + "','" + phone.refreshRate + "','" + phone.cameraResolution + "', '" + phone.frontCameraResolution + "', '" + convertedByteStr + "')";
            cmd.Connection = conn;
            return cmd.ExecuteNonQuery();
        }
        public static int UpdateData(Phone phone)
        {
            SqlConnection conn = new SqlConnection(Program.conStr);
            conn.Open();
            string convertedByteStr = "";
            if (phone.image != null)
            {
                convertedByteStr = Convert.ToBase64String(converImgToByte(phone.image));
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Phone " +
                $"set name = N'{phone.name}', brand = N'{phone.brand}', chipset = N'{phone.chipset}', RAM = N'{phone.RAM}', ROM = N'{phone.ROM}', hasSDCard = N'{phone.hasSDCard}', battery = N'{phone.battery}', resolution = N'{phone.resolution}'," +
                $"displaySize = N'{phone.displaySize}', refreshRate = N'{phone.refreshRate}', cameraResolution = N'{phone.cameraResolution}', frontCameraResolution = N'{phone.frontCameraResolution}', image = '{convertedByteStr}' " +
                $"where ID = {phone.ID}";
            cmd.Connection = conn;
            return cmd.ExecuteNonQuery();
        }
        public static int DeleteData(int ID)
        {
            SqlConnection conn = new SqlConnection(Program.conStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Phone " +
                $"where ID = {ID}";
            cmd.Connection = conn;
            return cmd.ExecuteNonQuery();
        }
        public static List<Phone> GetData()
        {
            List<Phone> phoneList = new List<Phone>();
            SqlConnection conn = new SqlConnection(Program.conStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Phone", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                Image image = ByteToImg(rd.GetString(13));
                Phone phone = new Phone(
                    rd.GetInt32(0),
                    rd.GetString(1),
                    rd.GetString(2),
                    rd.GetString(3),
                    rd.GetString(4),
                    rd.GetString(5),
                    rd.GetString(6),
                    rd.GetString(7),
                    rd.GetString(8),
                    rd.GetString(9),
                    rd.GetString(10),
                    rd.GetString(11),
                    rd.GetString(12),
                    image
                );
                phoneList.Add(phone);
            }
            return phoneList;
        }

        public static List<Phone> SearchPhone(string temp)
        {
            List<Phone> phoneList = new List<Phone>();
            SqlConnection conn = new SqlConnection(Program.conStr);
            conn.Open();
            string query = "select * from Phone where " +
                $"name like '%{temp}%'"; 
          
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Image image = ByteToImg(rd.GetString(13));
                Phone phone = new Phone(
                    rd.GetInt32(0),
                    rd.GetString(1),
                    rd.GetString(2),
                    rd.GetString(3),
                    rd.GetString(4),
                    rd.GetString(5),
                    rd.GetString(6),
                    rd.GetString(7),
                    rd.GetString(8),
                    rd.GetString(9),
                    rd.GetString(10),
                    rd.GetString(11),
                    rd.GetString(12),
                    image
                );
                phoneList.Add(phone);
            }
            return phoneList;
        }
    }
}
