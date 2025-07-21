using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Width                                  ModelPrimitiveType int int int Int32
    // 014 M_Height                                 ModelPrimitiveType int int int Int32
    // 018 M_RefreshRate                            ModelEnumType RefreshRate RefreshRate RefreshRate Int32
    public partial class Resolution : DataModel
    {
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }
        public RefreshRate                              M_RefreshRate                           { get; set; }

        public static Resolution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Resolution() { Pointer= p0 };

            value.M_Width                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Width                     ( ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Height                    ( ModelPrimitiveType int int int Int32 )
            value.M_RefreshRate                             = (RefreshRate)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_RefreshRate               ( ModelEnumType RefreshRate RefreshRate RefreshRate Int32 )

            return value;
        }
    }
}
