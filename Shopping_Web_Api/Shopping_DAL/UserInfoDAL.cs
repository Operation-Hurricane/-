using System;
using System.Collections.Generic;
using System.Text;
using Shopping_Model;
using IBLL;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Shopping_DAL
{
    public class UserInfoDAL : IUserInfoss
    {
        //注册
        public int Add(UserInfo u)
        {
            string sql = $"insert into  UserInfo  values ('{u.User_Name}','{u.User_Pwd}','{u.User_State}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        //登陆
        public List<UserInfo> GetUserInfos(string name, string pwd, string pwd2)
        {

            string sql = $"select * from UserInfo values User_Name and User_Pwd and User_Pwd2";
            return DBHelper.GetList<UserInfo>(sql);
        }

        //修改账号密码
        public int Update(UserInfo u)
        {
            string sql = $"Update UserInfo set User_Name={u.User_Name},User_Pwd={u.User_Pwd},User_Pwd={u.User_Pwd2}，User_Phone={u.User_Phone},User_State={u.User_State} ";
            return DBHelper.ExecuteNonQuery(sql);
        }


    }
}
