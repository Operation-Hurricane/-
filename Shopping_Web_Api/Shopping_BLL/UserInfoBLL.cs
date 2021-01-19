using System;
using Shopping_Model;
using Shopping_DAL;
using System.Data;
using System.Data.SqlClient;
using IBLL;
using System.Collections.Generic;

namespace Shopping_BLL
{
    public class UserInfoBLL : IUserInfoss
    {
        UserInfoDAL dal = new UserInfoDAL();
        //注册
        public int Add(UserInfo u)
        {
            return dal.Add(u);
        }
        //登陆
        public List<UserInfo> GetUserInfos(string name, string pwd, string pwd2)
        {
            return dal.GetUserInfos(name, pwd, pwd2);
        }

        //修改账号信息
        public int Update(UserInfo u)
        {
            return dal.Update(u);
        }
    }
}
