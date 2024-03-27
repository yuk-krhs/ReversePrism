using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstVoiceResourceId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 VoiceType                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 020 CueName                                  000186672F10 ModelPrimitiveType string string string String
    // 028 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C MstCostumeSetId                          0001865F4260 ModelPrimitiveType int int int Int32
    public partial class VoiceElementGridCellViewModel
    {
        public int                                      MstVoiceResourceId                      { get; set; }
        public int                                      VoiceType                               { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }
        public bool                                     Enable                                  { get; set; }
        public int                                      MstCostumeSetId                         { get; set; }

        public static VoiceElementGridCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceElementGridCellViewModel();

            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x010)); // 0270D604F938 0x10 MstVoiceResourceId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.VoiceType                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D604F958 0x14 VoiceType                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x018)); // 0270D604F978 0x18 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 0270D604F998 0x20 CueName                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Enable                                    = GetBool(new IntPtr(p + 0x028)); // 0270D604F9B8 0x28 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x02C)); // 0270D604F9D8 0x2C MstCostumeSetId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
