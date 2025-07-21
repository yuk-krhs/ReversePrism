using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType int int int Int32
    // 014 Y                                        ModelPrimitiveType int int int Int32
    // 018 Width                                    ModelPrimitiveType int int int Int32
    // 01C Height                                   ModelPrimitiveType int int int Int32
    public partial class Rectangle : DataModel
    {
        public int                                      X                                       { get; set; }
        public int                                      Y                                       { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }

        public static Rectangle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Rectangle() { Pointer= p0 };

            value.X                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType int int int Int32 )
            value.Y                                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelPrimitiveType int int int Int32 )
            value.Width                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Height                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
