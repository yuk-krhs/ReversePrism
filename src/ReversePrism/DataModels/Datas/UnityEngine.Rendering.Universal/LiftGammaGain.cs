using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Lift                                     ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 040 Gamma                                    ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 048 Gain                                     ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    public partial class LiftGammaGain : DataModel
    {
        public Vector4Parameter?                        Lift                                    { get; set; }
        public Vector4Parameter?                        Gamma                                   { get; set; }
        public Vector4Parameter?                        Gain                                    { get; set; }

        public static LiftGammaGain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiftGammaGain() { Pointer= p0 };

            value.Lift                                      = GetObject<Vector4Parameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0x38 Lift                        ( ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Gamma                                     = GetObject<Vector4Parameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0x40 Gamma                       ( ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Gain                                      = GetObject<Vector4Parameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0x48 Gain                        ( ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )

            return value;
        }
    }
}
