using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Year                                     ModelPrimitiveType int int int Int32
    // 018 Offset                                   ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 020 Rule                                     ModelClassType AdjustmentRule AdjustmentRule AdjustmentRule Pointer
    public partial class OffsetAndRule : DataModel
    {
        public int                                      Year                                    { get; set; }
        public TimeSpan                                 Offset                                  { get; set; }
        public AdjustmentRule?                          Rule                                    { get; set; }

        public static OffsetAndRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OffsetAndRule() { Pointer= p0 };

            value.Year                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Year                        ( ModelPrimitiveType int int int Int32 )
            value.Offset                                    = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0x18 Offset                      ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Rule                                      = GetObject<AdjustmentRule>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdjustmentRule.FromPointer); // 0x20 Rule                        ( ModelClassType AdjustmentRule AdjustmentRule AdjustmentRule Pointer )

            return value;
        }
    }
}
