using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryController
{
    [Serializable]
    public class Factory
    {
        int CurrentMaxTimeBuying;
        int CurrentMaxTimeCreating;
        int CurrentMaxTimeRealization;
        public int Manufactories { get; set; }
        public int Budget { get; set; }
        public int MaxSizeOfStorage { get; set; }
        public int CurrentNumberOfProduction { get; set; }
        public int CurrentNumberOfRawMaterial { get; set; }


        public Factory()
        {
            Manufactories = 1;
            Budget = 10000;
            MaxSizeOfStorage = 100;
            CurrentNumberOfProduction = 0;
            CurrentNumberOfRawMaterial = 0;
        }

        public void BuyingRaw()
        {
            if ((CurrentNumberOfRawMaterial + CurrentNumberOfProduction + ((MaxSizeOfStorage / 100) * 5)) <= MaxSizeOfStorage)
            {
                if (Budget > 0)
                {
                    CurrentMaxTimeBuying = 50000; //10000ms is time of buying one raw material
                    Budget -= 1;
                    Thread.Sleep(CurrentMaxTimeBuying);
                    if ((CurrentNumberOfRawMaterial + CurrentNumberOfProduction + ((MaxSizeOfStorage / 100) * 5)) > MaxSizeOfStorage)
                    {
                        Budget -= 1000; //payments for expansion of storage
                        MaxSizeOfStorage += 100;
                    }
                    CurrentNumberOfRawMaterial += (MaxSizeOfStorage / 100) * 5;
                }
            }
        }

        public void CreatingProduct()
        {
            if ((CurrentNumberOfRawMaterial + CurrentNumberOfProduction + ((MaxSizeOfStorage / 100) * 5)) < MaxSizeOfStorage)
            {
                if (CurrentNumberOfRawMaterial > 0)
                {
                    CurrentMaxTimeCreating = 60000; //60000ms is timme of creating one product
                    Budget -= 5 * Manufactories;
                    CurrentNumberOfRawMaterial -= 5;
                    Thread.Sleep(CurrentMaxTimeCreating / Manufactories);
                    CurrentNumberOfProduction += 1;
                }
            }
        }

        public void RealizationProduct()
        {
            if (CurrentNumberOfProduction > 0)
            {
                CurrentMaxTimeRealization = 20000; //20000ms is timme of creating one product
                CurrentNumberOfProduction -= 1;
                Thread.Sleep(CurrentMaxTimeRealization);
                Budget += 800;
            }
        }

    }
}
