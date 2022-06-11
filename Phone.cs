using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStat
{
    public class Phone
    {
        int ID { get; set; }
        string name { get; set; }
        string brand { get; set; }
        string chipset { get; set; }
        int RAM { get; set; }
        int ROM { get; set; }
        bool hasSDCard { get; set; }
        int battery { get; set; }
        string resolution { get; set; }
        float displaySize { get; set; }
        int refreshRate { get; set; }
        int cameraResolution { get; set; }
        int frontCameraResolution  { get; set; }
        Image image { get; set; }

        public Phone(int iD, string name, string brand, string chipset, int RAM, int ROM, bool hasSDCard, int battery, string resolution, int displaySize, int refreshRate, int cameraResolution, int frontCameraResolution, Image image)
        {
            ID = iD;
            this.name = name;
            this.brand = brand;
            this.chipset = chipset;
            this.RAM = RAM;
            this.ROM = ROM;
            this.hasSDCard = hasSDCard;
            this.battery = battery;
            this.resolution = resolution;
            this.displaySize = displaySize;
            this.refreshRate = refreshRate;
            this.cameraResolution = cameraResolution;
            this.frontCameraResolution = frontCameraResolution;
            this.image = image;
        }
    }
}
