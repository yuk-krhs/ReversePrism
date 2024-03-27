using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lift                                     000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 018 Gamma                                    000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    // 020 Gain                                     000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer
    public partial class ColorGradingTrackballBehaviour
    {
        public Vector4Parameter?                        Lift                                    { get; set; }
        public Vector4Parameter?                        Gamma                                   { get; set; }
        public Vector4Parameter?                        Gain                                    { get; set; }

        public static ColorGradingTrackballBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingTrackballBehaviour();

            value.Lift                                      = GetObject<Vector4Parameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0270D5074FA8 0x10 Lift                        ( 000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Gamma                                     = GetObject<Vector4Parameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0270D5074FC8 0x18 Gamma                       ( 000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )
            value.Gain                                      = GetObject<Vector4Parameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.Vector4Parameter.FromPointer); // 0270D5074FE8 0x20 Gain                        ( 000186779F30 ModelClassType Vector4Parameter Vector4Parameter Vector4Parameter Pointer )

            return value;
        }
    }
}
