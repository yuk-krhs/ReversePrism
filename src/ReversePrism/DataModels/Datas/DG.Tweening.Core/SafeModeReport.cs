using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotMissingTargetOrFieldErrors            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 TotCallbackErrors                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 TotStartupErrors                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C TotUnsetErrors                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SafeModeReport : DataModel
    {
        public int                                      TotMissingTargetOrFieldErrors           { get; set; }
        public int                                      TotCallbackErrors                       { get; set; }
        public int                                      TotStartupErrors                        { get; set; }
        public int                                      TotUnsetErrors                          { get; set; }

        public static SafeModeReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeModeReport() { Pointer= p0 };

            value.TotMissingTargetOrFieldErrors             = GetInt32(new IntPtr(p + 0x010)); // 0245A439FF70 0x10 TotMissingTargetOrFieldErrors ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotCallbackErrors                         = GetInt32(new IntPtr(p + 0x014)); // 0245A439FF90 0x14 TotCallbackErrors           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotStartupErrors                          = GetInt32(new IntPtr(p + 0x018)); // 0245A439FFB0 0x18 TotStartupErrors            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotUnsetErrors                            = GetInt32(new IntPtr(p + 0x01C)); // 0245A439FFD0 0x1C TotUnsetErrors              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
