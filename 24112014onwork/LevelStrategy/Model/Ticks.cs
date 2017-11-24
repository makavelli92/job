using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelStrategy
{
    public class Ticks : Data
    {
        public override string Name { get; set; }

        public override int TimeFrame { get; set; }

        public override string ClassCod { get; set; }

        public override List<DateTime> Time { get; set; }

        public override List<double> Close { get; set; }

        public override List<double> Volume { get; set; }

        public override int Count { get; set; }

        public override string ProcessType { get; set; } = "Accept";

        public List<DateTime> timeToAction { get; set; }

        public void CalculateListMinuts()
        {
            if (this.timeToAction.Count == 0)
            {
                if (TimeFrame < 60)
                {
                    DateTime time = DateTime.Now.Date.AddHours(10).AddMinutes(-5);
                    DateTime fine = DateTime.Now.Date.AddHours(23).AddMinutes(50);

                    while (time < fine)
                    {
                        time = time.AddMinutes(5);
                        if (time <= DateTime.Now.Date.AddHours(18).AddMinutes(45) || time >= DateTime.Now.Date.AddHours(19))
                        {
                            timeToAction.Add(time);
                        }
                    }
                }
            }
            timeToAction.RemoveAll(x => x < DateTime.Now);
        }
    }
}
