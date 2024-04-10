using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 CueName                                  000186671910 ModelPrimitiveType string string string String
    // 0B0 CueSheet                                 000186671910 ModelPrimitiveType string string string String
    public partial class CriAtomSource : DataModel
    {
        public string                                   CueName                                 { get; set; }
        public string                                   CueSheet                                { get; set; }

        public static CriAtomSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomSource() { Pointer= p0 };

            value.CueName                                   = GetString(new IntPtr(p + 0x0A8)); // 0245A421E948 0xA8 CueName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.CueSheet                                  = GetString(new IntPtr(p + 0x0B0)); // 0245A421E968 0xB0 CueSheet                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
