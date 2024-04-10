using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_XMin                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_YMin                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Width                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_Height                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RectInt : DataModel
    {
        public int                                      M_XMin                                  { get; set; }
        public int                                      M_YMin                                  { get; set; }
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }

        public static RectInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectInt() { Pointer= p0 };

            value.M_XMin                                    = GetInt32(new IntPtr(p + 0x010)); // 0245A2434F98 0x10 M_XMin                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_YMin                                    = GetInt32(new IntPtr(p + 0x014)); // 0245A2434FB8 0x14 M_YMin                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Width                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A2434FD8 0x18 M_Width                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x01C)); // 0245A2434FF8 0x1C M_Height                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
