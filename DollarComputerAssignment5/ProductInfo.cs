using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputerAssignment5
{
    static class ProductInfo
    {
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

        static void setProductInfo(string productID, string condition, string cost, string platform, string os,
            string manufacturer, string model, string memory, string screenSize, string hdd, string cpuBrand,
            string cpuNumber, string gpuType, string cpuType, string cpuSpeed, string webcam)
        {
            ProductInfo.productID = productID;
            ProductInfo.condition = condition;
            ProductInfo.cost = cost;
            ProductInfo.platform = platform;
            ProductInfo.os = os;
            ProductInfo.manufacturer = manufacturer;
            ProductInfo.model = model;
            ProductInfo.memory = memory;
            ProductInfo.screenSize = screenSize;
            ProductInfo.hdd = hdd;
            ProductInfo.cpuBrand = cpuBrand;
            ProductInfo.cpuNumber = cpuNumber;
            ProductInfo.gpuType = gpuType;
            ProductInfo.cpuType = cpuType;
            ProductInfo.cpuSpeed = cpuSpeed;
            ProductInfo.webcam = webcam;
        }
    }
}
