using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Costs                                    ModelEnumType float4 float4 float4 Int32
    // 020 Data                                     ModelEnumType int4 int4 int4 Int32
    public partial class ExCostSortedList4 : DataModel
    {
        public float4                                   Costs                                   { get; set; }
        public int4                                     Data                                    { get; set; }

        public static ExCostSortedList4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExCostSortedList4() { Pointer= p0 };

            value.Costs                                     = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 Costs                       ( ModelEnumType float4 float4 float4 Int32 )
            value.Data                                      = (int4)GetInt32(new IntPtr(p + 0x020)); // 0x20 Data                        ( ModelEnumType int4 int4 int4 Int32 )

            return value;
        }
    }
}
