using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstVoiceResourceId                       ModelPrimitiveType int int int Int32
    // 014 VoiceType                                ModelPrimitiveType int int int Int32
    // 018 CueSheetName                             ModelPrimitiveType string string string String
    // 020 CueName                                  ModelPrimitiveType string string string String
    // 028 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 02C MstCostumeSetId                          ModelPrimitiveType int int int Int32
    public partial class VoiceElementGridCellViewModel : DataModel
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
            var value   = new VoiceElementGridCellViewModel() { Pointer= p0 };

            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstVoiceResourceId          ( ModelPrimitiveType int int int Int32 )
            value.VoiceType                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 VoiceType                   ( ModelPrimitiveType int int int Int32 )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x018)); // 0x18 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 0x20 CueName                     ( ModelPrimitiveType string string string String )
            value.Enable                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstCostumeSetId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
