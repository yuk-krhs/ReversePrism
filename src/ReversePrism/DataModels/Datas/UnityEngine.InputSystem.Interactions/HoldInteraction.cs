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
    // 018 M_TimePressed                            0001865C2950 ModelPrimitiveType double double double Double
    public partial class HoldInteraction : DataModel
    {
        public float                                    Duration                                { get; set; }
        public float                                    PressPoint                              { get; set; }
        public double                                   M_TimePressed                           { get; set; }

        public static HoldInteraction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HoldInteraction() { Pointer= p0 };

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0246678E28E8 0x10 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.PressPoint                                = GetSingle(new IntPtr(p + 0x014)); // 0246678E2908 0x14 PressPoint                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_TimePressed                             = GetDouble(new IntPtr(p + 0x018)); // 0246678E2928 0x18 M_TimePressed               ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
