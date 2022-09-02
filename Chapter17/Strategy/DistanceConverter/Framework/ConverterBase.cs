﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Framework {
   public abstract class ConverterBase {

        public abstract bool IsMyUnit(string name);


        //メートルとの比率(この比率をかけるとメートルに変換できる)
        protected abstract double Ratio { get; }

        //距離の単位名（メートル、フィートなど）
        public abstract string UnitName { get;}

        //メートルからの変換
        public double FromMeter(double meter) {
            return meter / Ratio;
        }

        //メートルへの変換
        public double ToMeter(double feet) {
            return feet * Ratio;
        }

        public double ToMile(double mile) {
            return mile * Ratio;
        }

        public double ToKiroMeter(double kirometer) {
            return kirometer / Ratio;
        }

    }
}
