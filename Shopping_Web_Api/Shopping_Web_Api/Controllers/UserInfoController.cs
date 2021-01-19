using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping_Model;
using IBLL;

namespace Shopping_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : BaseController
    {
        //注入构造函数
        private IUserInfoss _user;
        public UserInfoController(IUserInfoss user)
        {
            _user = user;
        }

        [Route("api/Login")]
        [HttpGet]
        //登录
        public List<UserInfo> Login(string name, string pwd, string pwd2)
        {
            return _user.GetUserInfos(name, pwd, pwd2);
        }

        [Route("api/Zhuce")]
        [HttpGet]
        //注册
        public int Zhuce(UserInfo u)
        {
            int list = _user.Add(u);
            return list;
        }

        [Route("api/Update")]
        [HttpGet]
        //修改密码账号密码
        public int Update(UserInfo u)
        {
            return _user.Update(u);
        }
    }
}
