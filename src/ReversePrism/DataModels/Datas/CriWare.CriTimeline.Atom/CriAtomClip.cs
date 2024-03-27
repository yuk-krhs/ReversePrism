using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CueSheet                                 0001866722E0 ModelPrimitiveType string string string String
    // 040 CueName                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class CriAtomClip
    {
        public string                                   CueSheet                                { get; set; }
        public string                                   CueName                                 { get; set; }

        public static CriAtomClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomClip();

            value.CueSheet                                  = GetString(new IntPtr(p + 0x038)); // 027005BE3D50 0x38 CueSheet                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x040)); // 027005BE3D70 0x40 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
