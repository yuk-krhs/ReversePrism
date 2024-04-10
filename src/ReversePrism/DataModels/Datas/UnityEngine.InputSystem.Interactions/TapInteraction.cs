using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 014 PressPoint                               000186666050 ModelPrimitiveType float float float Single
    // 018 M_TapStartTime                           0001865C2950 ModelPrimitiveType double double double Double
    public partial class TapInteraction : DataModel
    {
        public float                                    Duration                                { get; set; }
        public float                                    PressPoint                              { get; set; }
        public double                                   M_TapStartTime                          { get; set; }

        public static TapInteraction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TapInteraction() { Pointer= p0 };

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0246678E3680 0x10 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.PressPoint                                = GetSingle(new IntPtr(p + 0x014)); // 0246678E36A0 0x14 PressPoint                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_TapStartTime                            = GetDouble(new IntPtr(p + 0x018)); // 0246678E36C0 0x18 M_TapStartTime              ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
