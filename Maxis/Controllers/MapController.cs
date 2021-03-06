﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Maxis.Database;
using Newtonsoft.Json;
using Maxis.Infrastructure.Repositories;
using Maxis.Infrastructure.Repositories.Abstract;
using Maxis.Services.Abstract;
using Maxis.Services;
using Maxis.ViewModels;
using System.Data.Spatial;

namespace Maxis.Controllers
{
    public class MapController : Controller
    {
        private readonly IMapService _mapService;

        public MapController(IMapService mapService)
        {
            _mapService = mapService;
        }


        // GET: MAP/NEtypes
        //show NENames for NENames dropdown based on lrd
        public JsonResult NEtypes(PointViewModel model)
        {
            return Json(_mapService.getNETypes(DbGeography.FromText(model.SearchPoint), model.Range), JsonRequestBehavior.AllowGet);
        }


        // GET: Map/LRD
        //show LRD 
        public JsonResult LRD(PointViewModel model)
        {
            return Json(_mapService.getLRDValues(DbGeography.FromText(model.SearchPoint), model.Range), JsonRequestBehavior.AllowGet);
        }

        // GET: Map/LRDNearby
        //show LRD for NEtypes dropdown
        public JsonResult LRDNearby(PointViewModel model)
        {
            return Json(_mapService.getLRDRangeValues(DbGeography.FromText(model.SearchPoint), model.Range), JsonRequestBehavior.AllowGet);
        }

        
        // GET: Map/CableTypes
        //show cabletypes for cable type dropdown
        public JsonResult CableTypes()
        {
            return Json(_mapService.getCableTypes(), JsonRequestBehavior.AllowGet);
        }

        // GET: Map/CableDetails
        //show cablenames, geodata for cable names dropdown based on cable type
        public JsonResult CableDetails(string cableType)
        {
            return Json(_mapService.getCableDetails(cableType), JsonRequestBehavior.AllowGet);
        }

        // GET: Map/Building/nename(NEname)
        //Show buildings based on nename
        public JsonResult Building(string NEName)
        {
            return Json(_mapService.getBuildingDetails(NEName), JsonRequestBehavior.AllowGet);
        }


        // GET: Map/Threshold/nename(NE name)
        //Show threshold info on tower click
        public JsonResult Threshold(string NEName)
        {
            return Json(_mapService.getThresholdDetails(NEName), JsonRequestBehavior.AllowGet);
        }

    }
}
