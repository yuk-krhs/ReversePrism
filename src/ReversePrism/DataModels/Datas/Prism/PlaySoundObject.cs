using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CueSheetName                             0001866722E0 ModelPrimitiveType string string string String
    // 028 CueName                                  0001866722E0 ModelPrimitiveType string string string String
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

            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 024664E6C100 0x20 CueSheetName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x028)); // 024664E6C120 0x28 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
