using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PreferredSize                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 M_TextInfo                               ModelClassType TextInfo TextInfo TextInfo Pointer
    // 000 m_LayoutTextInfo                         TextInfo IL2CPP_TYPE_CLASS
    // 020 M_PreviousGenerationSettingsHash         ModelPrimitiveType int int int Int32
    // 028 TextGenerationSettings                   ModelClassType TextGenerationSettings TextGenerationSettings TextGenerationSettings Pointer
    // 008 s_LayoutSettings                         TextGenerationSettings IL2CPP_TYPE_CLASS
    // 030 IsDirty                                  ModelPrimitiveType bool bool bool Bool
    public partial class TextHandle : DataModel
    {
        public Vector2                                  M_PreferredSize                         { get; set; }
        public TextInfo?                                M_TextInfo                              { get; set; }
        public int                                      M_PreviousGenerationSettingsHash        { get; set; }
        public TextGenerationSettings?                  TextGenerationSettings                  { get; set; }
        public bool                                     IsDirty                                 { get; set; }

        public static TextHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextHandle() { Pointer= p0 };

            value.M_PreferredSize                           = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_PreferredSize             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_TextInfo                                = GetObject<TextInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextInfo.FromPointer); // 0x18 M_TextInfo                  ( ModelClassType TextInfo TextInfo TextInfo Pointer )
            value.M_PreviousGenerationSettingsHash          = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_PreviousGenerationSettingsHash ( ModelPrimitiveType int int int Int32 )
            value.TextGenerationSettings                    = GetObject<TextGenerationSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextGenerationSettings.FromPointer); // 0x28 TextGenerationSettings      ( ModelClassType TextGenerationSettings TextGenerationSettings TextGenerationSettings Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 IsDirty                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
