using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 018 TextKey                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 OutlineColor                             000186641B40 ModelEnumType TextOutlineColorId TextOutlineColorId TextOutlineColorId Int32
    public partial class TextInformation
    {
        public UITextMeshProUGUI?                       Target                                  { get; set; }
        public string                                   TextKey                                 { get; set; }
        public Color                                    Color                                   { get; set; }
        public TextOutlineColorId                       OutlineColor                            { get; set; }

        public static TextInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextInformation();

            value.Target                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D0CA2F38 0x10 Target                      ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextKey                                   = GetString(new IntPtr(p + 0x018)); // 0270D0CA2F58 0x18 TextKey                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270D0CA2F78 0x20 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.OutlineColor                              = (TextOutlineColorId)GetInt32(new IntPtr(p + 0x030)); // 0270D0CA2F98 0x30 OutlineColor                ( 000186641B40 ModelEnumType TextOutlineColorId TextOutlineColorId TextOutlineColorId Int32 )

            return value;
        }
    }
}
