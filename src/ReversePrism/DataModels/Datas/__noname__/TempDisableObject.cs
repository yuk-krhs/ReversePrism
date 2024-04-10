using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Parent                                   00018672A1B0 ModelClassType EnableCounter EnableCounter EnableCounter Pointer
    public partial class TempDisableObject : DataModel
    {
        public int                                      Count                                   { get; set; }
        public EnableCounter?                           Parent                                  { get; set; }

        public static TempDisableObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TempDisableObject() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 024660B9B568 0x10 Count                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Parent                                    = GetObject<EnableCounter>(new IntPtr(p + 0x018), ReversePrism.DataModels.EnableCounter.FromPointer); // 024660B9B588 0x18 Parent                      ( 00018672A1B0 ModelClassType EnableCounter EnableCounter EnableCounter Pointer )

            return value;
        }
    }
}
