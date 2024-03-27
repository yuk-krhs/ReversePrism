using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 LingerTime                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LingerOption
    {
        public bool                                     Enabled                                 { get; set; }
        public int                                      LingerTime                              { get; set; }

        public static LingerOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LingerOption();

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0270D7AEC3A0 0x10 Enabled                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LingerTime                                = GetInt32(new IntPtr(p + 0x014)); // 0270D7AEC3C0 0x14 LingerTime                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
