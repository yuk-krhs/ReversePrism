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
    public partial class IVV : DataModel
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
            var value   = new IVV() { Pointer= p0 };

            value.I                                         = GetInt32(new IntPtr(p + 0x010)); // 024664EA8E18 0x10 I                           ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Mv                                        = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 024664EA8E38 0x14 Mv                          ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Gv                                        = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 024664EA8E58 0x20 Gv                          ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Wv                                        = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 024664EA8E78 0x2C Wv                          ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
