using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_UWP.Primary.Data;

namespace UTS_UWP.Primary.Models
{
    public class MainModel
    {
        public List<MainData> mainData { get; set; }

        public MainModel()
        {
            mainData = new List<MainData>()
            {
                    new MainData() { sData="Data 1", iData=1 },
                    new MainData() { sData="Data 2", iData=2 },
                    new MainData() { sData="Data 3", iData=3 }
            };
        }

        public void Add(MainData data)
        {
            if (!mainData.Contains(data))
            {
                mainData.Add(data);
            }
        }

        public void Delete(MainData data)
        {
            if (mainData.Contains(data))
            {
                mainData.Remove(data);
            }
        }
    }
}
