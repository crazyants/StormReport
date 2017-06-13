﻿using StormReport.Model;
using System;

namespace StormReport
{
    public class ExportableAddtionalTextAttribute : Attribute
    {
        public string Description { get; set; }
        public AdditionalTextEnum Direction { get; set; }
        public ExportableAddtionalTextAttribute(string description, AdditionalTextEnum direction)
        {
            this.Description = description;
            this.Direction = direction;
        }
    }
}