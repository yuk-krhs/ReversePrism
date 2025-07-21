using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 I                                        ModelPrimitiveType int int int Int32
    // 014 Mv                                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 Gv                                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C Wv                                       ModelEnumType Vector3 Vector3 Vector3 Int32
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

            value.I                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 I                           ( ModelPrimitiveType int int int Int32 )
            value.Mv                                        = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0x14 Mv                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Gv                                        = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 Gv                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Wv                                        = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Wv                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
