﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Maxis.Database;
using Maxis.Services.Abstract;
using Maxis.ViewModels;

namespace Maxis.Controllers
{
    public class ExportController : Controller
    {
        private readonly IExportService _exportService;

        public ExportController(IExportService exportService)
        {
            _exportService = exportService;
        }
        // GET: Export
        public bool ExportExcel(List<UserViewModel> model)
        {
            return _exportService.ExportToExcel(model);
        }

        // GET: Export/Details/5
        public bool ExportPDF(List<UserViewModel> model)
        {
            return _exportService.ExportToPDF(model);
        }        
    }
}
