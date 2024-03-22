﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
   public class EntryModel
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FullEntry
        {
            get
            {
                return $"{ ID } { Username } { Password }";
            }
        }
    }
}