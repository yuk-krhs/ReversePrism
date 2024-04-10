using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rotate                                   000186692EE0 ModelEnumType Rotate Rotate Rotate Int32
    // 028 Scale                                    0001866C0980 ModelEnumType Scale Scale Scale Int32
    // 038 TransformOrigin                          000186691110 ModelEnumType TransformOrigin TransformOrigin TransformOrigin Int32
    // 04C Translate                                000186691FB0 ModelEnumType Translate Translate Translate Int32
    public partial class TransformData : DataModel
    {
        public Rotate                                   Rotate                                  { get; set; }
        public Scale                                    Scale                                   { get; set; }
        public TransformOrigin                          TransformOrigin                         { get; set; }
        public Translate                                Translate                               { get; set; }

        public static TransformData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformData() { Pointer= p0 };

            value.Rotate                                    = (Rotate)GetInt32(new IntPtr(p + 0x010)); // 0245A3F20A80 0x10 Rotate                      ( 000186692EE0 ModelEnumType Rotate Rotate Rotate Int32 )
            value.Scale                                     = (Scale)GetInt32(new IntPtr(p + 0x028)); // 0245A3F20AA0 0x28 Scale                       ( 0001866C0980 ModelEnumType Scale Scale Scale Int32 )
            value.TransformOrigin                           = (TransformOrigin)GetInt32(new IntPtr(p + 0x038)); // 0245A3F20AC0 0x38 TransformOrigin             ( 000186691110 ModelEnumType TransformOrigin TransformOrigin TransformOrigin Int32 )
            value.Translate                                 = (Translate)GetInt32(new IntPtr(p + 0x04C)); // 0245A3F20AE0 0x4C Translate                   ( 000186691FB0 ModelEnumType Translate Translate Translate Int32 )

            return value;
        }
    }
}
