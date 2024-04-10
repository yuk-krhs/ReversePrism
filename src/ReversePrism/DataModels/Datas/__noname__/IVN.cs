using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 I                                        0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Vert                                     0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 Norm                                     0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class IVN : DataModel
    {
        public int                                      I                                       { get; set; }
        public Vector3                                  Vert                                    { get; set; }
        public Vector3                                  Norm                                    { get; set; }

        public static IVN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IVN() { Pointer= p0 };

            value.I                                         = GetInt32(new IntPtr(p + 0x010)); // 024664B81B48 0x10 I                           ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Vert                                      = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 024664B81B68 0x14 Vert                        ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Norm                                      = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 024664B81B88 0x20 Norm                        ( 0001866AC930 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
