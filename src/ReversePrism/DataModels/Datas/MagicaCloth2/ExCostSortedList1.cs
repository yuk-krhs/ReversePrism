using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cost                                     ModelPrimitiveType float float float Single
    // 014 Data                                     ModelPrimitiveType int int int Int32
    public partial class ExCostSortedList1 : DataModel
    {
        public float                                    Cost                                    { get; set; }
        public int                                      Data                                    { get; set; }

        public static ExCostSortedList1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExCostSortedList1() { Pointer= p0 };

            value.Cost                                      = GetSingle(new IntPtr(p + 0x010)); // 0x10 Cost                        ( ModelPrimitiveType float float float Single )
            value.Data                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Data                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
