﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private Memento memento;
        public Memento Memento { get; set; }
    }
}
