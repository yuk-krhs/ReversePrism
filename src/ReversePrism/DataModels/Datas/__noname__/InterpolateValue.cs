using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ui                                       ModelPrimitiveType int int int Int32
    // 014 Uo                                       ModelPrimitiveType int int int Int32
    // 018 Vi                                       ModelPrimitiveType int int int Int32
    // 01C Vo                                       ModelPrimitiveType int int int Int32
    // 020 Ut                                       ModelPrimitiveType float float float Single
    // 024 Vt                                       ModelPrimitiveType float float float Single
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

            value.Ui                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Ui                          ( ModelPrimitiveType int int int Int32 )
            value.Uo                                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 Uo                          ( ModelPrimitiveType int int int Int32 )
            value.Vi                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Vi                          ( ModelPrimitiveType int int int Int32 )
            value.Vo                                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Vo                          ( ModelPrimitiveType int int int Int32 )
            value.Ut                                        = GetSingle(new IntPtr(p + 0x020)); // 0x20 Ut                          ( ModelPrimitiveType float float float Single )
            value.Vt                                        = GetSingle(new IntPtr(p + 0x024)); // 0x24 Vt                          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
