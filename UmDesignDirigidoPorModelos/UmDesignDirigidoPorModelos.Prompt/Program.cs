using System;
using System.Collections.Generic;
using UmDesignDirigidoPorModelos.Domain.Models;
using UmDesignDirigidoPorModelos.AppService.Services;
using UmDesignDirigidoPorModelos.Data.Repositories;
using UmDesignDirigidoPorModelos.Utils;

namespace UmDesignDirigidoPorModelos.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            var aFile = "Test1,Test2";
            var netListImportService = new NetListImportService();
            
            var nets = netListImportService.Read(aFile);
            var netRepository = new NetRepository();
            netRepository.AddAll(nets);

            var buses = InferredBusFactory.GroupIntoBuses(nets);
            var busRepository = new BusRepository();
            busRepository.AddAll(buses);
        }
    }
}