using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CueSheet                                 ModelPrimitiveType string string string String
    // 040 CueName                                  ModelPrimitiveType string string string String
    public partial class CriAtomClip : DataModel
    {
        public string                                   CueSheet                                { get; set; }
        public string                                   CueName                                 { get; set; }

        public static CriAtomClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomClip() { Pointer= p0 };

            value.CueSheet                                  = GetString(new IntPtr(p + 0x038)); // 0x38 CueSheet                    ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x040)); // 0x40 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
