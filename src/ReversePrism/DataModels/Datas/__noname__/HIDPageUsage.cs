using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Page                                     ModelEnumType UsagePage UsagePage UsagePage Int32
    // 014 Usage                                    ModelPrimitiveType int int int Int32
    public partial class HIDPageUsage : DataModel
    {
        public UsagePage                                Page                                    { get; set; }
        public int                                      Usage                                   { get; set; }

        public static HIDPageUsage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDPageUsage() { Pointer= p0 };

            value.Page                                      = (UsagePage)GetInt32(new IntPtr(p + 0x010)); // 0x10 Page                        ( ModelEnumType UsagePage UsagePage UsagePage Int32 )
            value.Usage                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Usage                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
