using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ui                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Uo                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Vi                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 01C Vo                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 020 Ut                                       000186666F40 ModelPrimitiveType float float float Single
    // 024 Vt                                       000186666F40 ModelPrimitiveType float float float Single
    public partial class InterpolateValue : DataModel
    {
        public int                                      Ui                                      { get; set; }
        public int                                      Uo                                      { get; set; }
        public int                                      Vi                                      { get; set; }
        public int                                      Vo                                      { get; set; }
        public float                                    Ut                                      { get; set; }
        public float                                    Vt                                      { get; set; }

        public static InterpolateValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterpolateValue() { Pointer= p0 };

            value.Ui                                        = GetInt32(new IntPtr(p + 0x010)); // 024664B81768 0x10 Ui                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Uo                                        = GetInt32(new IntPtr(p + 0x014)); // 024664B81788 0x14 Uo                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Vi                                        = GetInt32(new IntPtr(p + 0x018)); // 024664B817A8 0x18 Vi                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Vo                                        = GetInt32(new IntPtr(p + 0x01C)); // 024664B817C8 0x1C Vo                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Ut                                        = GetSingle(new IntPtr(p + 0x020)); // 024664B817E8 0x20 Ut                          ( 000186666F40 ModelPrimitiveType float float float Single )
            value.Vt                                        = GetSingle(new IntPtr(p + 0x024)); // 024664B81808 0x24 Vt                          ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
