using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865C9B00 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 014 DurationMs                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 DelayMs                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 easingCurve                              Func`2<float, float> IL2CPP_TYPE_GENERICINST
    public partial class ComputedTransitionProperty : DataModel
    {
        public StylePropertyId                          Id                                      { get; set; }
        public int                                      DurationMs                              { get; set; }
        public int                                      DelayMs                                 { get; set; }

        public static ComputedTransitionProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComputedTransitionProperty() { Pointer= p0 };

            value.Id                                        = (StylePropertyId)GetInt32(new IntPtr(p + 0x010)); // 0245A67AD250 0x10 Id                          ( 0001865C9B00 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.DurationMs                                = GetInt32(new IntPtr(p + 0x014)); // 0245A67AD270 0x14 DurationMs                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DelayMs                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A67AD290 0x18 DelayMs                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
