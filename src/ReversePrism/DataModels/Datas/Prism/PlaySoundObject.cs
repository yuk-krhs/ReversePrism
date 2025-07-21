using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CueSheetName                             ModelPrimitiveType string string string String
    // 028 CueName                                  ModelPrimitiveType string string string String
    public partial class PlaySoundObject : DataModel
    {
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static PlaySoundObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaySoundObject() { Pointer= p0 };

            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 0x20 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x028)); // 0x28 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
