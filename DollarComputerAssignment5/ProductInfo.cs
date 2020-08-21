using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputerAssignment5
{
    static class ProductInfo
    {    // create properties, these objects will be used in multiple forms;
        public static string productID { get; set; }
        public static string condition { get; set; }
        public static string cost { get; set; }
        public static string platform { get; set; }
        public static string os { get; set; }
        public static string manufacturer { get; set; }
        public static string model { get; set; }
        public static string memory { get; set; }
        public static string screenSize { get; set; }
        public static string hdd { get; set; }
        public static string cpuBrand { get; set; }
        public static string cpuNumber { get; set; }
        public static string gpuType { get; set; }
        public static string cpuType { get; set; }
        public static string cpuSpeed { get; set; }
        public static string webcam { get; set; }
        // create a constructor
        static ProductInfo()
        {
            ProductInfo.productID = "";
            ProductInfo.condition = "";
            ProductInfo.cost = "";
            ProductInfo.platform = "";
            ProductInfo.os = "";
            ProductInfo.manufacturer = "";
            ProductInfo.model = "";
            ProductInfo.memory = "";
            ProductInfo.screenSize = "";
            ProductInfo.hdd = "";
            ProductInfo.cpuBrand = "";
            ProductInfo.cpuNumber = "";
            ProductInfo.gpuType = "";
            ProductInfo.cpuType = "";
            ProductInfo.cpuSpeed = "";
            ProductInfo.webcam = "";
        }
       
    }
}
