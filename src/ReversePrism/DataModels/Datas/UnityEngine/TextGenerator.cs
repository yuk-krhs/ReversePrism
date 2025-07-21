using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_LastString                             ModelPrimitiveType string string string String
    // 020 M_LastSettings                           ModelEnumType TextGenerationSettings TextGenerationSettings TextGenerationSettings Int32
    // 080 M_HasGenerated                           ModelPrimitiveType bool bool bool Bool
    // 084 M_LastValid                              ModelEnumType TextGenerationError TextGenerationError TextGenerationError Int32
    // 088 M_Verts                                  ModelEnumListType List`1<UIVertex> List`1<UIVertex> List<UIVertex> Pointer
    // 090 M_Characters                             ModelEnumListType List`1<UICharInfo> List`1<UICharInfo> List<UICharInfo> Pointer
    // 098 M_Lines                                  ModelEnumListType List`1<UILineInfo> List`1<UILineInfo> List<UILineInfo> Pointer
    // 0A0 M_CachedVerts                            ModelPrimitiveType bool bool bool Bool
    // 0A1 M_CachedCharacters                       ModelPrimitiveType bool bool bool Bool
    // 0A2 M_CachedLines                            ModelPrimitiveType bool bool bool Bool
    public partial class TextGenerator : DataModel
    {
        public string                                   M_LastString                            { get; set; }
        public TextGenerationSettings                   M_LastSettings                          { get; set; }
        public bool                                     M_HasGenerated                          { get; set; }
        public TextGenerationError                      M_LastValid                             { get; set; }
        public List<UIVertex>?                          M_Verts                                 { get; set; }
        public List<UICharInfo>?                        M_Characters                            { get; set; }
        public List<UILineInfo>?                        M_Lines                                 { get; set; }
        public bool                                     M_CachedVerts                           { get; set; }
        public bool                                     M_CachedCharacters                      { get; set; }
        public bool                                     M_CachedLines                           { get; set; }

        public static TextGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextGenerator() { Pointer= p0 };

            value.M_LastString                              = GetString(new IntPtr(p + 0x018)); // 0x18 M_LastString                ( ModelPrimitiveType string string string String )
            value.M_LastSettings                            = (TextGenerationSettings)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_LastSettings              ( ModelEnumType TextGenerationSettings TextGenerationSettings TextGenerationSettings Int32 )
            value.M_HasGenerated                            = GetBool(new IntPtr(p + 0x080)); // 0x80 M_HasGenerated              ( ModelPrimitiveType bool bool bool Bool )
            value.M_LastValid                               = (TextGenerationError)GetInt32(new IntPtr(p + 0x084)); // 0x84 M_LastValid                 ( ModelEnumType TextGenerationError TextGenerationError TextGenerationError Int32 )
            value.M_Verts                                   = GetEnumList<UIVertex>(new IntPtr(p + 0x088)); // 0x88 M_Verts                     ( ModelEnumListType List`1<UIVertex> List`1<UIVertex> List<UIVertex> Pointer )
            value.M_Characters                              = GetEnumList<UICharInfo>(new IntPtr(p + 0x090)); // 0x90 M_Characters                ( ModelEnumListType List`1<UICharInfo> List`1<UICharInfo> List<UICharInfo> Pointer )
            value.M_Lines                                   = GetEnumList<UILineInfo>(new IntPtr(p + 0x098)); // 0x98 M_Lines                     ( ModelEnumListType List`1<UILineInfo> List`1<UILineInfo> List<UILineInfo> Pointer )
            value.M_CachedVerts                             = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 M_CachedVerts               ( ModelPrimitiveType bool bool bool Bool )
            value.M_CachedCharacters                        = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 M_CachedCharacters          ( ModelPrimitiveType bool bool bool Bool )
            value.M_CachedLines                             = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 M_CachedLines               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
