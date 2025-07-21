using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotMissingTargetOrFieldErrors            ModelPrimitiveType int int int Int32
    // 014 TotCallbackErrors                        ModelPrimitiveType int int int Int32
    // 018 TotStartupErrors                         ModelPrimitiveType int int int Int32
    // 01C TotUnsetErrors                           ModelPrimitiveType int int int Int32
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

            value.TotMissingTargetOrFieldErrors             = GetInt32(new IntPtr(p + 0x010)); // 0x10 TotMissingTargetOrFieldErrors ( ModelPrimitiveType int int int Int32 )
            value.TotCallbackErrors                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 TotCallbackErrors           ( ModelPrimitiveType int int int Int32 )
            value.TotStartupErrors                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotStartupErrors            ( ModelPrimitiveType int int int Int32 )
            value.TotUnsetErrors                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C TotUnsetErrors              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
