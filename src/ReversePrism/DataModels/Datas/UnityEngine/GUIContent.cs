using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Text                                   ModelPrimitiveType string string string String
    // 018 M_Image                                  ModelClassType Texture Texture Texture Pointer
    // 020 M_Tooltip                                ModelPrimitiveType string string string String
    // 028 OnTextChanged                            ModelClassType Action Action Action Pointer
    // 000 s_Text                                   GUIContent IL2CPP_TYPE_CLASS
    // 008 s_Image                                  GUIContent IL2CPP_TYPE_CLASS
    // 010 S_TextImage                              ModelClassType GUIContent GUIContent GUIContent Pointer
    // 018 None                                     ModelClassType GUIContent GUIContent GUIContent Pointer
    public partial class GUIContent : DataModel
    {
        public string                                   M_Text                                  { get; set; }
        public Texture?                                 M_Image                                 { get; set; }
        public string                                   M_Tooltip                               { get; set; }
        public Action?                                  OnTextChanged                           { get; set; }
        public GUIContent?                              S_TextImage                             { get; set; }
        public GUIContent?                              None                                    { get; set; }

        public static GUIContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIContent() { Pointer= p0 };

            value.M_Text                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_Image                                   = GetObject<Texture>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture.FromPointer); // 0x18 M_Image                     ( ModelClassType Texture Texture Texture Pointer )
            value.M_Tooltip                                 = GetString(new IntPtr(p + 0x020)); // 0x20 M_Tooltip                   ( ModelPrimitiveType string string string String )
            value.OnTextChanged                             = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0x28 OnTextChanged               ( ModelClassType Action Action Action Pointer )
            value.S_TextImage                               = GetObject<GUIContent>(new IntPtr(p + 0x010), ReversePrism.DataModels.GUIContent.FromPointer); // 0x10 S_TextImage                 ( ModelClassType GUIContent GUIContent GUIContent Pointer )
            value.None                                      = GetObject<GUIContent>(new IntPtr(p + 0x018), ReversePrism.DataModels.GUIContent.FromPointer); // 0x18 None                        ( ModelClassType GUIContent GUIContent GUIContent Pointer )

            return value;
        }
    }
}
