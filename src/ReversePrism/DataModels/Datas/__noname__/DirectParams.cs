using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X0                                       ModelPrimitiveType float float float Single
    // 014 Y0                                       ModelPrimitiveType float float float Single
    // 018 X1                                       ModelPrimitiveType float float float Single
    // 01C Y1                                       ModelPrimitiveType float float float Single
    // 020 W                                        ModelPrimitiveType float float float Single
    // 024 OvershootX                               ModelPrimitiveType float float float Single
    // 028 OvershootY                               ModelPrimitiveType float float float Single
    // 02C Gamma                                    ModelPrimitiveType float float float Single
    public partial class DirectParams : DataModel
    {
        public float                                    X0                                      { get; set; }
        public float                                    Y0                                      { get; set; }
        public float                                    X1                                      { get; set; }
        public float                                    Y1                                      { get; set; }
        public float                                    W                                       { get; set; }
        public float                                    OvershootX                              { get; set; }
        public float                                    OvershootY                              { get; set; }
        public float                                    Gamma                                   { get; set; }

        public static DirectParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectParams() { Pointer= p0 };

            value.X0                                        = GetSingle(new IntPtr(p + 0x010)); // 0x10 X0                          ( ModelPrimitiveType float float float Single )
            value.Y0                                        = GetSingle(new IntPtr(p + 0x014)); // 0x14 Y0                          ( ModelPrimitiveType float float float Single )
            value.X1                                        = GetSingle(new IntPtr(p + 0x018)); // 0x18 X1                          ( ModelPrimitiveType float float float Single )
            value.Y1                                        = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Y1                          ( ModelPrimitiveType float float float Single )
            value.W                                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 W                           ( ModelPrimitiveType float float float Single )
            value.OvershootX                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 OvershootX                  ( ModelPrimitiveType float float float Single )
            value.OvershootY                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 OvershootY                  ( ModelPrimitiveType float float float Single )
            value.Gamma                                     = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Gamma                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
