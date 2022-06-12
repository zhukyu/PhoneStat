using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStat
{
    public class Phone
    {
        internal int ID { get; set; }
        internal string name { get; set; }
        internal string brand { get; set; }
        internal string chipset { get; set; }
        internal string RAM { get; set; }
        internal string ROM { get; set; }
        internal string hasSDCard { get; set; }
        internal string battery { get; set; }
        internal string resolution { get; set; }
        internal string displaySize { get; set; }
        internal string refreshRate { get; set; }
        internal string cameraResolution { get; set; }
        internal string frontCameraResolution  { get; set; }
        internal Image image { get; set; }

        public Phone(int ID, string name, string brand, string chipset, string RAM, string ROM, string hasSDCard, string battery, string resolution, string displaySize, string refreshRate, string cameraResolution, string frontCameraResolution, Image image)
        {
            this.ID = ID;
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
