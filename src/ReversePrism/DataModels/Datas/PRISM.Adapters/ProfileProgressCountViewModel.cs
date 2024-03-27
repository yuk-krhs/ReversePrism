using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Max                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ViewText                                 000186672F10 ModelPrimitiveType string string string String
    public partial class ProfileProgressCountViewModel
    {
        public int                                      Count                                   { get; set; }
        public int                                      Max                                     { get; set; }
        public string                                   ViewText                                { get; set; }

        public static ProfileProgressCountViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressCountViewModel();

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D66957F8 0x10 Count                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x014)); // 0270D6695818 0x14 Max                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ViewText                                  = GetString(new IntPtr(p + 0x018)); // 0270D6695838 0x18 ViewText                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
