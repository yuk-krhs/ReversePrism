using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlignContent                             ModelEnumType Align Align Align Int32
    // 014 AlignItems                               ModelEnumType Align Align Align Int32
    // 018 AlignSelf                                ModelEnumType Align Align Align Int32
    // 01C BorderBottomWidth                        ModelPrimitiveType float float float Single
    // 020 BorderLeftWidth                          ModelPrimitiveType float float float Single
    // 024 BorderRightWidth                         ModelPrimitiveType float float float Single
    // 028 BorderTopWidth                           ModelPrimitiveType float float float Single
    // 02C Bottom                                   ModelEnumType Length Length Length Int32
    // 034 Display                                  ModelEnumType DisplayStyle DisplayStyle DisplayStyle Int32
    // 038 FlexBasis                                ModelEnumType Length Length Length Int32
    // 040 FlexDirection                            ModelEnumType FlexDirection FlexDirection FlexDirection Int32
    // 044 FlexGrow                                 ModelPrimitiveType float float float Single
    // 048 FlexShrink                               ModelPrimitiveType float float float Single
    // 04C FlexWrap                                 ModelEnumType Wrap Wrap Wrap Int32
    // 050 Height                                   ModelEnumType Length Length Length Int32
    // 058 JustifyContent                           ModelEnumType Justify Justify Justify Int32
    // 05C Left                                     ModelEnumType Length Length Length Int32
    // 064 MarginBottom                             ModelEnumType Length Length Length Int32
    // 06C MarginLeft                               ModelEnumType Length Length Length Int32
    // 074 MarginRight                              ModelEnumType Length Length Length Int32
    // 07C MarginTop                                ModelEnumType Length Length Length Int32
    // 084 MaxHeight                                ModelEnumType Length Length Length Int32
    // 08C MaxWidth                                 ModelEnumType Length Length Length Int32
    // 094 MinHeight                                ModelEnumType Length Length Length Int32
    // 09C MinWidth                                 ModelEnumType Length Length Length Int32
    // 0A4 PaddingBottom                            ModelEnumType Length Length Length Int32
    // 0AC PaddingLeft                              ModelEnumType Length Length Length Int32
    // 0B4 PaddingRight                             ModelEnumType Length Length Length Int32
    // 0BC PaddingTop                               ModelEnumType Length Length Length Int32
    // 0C4 Position                                 ModelEnumType Position Position Position Int32
    // 0C8 Right                                    ModelEnumType Length Length Length Int32
    // 0D0 Top                                      ModelEnumType Length Length Length Int32
    // 0D8 Width                                    ModelEnumType Length Length Length Int32
    public partial class LayoutData : DataModel
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
            var value   = new LayoutData() { Pointer= p0 };

            value.AlignContent                              = (Align)GetInt32(new IntPtr(p + 0x010)); // 0x10 AlignContent                ( ModelEnumType Align Align Align Int32 )
            value.AlignItems                                = (Align)GetInt32(new IntPtr(p + 0x014)); // 0x14 AlignItems                  ( ModelEnumType Align Align Align Int32 )
            value.AlignSelf                                 = (Align)GetInt32(new IntPtr(p + 0x018)); // 0x18 AlignSelf                   ( ModelEnumType Align Align Align Int32 )
            value.BorderBottomWidth                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C BorderBottomWidth           ( ModelPrimitiveType float float float Single )
            value.BorderLeftWidth                           = GetSingle(new IntPtr(p + 0x020)); // 0x20 BorderLeftWidth             ( ModelPrimitiveType float float float Single )
            value.BorderRightWidth                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 BorderRightWidth            ( ModelPrimitiveType float float float Single )
            value.BorderTopWidth                            = GetSingle(new IntPtr(p + 0x028)); // 0x28 BorderTopWidth              ( ModelPrimitiveType float float float Single )
            value.Bottom                                    = (Length)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Bottom                      ( ModelEnumType Length Length Length Int32 )
            value.Display                                   = (DisplayStyle)GetInt32(new IntPtr(p + 0x034)); // 0x34 Display                     ( ModelEnumType DisplayStyle DisplayStyle DisplayStyle Int32 )
            value.FlexBasis                                 = (Length)GetInt32(new IntPtr(p + 0x038)); // 0x38 FlexBasis                   ( ModelEnumType Length Length Length Int32 )
            value.FlexDirection                             = (FlexDirection)GetInt32(new IntPtr(p + 0x040)); // 0x40 FlexDirection               ( ModelEnumType FlexDirection FlexDirection FlexDirection Int32 )
            value.FlexGrow                                  = GetSingle(new IntPtr(p + 0x044)); // 0x44 FlexGrow                    ( ModelPrimitiveType float float float Single )
            value.FlexShrink                                = GetSingle(new IntPtr(p + 0x048)); // 0x48 FlexShrink                  ( ModelPrimitiveType float float float Single )
            value.FlexWrap                                  = (Wrap)GetInt32(new IntPtr(p + 0x04C)); // 0x4C FlexWrap                    ( ModelEnumType Wrap Wrap Wrap Int32 )
            value.Height                                    = (Length)GetInt32(new IntPtr(p + 0x050)); // 0x50 Height                      ( ModelEnumType Length Length Length Int32 )
            value.JustifyContent                            = (Justify)GetInt32(new IntPtr(p + 0x058)); // 0x58 JustifyContent              ( ModelEnumType Justify Justify Justify Int32 )
            value.Left                                      = (Length)GetInt32(new IntPtr(p + 0x05C)); // 0x5C Left                        ( ModelEnumType Length Length Length Int32 )
            value.MarginBottom                              = (Length)GetInt32(new IntPtr(p + 0x064)); // 0x64 MarginBottom                ( ModelEnumType Length Length Length Int32 )
            value.MarginLeft                                = (Length)GetInt32(new IntPtr(p + 0x06C)); // 0x6C MarginLeft                  ( ModelEnumType Length Length Length Int32 )
            value.MarginRight                               = (Length)GetInt32(new IntPtr(p + 0x074)); // 0x74 MarginRight                 ( ModelEnumType Length Length Length Int32 )
            value.MarginTop                                 = (Length)GetInt32(new IntPtr(p + 0x07C)); // 0x7C MarginTop                   ( ModelEnumType Length Length Length Int32 )
            value.MaxHeight                                 = (Length)GetInt32(new IntPtr(p + 0x084)); // 0x84 MaxHeight                   ( ModelEnumType Length Length Length Int32 )
            value.MaxWidth                                  = (Length)GetInt32(new IntPtr(p + 0x08C)); // 0x8C MaxWidth                    ( ModelEnumType Length Length Length Int32 )
            value.MinHeight                                 = (Length)GetInt32(new IntPtr(p + 0x094)); // 0x94 MinHeight                   ( ModelEnumType Length Length Length Int32 )
            value.MinWidth                                  = (Length)GetInt32(new IntPtr(p + 0x09C)); // 0x9C MinWidth                    ( ModelEnumType Length Length Length Int32 )
            value.PaddingBottom                             = (Length)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 PaddingBottom               ( ModelEnumType Length Length Length Int32 )
            value.PaddingLeft                               = (Length)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC PaddingLeft                 ( ModelEnumType Length Length Length Int32 )
            value.PaddingRight                              = (Length)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 PaddingRight                ( ModelEnumType Length Length Length Int32 )
            value.PaddingTop                                = (Length)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC PaddingTop                  ( ModelEnumType Length Length Length Int32 )
            value.Position                                  = (Position)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 Position                    ( ModelEnumType Position Position Position Int32 )
            value.Right                                     = (Length)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 Right                       ( ModelEnumType Length Length Length Int32 )
            value.Top                                       = (Length)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Top                         ( ModelEnumType Length Length Length Int32 )
            value.Width                                     = (Length)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 Width                       ( ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
