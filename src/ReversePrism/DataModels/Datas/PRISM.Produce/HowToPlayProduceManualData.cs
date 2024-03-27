using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Datas                                    000185D252A8 ModelClassListType List`1<HowToPlayProduceManual> List`1<HowToPlayProduceManual> List<HowToPlayProduceManual> Pointer
    public partial class HowToPlayProduceManualData
    {
        public List<HowToPlayProduceManual>?            Datas                                   { get; set; }

        public static HowToPlayProduceManualData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayProduceManualData();

            value.Datas                                     = GetObjectList<HowToPlayProduceManual>(new IntPtr(p + 0x018), ReversePrism.DataModels.HowToPlayProduceManual.FromPointer); // 0270D59FC3A8 0x18 Datas                       ( 000185D252A8 ModelClassListType List`1<HowToPlayProduceManual> List`1<HowToPlayProduceManual> List<HowToPlayProduceManual> Pointer )

            return value;
        }
    }
}
