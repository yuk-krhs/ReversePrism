using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 014 Max                                      ModelPrimitiveType int int int Int32
    // 018 ViewText                                 ModelPrimitiveType string string string String
    public partial class ProfileProgressCountViewModel : DataModel
    {
        public int                                      Count                                   { get; set; }
        public int                                      Max                                     { get; set; }
        public string                                   ViewText                                { get; set; }

        public static ProfileProgressCountViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressCountViewModel() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 Max                         ( ModelPrimitiveType int int int Int32 )
            value.ViewText                                  = GetString(new IntPtr(p + 0x018)); // 0x18 ViewText                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
