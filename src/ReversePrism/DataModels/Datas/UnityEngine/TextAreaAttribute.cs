using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MinLines                                 0001865F4940 ModelPrimitiveType int int int Int32
    // 014 MaxLines                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class TextAreaAttribute
    {
        public int                                      MinLines                                { get; set; }
        public int                                      MaxLines                                { get; set; }

        public static TextAreaAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextAreaAttribute();

            value.MinLines                                  = GetInt32(new IntPtr(p + 0x010)); // 0270068B8580 0x10 MinLines                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.MaxLines                                  = GetInt32(new IntPtr(p + 0x014)); // 0270068B85A0 0x14 MaxLines                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
