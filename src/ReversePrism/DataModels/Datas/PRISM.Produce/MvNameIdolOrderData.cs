using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Datas                                    ModelClassListType List`1<MvNameIdolOrder> List`1<MvNameIdolOrder> List<MvNameIdolOrder> Pointer
    public partial class MvNameIdolOrderData : DataModel
    {
        public List<MvNameIdolOrder>?                   Datas                                   { get; set; }

        public static MvNameIdolOrderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvNameIdolOrderData() { Pointer= p0 };

            value.Datas                                     = GetObjectList<MvNameIdolOrder>(new IntPtr(p + 0x018), ReversePrism.DataModels.MvNameIdolOrder.FromPointer); // 0x18 Datas                       ( ModelClassListType List`1<MvNameIdolOrder> List`1<MvNameIdolOrder> List<MvNameIdolOrder> Pointer )

            return value;
        }
    }
}
