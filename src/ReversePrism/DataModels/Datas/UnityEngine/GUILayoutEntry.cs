using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MinWidth                                 000186666050 ModelPrimitiveType float float float Single
    // 014 MaxWidth                                 000186666050 ModelPrimitiveType float float float Single
    // 018 MinHeight                                000186666050 ModelPrimitiveType float float float Single
    // 01C MaxHeight                                000186666050 ModelPrimitiveType float float float Single
    // 020 Rect                                     00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 030 StretchWidth                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 StretchHeight                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 ConsideredForMargin                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 M_Style                                  0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 000 kDummyRect                               Rect IL2CPP_TYPE_VALUETYPE
    // 010 Indent                                   0001865F3D80 ModelPrimitiveType int int int Int32
    public partial class GUILayoutEntry
    {
        public float                                    MinWidth                                { get; set; }
        public float                                    MaxWidth                                { get; set; }
        public float                                    MinHeight                               { get; set; }
        public float                                    MaxHeight                               { get; set; }
        public Rect                                     Rect                                    { get; set; }
        public int                                      StretchWidth                            { get; set; }
        public int                                      StretchHeight                           { get; set; }
        public bool                                     ConsideredForMargin                     { get; set; }
        public GUIStyle?                                M_Style                                 { get; set; }
        public int                                      Indent                                  { get; set; }

        public static GUILayoutEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUILayoutEntry();

            value.MinWidth                                  = GetSingle(new IntPtr(p + 0x010)); // 0270021CAE50 0x10 MinWidth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxWidth                                  = GetSingle(new IntPtr(p + 0x014)); // 0270021CAE70 0x14 MaxWidth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.MinHeight                                 = GetSingle(new IntPtr(p + 0x018)); // 0270021CAE90 0x18 MinHeight                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxHeight                                 = GetSingle(new IntPtr(p + 0x01C)); // 0270021CAEB0 0x1C MaxHeight                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0270021CAED0 0x20 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.StretchWidth                              = GetInt32(new IntPtr(p + 0x030)); // 0270021CAEF0 0x30 StretchWidth                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StretchHeight                             = GetInt32(new IntPtr(p + 0x034)); // 0270021CAF10 0x34 StretchHeight               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ConsideredForMargin                       = GetBool(new IntPtr(p + 0x038)); // 0270021CAF30 0x38 ConsideredForMargin         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_Style                                   = GetObject<GUIStyle>(new IntPtr(p + 0x040), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021CAF50 0x40 M_Style                     ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Indent                                    = GetInt32(new IntPtr(p + 0x010)); // 0270021CAF90 0x10 Indent                      ( 0001865F3D80 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
