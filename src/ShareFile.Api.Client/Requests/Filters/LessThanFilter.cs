﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareFile.Api.Client.Requests.Filters
{
    public class LessThanFilter : IFilter
    {
        public string PropertyName { get; set; }
        public Filter.Value Value { get; set; }

        public LessThanFilter(string propertyName, string value)
            : this(propertyName, new Filter.Value(value))
        { }

        public LessThanFilter(string propertyName, Filter.Value value)
        {
            PropertyName = propertyName;
            Value = value;
        }

        public override string ToString()
        {
            return string.Format("{0} lt {1}", PropertyName, Value);
        }
    }
}
