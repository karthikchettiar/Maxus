﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maxis.Database;
using Maxis.ViewModels;
using System.Data.Spatial;

namespace Maxis.Services.Abstract
{
    public interface IMapService
    {
        List<string> getNETypes(DbGeography searchPoint, int range);

        List<string> getLRDValues(DbGeography searchPoint, int range);

        List<string> getLRDRangeValues(DbGeography searchPoint, int range);        

        List<string> getCableTypes();

        List<CableViewModel> getCableDetails(string cableType);

        List<BuildingViewModel> getBuildingDetails(string NEName);

        List<ThresholdViewModel> getThresholdDetails(string NEName);

    }
}
