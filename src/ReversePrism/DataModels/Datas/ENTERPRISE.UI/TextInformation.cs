using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 018 TextKey                                  ModelPrimitiveType string string string String
    // 020 Color                                    ModelEnumType Color Color Color Int32
    // 030 OutlineColor                             ModelEnumType TextOutlineColorId TextOutlineColorId TextOutlineColorId Int32
    public partial class TextInformation : DataModel
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
            var value   = new TextInformation() { Pointer= p0 };

            value.Target                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x10 Target                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextKey                                   = GetString(new IntPtr(p + 0x018)); // 0x18 TextKey                     ( ModelPrimitiveType string string string String )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 Color                       ( ModelEnumType Color Color Color Int32 )
            value.OutlineColor                              = (TextOutlineColorId)GetInt32(new IntPtr(p + 0x030)); // 0x30 OutlineColor                ( ModelEnumType TextOutlineColorId TextOutlineColorId TextOutlineColorId Int32 )

            return value;
        }
    }
}
