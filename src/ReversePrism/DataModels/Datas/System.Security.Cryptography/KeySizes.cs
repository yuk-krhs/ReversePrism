using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_minSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_maxSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_skipSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class KeySizes
    {
        public int                                      M_minSize                               { get; set; }
        public int                                      M_maxSize                               { get; set; }
        public int                                      M_skipSize                              { get; set; }

        public static KeySizes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeySizes();

            value.M_minSize                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D19826A0 0x10 M_minSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_maxSize                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D19826C0 0x14 M_maxSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skipSize                                = GetInt32(new IntPtr(p + 0x018)); // 0270D19826E0 0x18 M_skipSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
