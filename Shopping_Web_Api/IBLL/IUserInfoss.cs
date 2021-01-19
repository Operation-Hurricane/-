using System;
using System.Collections.Generic;
using System.Text;
using Shopping_Model;


namespace IBLL
{
    public interface IUserInfoss
    {
        //登陆
        List<UserInfo> GetUserInfos(string name, string pwd, string pwd2);

        //注册
        int Add(UserInfo u);

        //修改账号密码
        int Update(UserInfo u);
    }
}
