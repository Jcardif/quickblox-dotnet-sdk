﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms.QbChat.Repository
{
    public class UserTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; internal set; }
		public int UserId { get; internal set; }
		public string FullName { get; internal set; }
		public string PhotoUrl { get; internal set; }
        public long PhotoId { get; internal set; }
    }
}
