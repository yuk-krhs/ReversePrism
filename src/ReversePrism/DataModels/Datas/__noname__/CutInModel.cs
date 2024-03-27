using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CutInImage                               00018664D720 ModelClassType Texture Texture Texture Pointer
    // 018 VoiceCueSheetName                        0001866722E0 ModelPrimitiveType string string string String
    // 020 VoiceCueName                             0001866722E0 ModelPrimitiveType string string string String
    public partial class CutInModel
    {
        public Texture?                                 CutInImage                              { get; set; }
        public string                                   VoiceCueSheetName                       { get; set; }
        public string                                   VoiceCueName                            { get; set; }

        public static CutInModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CutInModel();

            value.CutInImage                                = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 0270D5C56668 0x10 CutInImage                  ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.VoiceCueSheetName                         = GetString(new IntPtr(p + 0x018)); // 0270D5C56688 0x18 VoiceCueSheetName           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.VoiceCueName                              = GetString(new IntPtr(p + 0x020)); // 0270D5C566A8 0x20 VoiceCueName                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
