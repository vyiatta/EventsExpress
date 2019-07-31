﻿using EventsExpress.Db.Entities;
using EventsExpress.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsExpress.ViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<EventDto> Events { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
