﻿using SQLite.Net.Attributes;
using System;

namespace XamarinForms.QbChat.Repository
{
    public class MessageTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string MessageId { get; set; }
        public string Text { get; set; }
        public string DialogId { get; set; }
        public long DateSent { get; set; }

        public int RecepientId { get; set; }
        public int SenderId { get; set; }
        public bool IsRead { get; set; }

		public string RecepientFullName { get; set; }
		public string RecepientImage { get; set; }
    }
}
