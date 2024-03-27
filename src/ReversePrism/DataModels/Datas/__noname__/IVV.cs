using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 I                                        0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Mv                                       0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 Gv                                       0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C Wv                                       0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class IVV
    {
        public int                                      I                                       { get; set; }
        public Vector3                                  Mv                                      { get; set; }
        public Vector3                                  Gv                                      { get; set; }
        public Vector3                                  Wv                                      { get; set; }

        public static IVV? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IVV();

            value.I                                         = GetInt32(new IntPtr(p + 0x010)); // 0270D4E33918 0x10 I                           ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Mv                                        = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0270D4E33938 0x14 Mv                          ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Gv                                        = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0270D4E33958 0x20 Gv                          ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Wv                                        = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0270D4E33978 0x2C Wv                          ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
