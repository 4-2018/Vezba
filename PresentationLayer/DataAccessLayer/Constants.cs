﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    class Constants
    {
        public static string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantDB;" +
            "Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
