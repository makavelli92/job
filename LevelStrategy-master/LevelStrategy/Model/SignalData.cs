﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelStrategy.Model
{
    public class SignalData
    {
        public SignalData(int rowNumb, string signalType, DateTime bsy, DateTime bpy1, DateTime bpy2, double level, double lyft, double cancelSignal)
        {
            RowNumber = rowNumb;
            SignalType = signalType;
            DateBsy = bsy;
            DateBpy1 = bpy1;
            DateBpy2 = bpy2;
            Level = level;
            Lyft = lyft;
            CancelSignal = cancelSignal;
        }
        public int RowNumber { get; set; }

        public string SignalType { get; set; }

        public DateTime DateBsy { get; set; }

        public DateTime DateBpy1 { get; set; }

        public DateTime DateBpy2 { get; set; }

        public double Level { get; set; }

        public double Lyft { get; set; }

        public double CancelSignal { get; set; }
    }
}
