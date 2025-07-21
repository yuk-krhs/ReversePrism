using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelEnumType NoiseParams NoiseParams NoiseParams Int32
    // 01C Y                                        ModelEnumType NoiseParams NoiseParams NoiseParams Int32
    // 028 Z                                        ModelEnumType NoiseParams NoiseParams NoiseParams Int32
    public partial class TransformNoiseParams : DataModel
    {
        public NoiseParams                              X                                       { get; set; }
        public NoiseParams                              Y                                       { get; set; }
        public NoiseParams                              Z                                       { get; set; }

        public static TransformNoiseParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformNoiseParams() { Pointer= p0 };

            value.X                                         = (NoiseParams)GetInt32(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelEnumType NoiseParams NoiseParams NoiseParams Int32 )
            value.Y                                         = (NoiseParams)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Y                           ( ModelEnumType NoiseParams NoiseParams NoiseParams Int32 )
            value.Z                                         = (NoiseParams)GetInt32(new IntPtr(p + 0x028)); // 0x28 Z                           ( ModelEnumType NoiseParams NoiseParams NoiseParams Int32 )

            return value;
        }
    }
}
