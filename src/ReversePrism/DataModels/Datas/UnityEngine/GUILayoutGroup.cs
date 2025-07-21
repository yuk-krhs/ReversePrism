using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Entries                                  ModelClassListType List`1<GUILayoutEntry> List`1<GUILayoutEntry> List<GUILayoutEntry> Pointer
    // 050 IsVertical                               ModelPrimitiveType bool bool bool Bool
    // 051 ResetCoords                              ModelPrimitiveType bool bool bool Bool
    // 054 Spacing                                  ModelPrimitiveType float float float Single
    // 058 SameSize                                 ModelPrimitiveType bool bool bool Bool
    // 059 IsWindow                                 ModelPrimitiveType bool bool bool Bool
    // 05C WindowID                                 ModelPrimitiveType int int int Int32
    // 060 M_Cursor                                 ModelPrimitiveType int int int Int32
    // 064 M_StretchableCountX                      ModelPrimitiveType int int int Int32
    // 068 M_StretchableCountY                      ModelPrimitiveType int int int Int32
    // 06C M_UserSpecifiedWidth                     ModelPrimitiveType bool bool bool Bool
    // 06D M_UserSpecifiedHeight                    ModelPrimitiveType bool bool bool Bool
    // 070 M_ChildMinWidth                          ModelPrimitiveType float float float Single
    // 074 M_ChildMaxWidth                          ModelPrimitiveType float float float Single
    // 078 M_ChildMinHeight                         ModelPrimitiveType float float float Single
    // 07C M_ChildMaxHeight                         ModelPrimitiveType float float float Single
    // 080 M_MarginLeft                             ModelPrimitiveType int int int Int32
    // 084 M_MarginRight                            ModelPrimitiveType int int int Int32
    // 088 M_MarginTop                              ModelPrimitiveType int int int Int32
    // 08C M_MarginBottom                           ModelPrimitiveType int int int Int32
    // 000 none                                     GUILayoutEntry IL2CPP_TYPE_CLASS
    public partial class GUILayoutGroup : DataModel
    {
        public List<GUILayoutEntry>?                    Entries                                 { get; set; }
        public bool                                     IsVertical                              { get; set; }
        public bool                                     ResetCoords                             { get; set; }
        public float                                    Spacing                                 { get; set; }
        public bool                                     SameSize                                { get; set; }
        public bool                                     IsWindow                                { get; set; }
        public int                                      WindowID                                { get; set; }
        public int                                      M_Cursor                                { get; set; }
        public int                                      M_StretchableCountX                     { get; set; }
        public int                                      M_StretchableCountY                     { get; set; }
        public bool                                     M_UserSpecifiedWidth                    { get; set; }
        public bool                                     M_UserSpecifiedHeight                   { get; set; }
        public float                                    M_ChildMinWidth                         { get; set; }
        public float                                    M_ChildMaxWidth                         { get; set; }
        public float                                    M_ChildMinHeight                        { get; set; }
        public float                                    M_ChildMaxHeight                        { get; set; }
        public int                                      M_MarginLeft                            { get; set; }
        public int                                      M_MarginRight                           { get; set; }
        public int                                      M_MarginTop                             { get; set; }
        public int                                      M_MarginBottom                          { get; set; }

        public static GUILayoutGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUILayoutGroup() { Pointer= p0 };

            value.Entries                                   = GetObjectList<GUILayoutEntry>(new IntPtr(p + 0x048), ReversePrism.DataModels.GUILayoutEntry.FromPointer); // 0x48 Entries                     ( ModelClassListType List`1<GUILayoutEntry> List`1<GUILayoutEntry> List<GUILayoutEntry> Pointer )
            value.IsVertical                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsVertical                  ( ModelPrimitiveType bool bool bool Bool )
            value.ResetCoords                               = GetBool(new IntPtr(p + 0x051)); // 0x51 ResetCoords                 ( ModelPrimitiveType bool bool bool Bool )
            value.Spacing                                   = GetSingle(new IntPtr(p + 0x054)); // 0x54 Spacing                     ( ModelPrimitiveType float float float Single )
            value.SameSize                                  = GetBool(new IntPtr(p + 0x058)); // 0x58 SameSize                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsWindow                                  = GetBool(new IntPtr(p + 0x059)); // 0x59 IsWindow                    ( ModelPrimitiveType bool bool bool Bool )
            value.WindowID                                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C WindowID                    ( ModelPrimitiveType int int int Int32 )
            value.M_Cursor                                  = GetInt32(new IntPtr(p + 0x060)); // 0x60 M_Cursor                    ( ModelPrimitiveType int int int Int32 )
            value.M_StretchableCountX                       = GetInt32(new IntPtr(p + 0x064)); // 0x64 M_StretchableCountX         ( ModelPrimitiveType int int int Int32 )
            value.M_StretchableCountY                       = GetInt32(new IntPtr(p + 0x068)); // 0x68 M_StretchableCountY         ( ModelPrimitiveType int int int Int32 )
            value.M_UserSpecifiedWidth                      = GetBool(new IntPtr(p + 0x06C)); // 0x6C M_UserSpecifiedWidth        ( ModelPrimitiveType bool bool bool Bool )
            value.M_UserSpecifiedHeight                     = GetBool(new IntPtr(p + 0x06D)); // 0x6D M_UserSpecifiedHeight       ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildMinWidth                           = GetSingle(new IntPtr(p + 0x070)); // 0x70 M_ChildMinWidth             ( ModelPrimitiveType float float float Single )
            value.M_ChildMaxWidth                           = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_ChildMaxWidth             ( ModelPrimitiveType float float float Single )
            value.M_ChildMinHeight                          = GetSingle(new IntPtr(p + 0x078)); // 0x78 M_ChildMinHeight            ( ModelPrimitiveType float float float Single )
            value.M_ChildMaxHeight                          = GetSingle(new IntPtr(p + 0x07C)); // 0x7C M_ChildMaxHeight            ( ModelPrimitiveType float float float Single )
            value.M_MarginLeft                              = GetInt32(new IntPtr(p + 0x080)); // 0x80 M_MarginLeft                ( ModelPrimitiveType int int int Int32 )
            value.M_MarginRight                             = GetInt32(new IntPtr(p + 0x084)); // 0x84 M_MarginRight               ( ModelPrimitiveType int int int Int32 )
            value.M_MarginTop                               = GetInt32(new IntPtr(p + 0x088)); // 0x88 M_MarginTop                 ( ModelPrimitiveType int int int Int32 )
            value.M_MarginBottom                            = GetInt32(new IntPtr(p + 0x08C)); // 0x8C M_MarginBottom              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
