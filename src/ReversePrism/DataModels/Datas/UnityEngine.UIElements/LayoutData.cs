using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlignContent                             0001866A22A0 ModelEnumType Align Align Align Int32
    // 014 AlignItems                               0001866A22A0 ModelEnumType Align Align Align Int32
    // 018 AlignSelf                                0001866A22A0 ModelEnumType Align Align Align Int32
    // 01C BorderBottomWidth                        000186666050 ModelPrimitiveType float float float Single
    // 020 BorderLeftWidth                          000186666050 ModelPrimitiveType float float float Single
    // 024 BorderRightWidth                         000186666050 ModelPrimitiveType float float float Single
    // 028 BorderTopWidth                           000186666050 ModelPrimitiveType float float float Single
    // 02C Bottom                                   0001866063F0 ModelEnumType Length Length Length Int32
    // 034 Display                                  0001866DC8A0 ModelEnumType DisplayStyle DisplayStyle DisplayStyle Int32
    // 038 FlexBasis                                0001866063F0 ModelEnumType Length Length Length Int32
    // 040 FlexDirection                            0001865A3850 ModelEnumType FlexDirection FlexDirection FlexDirection Int32
    // 044 FlexGrow                                 000186666050 ModelPrimitiveType float float float Single
    // 048 FlexShrink                               000186666050 ModelPrimitiveType float float float Single
    // 04C FlexWrap                                 00018655E6C0 ModelEnumType Wrap Wrap Wrap Int32
    // 050 Height                                   0001866063F0 ModelEnumType Length Length Length Int32
    // 058 JustifyContent                           000186769B10 ModelEnumType Justify Justify Justify Int32
    // 05C Left                                     0001866063F0 ModelEnumType Length Length Length Int32
    // 064 MarginBottom                             0001866063F0 ModelEnumType Length Length Length Int32
    // 06C MarginLeft                               0001866063F0 ModelEnumType Length Length Length Int32
    // 074 MarginRight                              0001866063F0 ModelEnumType Length Length Length Int32
    // 07C MarginTop                                0001866063F0 ModelEnumType Length Length Length Int32
    // 084 MaxHeight                                0001866063F0 ModelEnumType Length Length Length Int32
    // 08C MaxWidth                                 0001866063F0 ModelEnumType Length Length Length Int32
    // 094 MinHeight                                0001866063F0 ModelEnumType Length Length Length Int32
    // 09C MinWidth                                 0001866063F0 ModelEnumType Length Length Length Int32
    // 0A4 PaddingBottom                            0001866063F0 ModelEnumType Length Length Length Int32
    // 0AC PaddingLeft                              0001866063F0 ModelEnumType Length Length Length Int32
    // 0B4 PaddingRight                             0001866063F0 ModelEnumType Length Length Length Int32
    // 0BC PaddingTop                               0001866063F0 ModelEnumType Length Length Length Int32
    // 0C4 Position                                 000186767A00 ModelEnumType Position Position Position Int32
    // 0C8 Right                                    0001866063F0 ModelEnumType Length Length Length Int32
    // 0D0 Top                                      0001866063F0 ModelEnumType Length Length Length Int32
    // 0D8 Width                                    0001866063F0 ModelEnumType Length Length Length Int32
    public partial class LayoutData
    {
        public Align                                    AlignContent                            { get; set; }
        public Align                                    AlignItems                              { get; set; }
        public Align                                    AlignSelf                               { get; set; }
        public float                                    BorderBottomWidth                       { get; set; }
        public float                                    BorderLeftWidth                         { get; set; }
        public float                                    BorderRightWidth                        { get; set; }
        public float                                    BorderTopWidth                          { get; set; }
        public Length                                   Bottom                                  { get; set; }
        public DisplayStyle                             Display                                 { get; set; }
        public Length                                   FlexBasis                               { get; set; }
        public FlexDirection                            FlexDirection                           { get; set; }
        public float                                    FlexGrow                                { get; set; }
        public float                                    FlexShrink                              { get; set; }
        public Wrap                                     FlexWrap                                { get; set; }
        public Length                                   Height                                  { get; set; }
        public Justify                                  JustifyContent                          { get; set; }
        public Length                                   Left                                    { get; set; }
        public Length                                   MarginBottom                            { get; set; }
        public Length                                   MarginLeft                              { get; set; }
        public Length                                   MarginRight                             { get; set; }
        public Length                                   MarginTop                               { get; set; }
        public Length                                   MaxHeight                               { get; set; }
        public Length                                   MaxWidth                                { get; set; }
        public Length                                   MinHeight                               { get; set; }
        public Length                                   MinWidth                                { get; set; }
        public Length                                   PaddingBottom                           { get; set; }
        public Length                                   PaddingLeft                             { get; set; }
        public Length                                   PaddingRight                            { get; set; }
        public Length                                   PaddingTop                              { get; set; }
        public Position                                 Position                                { get; set; }
        public Length                                   Right                                   { get; set; }
        public Length                                   Top                                     { get; set; }
        public Length                                   Width                                   { get; set; }

        public static LayoutData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutData();

            value.AlignContent                              = (Align)GetInt32(new IntPtr(p + 0x010)); // 027003F1DA68 0x10 AlignContent                ( 0001866A22A0 ModelEnumType Align Align Align Int32 )
            value.AlignItems                                = (Align)GetInt32(new IntPtr(p + 0x014)); // 027003F1DA88 0x14 AlignItems                  ( 0001866A22A0 ModelEnumType Align Align Align Int32 )
            value.AlignSelf                                 = (Align)GetInt32(new IntPtr(p + 0x018)); // 027003F1DAA8 0x18 AlignSelf                   ( 0001866A22A0 ModelEnumType Align Align Align Int32 )
            value.BorderBottomWidth                         = GetSingle(new IntPtr(p + 0x01C)); // 027003F1DAC8 0x1C BorderBottomWidth           ( 000186666050 ModelPrimitiveType float float float Single )
            value.BorderLeftWidth                           = GetSingle(new IntPtr(p + 0x020)); // 027003F1DAE8 0x20 BorderLeftWidth             ( 000186666050 ModelPrimitiveType float float float Single )
            value.BorderRightWidth                          = GetSingle(new IntPtr(p + 0x024)); // 027003F1DB08 0x24 BorderRightWidth            ( 000186666050 ModelPrimitiveType float float float Single )
            value.BorderTopWidth                            = GetSingle(new IntPtr(p + 0x028)); // 027003F1DB28 0x28 BorderTopWidth              ( 000186666050 ModelPrimitiveType float float float Single )
            value.Bottom                                    = (Length)GetInt32(new IntPtr(p + 0x02C)); // 027003F1DB48 0x2C Bottom                      ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.Display                                   = (DisplayStyle)GetInt32(new IntPtr(p + 0x034)); // 027003F1DB68 0x34 Display                     ( 0001866DC8A0 ModelEnumType DisplayStyle DisplayStyle DisplayStyle Int32 )
            value.FlexBasis                                 = (Length)GetInt32(new IntPtr(p + 0x038)); // 027003F1DB88 0x38 FlexBasis                   ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.FlexDirection                             = (FlexDirection)GetInt32(new IntPtr(p + 0x040)); // 027003F1DBA8 0x40 FlexDirection               ( 0001865A3850 ModelEnumType FlexDirection FlexDirection FlexDirection Int32 )
            value.FlexGrow                                  = GetSingle(new IntPtr(p + 0x044)); // 027003F1DBC8 0x44 FlexGrow                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FlexShrink                                = GetSingle(new IntPtr(p + 0x048)); // 027003F1DBE8 0x48 FlexShrink                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.FlexWrap                                  = (Wrap)GetInt32(new IntPtr(p + 0x04C)); // 027003F1DC08 0x4C FlexWrap                    ( 00018655E6C0 ModelEnumType Wrap Wrap Wrap Int32 )
            value.Height                                    = (Length)GetInt32(new IntPtr(p + 0x050)); // 027003F1DC28 0x50 Height                      ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.JustifyContent                            = (Justify)GetInt32(new IntPtr(p + 0x058)); // 027003F1DC48 0x58 JustifyContent              ( 000186769B10 ModelEnumType Justify Justify Justify Int32 )
            value.Left                                      = (Length)GetInt32(new IntPtr(p + 0x05C)); // 027003F1DC68 0x5C Left                        ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MarginBottom                              = (Length)GetInt32(new IntPtr(p + 0x064)); // 027003F1DC88 0x64 MarginBottom                ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MarginLeft                                = (Length)GetInt32(new IntPtr(p + 0x06C)); // 027003F1DCA8 0x6C MarginLeft                  ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MarginRight                               = (Length)GetInt32(new IntPtr(p + 0x074)); // 027003F1DCC8 0x74 MarginRight                 ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MarginTop                                 = (Length)GetInt32(new IntPtr(p + 0x07C)); // 027003F1DCE8 0x7C MarginTop                   ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MaxHeight                                 = (Length)GetInt32(new IntPtr(p + 0x084)); // 027003F1DD08 0x84 MaxHeight                   ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MaxWidth                                  = (Length)GetInt32(new IntPtr(p + 0x08C)); // 027003F1DD28 0x8C MaxWidth                    ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MinHeight                                 = (Length)GetInt32(new IntPtr(p + 0x094)); // 027003F1DD48 0x94 MinHeight                   ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.MinWidth                                  = (Length)GetInt32(new IntPtr(p + 0x09C)); // 027003F1DD68 0x9C MinWidth                    ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.PaddingBottom                             = (Length)GetInt32(new IntPtr(p + 0x0A4)); // 027003F1DD88 0xA4 PaddingBottom               ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.PaddingLeft                               = (Length)GetInt32(new IntPtr(p + 0x0AC)); // 027003F1DDA8 0xAC PaddingLeft                 ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.PaddingRight                              = (Length)GetInt32(new IntPtr(p + 0x0B4)); // 027003F1DDC8 0xB4 PaddingRight                ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.PaddingTop                                = (Length)GetInt32(new IntPtr(p + 0x0BC)); // 027003F1DDE8 0xBC PaddingTop                  ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.Position                                  = (Position)GetInt32(new IntPtr(p + 0x0C4)); // 027003F1DE08 0xC4 Position                    ( 000186767A00 ModelEnumType Position Position Position Int32 )
            value.Right                                     = (Length)GetInt32(new IntPtr(p + 0x0C8)); // 027003F1DE28 0xC8 Right                       ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.Top                                       = (Length)GetInt32(new IntPtr(p + 0x0D0)); // 027003F1DE48 0xD0 Top                         ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.Width                                     = (Length)GetInt32(new IntPtr(p + 0x0D8)); // 027003F1DE68 0xD8 Width                       ( 0001866063F0 ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
