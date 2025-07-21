using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_skin                                   ModelClassType UISkin UISkin UISkin Pointer
    // 028 M_skinVersion                            ModelPrimitiveType int int int Int32
    public partial class SkinnedWindow : DataModel
    {
        public UISkin?                                  M_skin                                  { get; set; }
        public int                                      M_skinVersion                           { get; set; }

        public static SkinnedWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkinnedWindow() { Pointer= p0 };

            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISkin.FromPointer); // 0x20 M_skin                      ( ModelClassType UISkin UISkin UISkin Pointer )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_skinVersion               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
