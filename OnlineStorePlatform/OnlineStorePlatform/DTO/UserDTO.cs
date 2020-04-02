﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.DTO
{
    public class UserDTO
    {
        public String email, userName, password;
        public UserDTO(String email, String password, String userName)
        {
            this.email = email;
            this.password = password;
            this.userName = userName;
        }
        public UserDTO() { }
    }
}