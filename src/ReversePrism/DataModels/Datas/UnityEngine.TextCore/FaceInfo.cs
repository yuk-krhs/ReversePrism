using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FaceIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_FamilyName                             000186671910 ModelPrimitiveType string string string String
    // 020 M_StyleName                              000186671910 ModelPrimitiveType string string string String
    // 028 M_PointSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_Scale                                  0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_UnitsPerEM                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 M_LineHeight                             0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_AscentLine                             0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_CapLine                                0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_MeanLine                               0001866656B0 ModelPrimitiveType float float float Single
    // 044 M_Baseline                               0001866656B0 ModelPrimitiveType float float float Single
    // 048 M_DescentLine                            0001866656B0 ModelPrimitiveType float float float Single
    // 04C M_SuperscriptOffset                      0001866656B0 ModelPrimitiveType float float float Single
    // 050 M_SuperscriptSize                        0001866656B0 ModelPrimitiveType float float float Single
    // 054 M_SubscriptOffset                        0001866656B0 ModelPrimitiveType float float float Single
    // 058 M_SubscriptSize                          0001866656B0 ModelPrimitiveType float float float Single
    // 05C M_UnderlineOffset                        0001866656B0 ModelPrimitiveType float float float Single
    // 060 M_UnderlineThickness                     0001866656B0 ModelPrimitiveType float float float Single
    // 064 M_StrikethroughOffset                    0001866656B0 ModelPrimitiveType float float float Single
    // 068 M_StrikethroughThickness                 0001866656B0 ModelPrimitiveType float float float Single
    // 06C M_TabWidth                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class FaceInfo : DataModel
    {
        public int                                      M_FaceIndex                             { get; set; }
        public string                                   M_FamilyName                            { get; set; }
        public string                                   M_StyleName                             { get; set; }
        public int                                      M_PointSize                             { get; set; }
        public float                                    M_Scale                                 { get; set; }
        public int                                      M_UnitsPerEM                            { get; set; }
        public float                                    M_LineHeight                            { get; set; }
        public float                                    M_AscentLine                            { get; set; }
        public float                                    M_CapLine                               { get; set; }
        public float                                    M_MeanLine                              { get; set; }
        public float                                    M_Baseline                              { get; set; }
        public float                                    M_DescentLine                           { get; set; }
        public float                                    M_SuperscriptOffset                     { get; set; }
        public float                                    M_SuperscriptSize                       { get; set; }
        public float                                    M_SubscriptOffset                       { get; set; }
        public float                                    M_SubscriptSize                         { get; set; }
        public float                                    M_UnderlineOffset                       { get; set; }
        public float                                    M_UnderlineThickness                    { get; set; }
        public float                                    M_StrikethroughOffset                   { get; set; }
        public float                                    M_StrikethroughThickness                { get; set; }
        public float                                    M_TabWidth                              { get; set; }

        public static FaceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceInfo() { Pointer= p0 };

            value.M_FaceIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0245A2158858 0x10 M_FaceIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FamilyName                              = GetString(new IntPtr(p + 0x018)); // 0245A2158878 0x18 M_FamilyName                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_StyleName                               = GetString(new IntPtr(p + 0x020)); // 0245A2158898 0x20 M_StyleName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.M_PointSize                               = GetInt32(new IntPtr(p + 0x028)); // 0245A21588B8 0x28 M_PointSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x02C)); // 0245A21588D8 0x2C M_Scale                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_UnitsPerEM                              = GetInt32(new IntPtr(p + 0x030)); // 0245A21588F8 0x30 M_UnitsPerEM                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_LineHeight                              = GetSingle(new IntPtr(p + 0x034)); // 0245A2158918 0x34 M_LineHeight                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_AscentLine                              = GetSingle(new IntPtr(p + 0x038)); // 0245A2158938 0x38 M_AscentLine                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CapLine                                 = GetSingle(new IntPtr(p + 0x03C)); // 0245A2158958 0x3C M_CapLine                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MeanLine                                = GetSingle(new IntPtr(p + 0x040)); // 0245A2158978 0x40 M_MeanLine                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Baseline                                = GetSingle(new IntPtr(p + 0x044)); // 0245A2158998 0x44 M_Baseline                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DescentLine                             = GetSingle(new IntPtr(p + 0x048)); // 0245A21589B8 0x48 M_DescentLine               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SuperscriptOffset                       = GetSingle(new IntPtr(p + 0x04C)); // 0245A21589D8 0x4C M_SuperscriptOffset         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SuperscriptSize                         = GetSingle(new IntPtr(p + 0x050)); // 0245A21589F8 0x50 M_SuperscriptSize           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SubscriptOffset                         = GetSingle(new IntPtr(p + 0x054)); // 0245A2158A18 0x54 M_SubscriptOffset           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SubscriptSize                           = GetSingle(new IntPtr(p + 0x058)); // 0245A2158A38 0x58 M_SubscriptSize             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_UnderlineOffset                         = GetSingle(new IntPtr(p + 0x05C)); // 0245A2158A58 0x5C M_UnderlineOffset           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_UnderlineThickness                      = GetSingle(new IntPtr(p + 0x060)); // 0245A2158A78 0x60 M_UnderlineThickness        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_StrikethroughOffset                     = GetSingle(new IntPtr(p + 0x064)); // 0245A2158A98 0x64 M_StrikethroughOffset       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_StrikethroughThickness                  = GetSingle(new IntPtr(p + 0x068)); // 0245A2158AB8 0x68 M_StrikethroughThickness    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TabWidth                                = GetSingle(new IntPtr(p + 0x06C)); // 0245A2158AD8 0x6C M_TabWidth                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
