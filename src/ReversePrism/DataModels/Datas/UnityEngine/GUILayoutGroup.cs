using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Entries                                  000185CDCF68 ModelClassListType List`1<GUILayoutEntry> List`1<GUILayoutEntry> List<GUILayoutEntry> Pointer
    // 050 IsVertical                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 051 ResetCoords                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 054 Spacing                                  000186666050 ModelPrimitiveType float float float Single
    // 058 SameSize                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 059 IsWindow                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 05C WindowID                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 060 M_Cursor                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 M_StretchableCountX                      0001865F3220 ModelPrimitiveType int int int Int32
    // 068 M_StretchableCountY                      0001865F3220 ModelPrimitiveType int int int Int32
    // 06C M_UserSpecifiedWidth                     000186595480 ModelPrimitiveType bool bool bool Bool
    // 06D M_UserSpecifiedHeight                    000186595480 ModelPrimitiveType bool bool bool Bool
    // 070 M_ChildMinWidth                          000186665B50 ModelPrimitiveType float float float Single
    // 074 M_ChildMaxWidth                          000186665B50 ModelPrimitiveType float float float Single
    // 078 M_ChildMinHeight                         000186665B50 ModelPrimitiveType float float float Single
    // 07C M_ChildMaxHeight                         000186665B50 ModelPrimitiveType float float float Single
    // 080 M_MarginLeft                             0001865F3220 ModelPrimitiveType int int int Int32
    // 084 M_MarginRight                            0001865F3220 ModelPrimitiveType int int int Int32
    // 088 M_MarginTop                              0001865F3220 ModelPrimitiveType int int int Int32
    // 08C M_MarginBottom                           0001865F3220 ModelPrimitiveType int int int Int32
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

            value.Entries                                   = GetObjectList<GUILayoutEntry>(new IntPtr(p + 0x048), ReversePrism.DataModels.GUILayoutEntry.FromPointer); // 0245A21CEAF0 0x48 Entries                     ( 000185CDCF68 ModelClassListType List`1<GUILayoutEntry> List`1<GUILayoutEntry> List<GUILayoutEntry> Pointer )
            value.IsVertical                                = GetBool(new IntPtr(p + 0x050)); // 0245A21CEB10 0x50 IsVertical                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ResetCoords                               = GetBool(new IntPtr(p + 0x051)); // 0245A21CEB30 0x51 ResetCoords                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Spacing                                   = GetSingle(new IntPtr(p + 0x054)); // 0245A21CEB50 0x54 Spacing                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.SameSize                                  = GetBool(new IntPtr(p + 0x058)); // 0245A21CEB70 0x58 SameSize                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsWindow                                  = GetBool(new IntPtr(p + 0x059)); // 0245A21CEB90 0x59 IsWindow                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.WindowID                                  = GetInt32(new IntPtr(p + 0x05C)); // 0245A21CEBB0 0x5C WindowID                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_Cursor                                  = GetInt32(new IntPtr(p + 0x060)); // 0245A21CEBD0 0x60 M_Cursor                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_StretchableCountX                       = GetInt32(new IntPtr(p + 0x064)); // 0245A21CEBF0 0x64 M_StretchableCountX         ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_StretchableCountY                       = GetInt32(new IntPtr(p + 0x068)); // 0245A21CEC10 0x68 M_StretchableCountY         ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_UserSpecifiedWidth                      = GetBool(new IntPtr(p + 0x06C)); // 0245A21CEC30 0x6C M_UserSpecifiedWidth        ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_UserSpecifiedHeight                     = GetBool(new IntPtr(p + 0x06D)); // 0245A21CEC50 0x6D M_UserSpecifiedHeight       ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ChildMinWidth                           = GetSingle(new IntPtr(p + 0x070)); // 0245A21CEC70 0x70 M_ChildMinWidth             ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ChildMaxWidth                           = GetSingle(new IntPtr(p + 0x074)); // 0245A21CEC90 0x74 M_ChildMaxWidth             ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ChildMinHeight                          = GetSingle(new IntPtr(p + 0x078)); // 0245A21CECB0 0x78 M_ChildMinHeight            ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ChildMaxHeight                          = GetSingle(new IntPtr(p + 0x07C)); // 0245A21CECD0 0x7C M_ChildMaxHeight            ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_MarginLeft                              = GetInt32(new IntPtr(p + 0x080)); // 0245A21CECF0 0x80 M_MarginLeft                ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_MarginRight                             = GetInt32(new IntPtr(p + 0x084)); // 0245A21CED10 0x84 M_MarginRight               ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_MarginTop                               = GetInt32(new IntPtr(p + 0x088)); // 0245A21CED30 0x88 M_MarginTop                 ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_MarginBottom                            = GetInt32(new IntPtr(p + 0x08C)); // 0245A21CED50 0x8C M_MarginBottom              ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
