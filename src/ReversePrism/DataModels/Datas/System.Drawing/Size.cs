using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Width                                    ModelPrimitiveType int int int Int32
    // 014 Height                                   ModelPrimitiveType int int int Int32
    public partial class Size : DataModel
    {
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }

        public static Size? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Size() { Pointer= p0 };

            value.Width                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Height                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
