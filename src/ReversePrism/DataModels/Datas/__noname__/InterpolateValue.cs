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
    public partial class InterpolateValue
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
            var value   = new InterpolateValue();

            value.Ui                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D4B19F50 0x10 Ui                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Uo                                        = GetInt32(new IntPtr(p + 0x014)); // 0270D4B19F70 0x14 Uo                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Vi                                        = GetInt32(new IntPtr(p + 0x018)); // 0270D4B19F90 0x18 Vi                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Vo                                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D4B19FB0 0x1C Vo                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Ut                                        = GetSingle(new IntPtr(p + 0x020)); // 0270D4B19FD0 0x20 Ut                          ( 000186666F40 ModelPrimitiveType float float float Single )
            value.Vt                                        = GetSingle(new IntPtr(p + 0x024)); // 0270D4B19FF0 0x24 Vt                          ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
