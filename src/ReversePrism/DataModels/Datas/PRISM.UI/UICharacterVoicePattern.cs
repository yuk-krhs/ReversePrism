using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VoiceResourceId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 020 CueName                                  000186672F10 ModelPrimitiveType string string string String
    public partial class UICharacterVoicePattern : DataModel
    {
        public int                                      VoiceResourceId                         { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static UICharacterVoicePattern? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICharacterVoicePattern() { Pointer= p0 };

            value.VoiceResourceId                           = GetInt32(new IntPtr(p + 0x010)); // 0246654A7B28 0x10 VoiceResourceId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x018)); // 0246654A7B48 0x18 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 0246654A7B68 0x20 CueName                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
