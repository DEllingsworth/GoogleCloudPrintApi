﻿using GoogleCloudPrintApi.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GoogleCloudPrintApi.Infrastructures;

namespace GoogleCloudPrintApi.Models.Printer
{
    public class PrinterResponse<T>: Response<T> where T: IRequest
    {
        [JsonProperty]
        public Printer Printer { get; private set; }
    }
}
