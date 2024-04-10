using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_StylePropertyReader                    StylePropertyReader IL2CPP_TYPE_CLASS
    // 018 M_ValuesManaged                          000185D0F2F8 ModelEnumListType List`1<StyleValueManaged> List`1<StyleValueManaged> List<StyleValueManaged> Pointer
    // 020 Ve                                       0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 M_HasInlineCursor                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_InlineCursor                           0001866798E0 ModelEnumType StyleCursor StyleCursor StyleCursor Int32
    // 050 M_HasInlineTextShadow                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 M_InlineTextShadow                       00018667B3D0 ModelEnumType StyleTextShadow StyleTextShadow StyleTextShadow Int32
    // 074 M_HasInlineTransformOrigin               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 M_InlineTransformOrigin                  00018667BAF0 ModelEnumType StyleTransformOrigin StyleTransformOrigin StyleTransformOrigin Int32
    // 090 M_HasInlineTranslate                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 M_InlineTranslateOperation               00018667C2A0 ModelEnumType StyleTranslate StyleTranslate StyleTranslate Int32
    // 0B0 M_HasInlineRotate                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B4 M_InlineRotateOperation                  00018667A560 ModelEnumType StyleRotate StyleRotate StyleRotate Int32
    // 0D0 M_HasInlineScale                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D4 M_InlineScale                            00018667AC60 ModelEnumType StyleScale StyleScale StyleScale Int32
    // 0E8 M_HasInlineBackgroundSize                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0EC M_InlineBackgroundSize                   000186679210 ModelEnumType StyleBackgroundSize StyleBackgroundSize StyleBackgroundSize Int32
    // 108 M_InlineRule                             00018661CFB0 ModelEnumType InlineRule InlineRule InlineRule Int32
    public partial class InlineStyleAccess : DataModel
    {
        public List<StyleValueManaged>?                 M_ValuesManaged                         { get; set; }
        public VisualElement?                           Ve                                      { get; set; }
        public bool                                     M_HasInlineCursor                       { get; set; }
        public StyleCursor                              M_InlineCursor                          { get; set; }
        public bool                                     M_HasInlineTextShadow                   { get; set; }
        public StyleTextShadow                          M_InlineTextShadow                      { get; set; }
        public bool                                     M_HasInlineTransformOrigin              { get; set; }
        public StyleTransformOrigin                     M_InlineTransformOrigin                 { get; set; }
        public bool                                     M_HasInlineTranslate                    { get; set; }
        public StyleTranslate                           M_InlineTranslateOperation              { get; set; }
        public bool                                     M_HasInlineRotate                       { get; set; }
        public StyleRotate                              M_InlineRotateOperation                 { get; set; }
        public bool                                     M_HasInlineScale                        { get; set; }
        public StyleScale                               M_InlineScale                           { get; set; }
        public bool                                     M_HasInlineBackgroundSize               { get; set; }
        public StyleBackgroundSize                      M_InlineBackgroundSize                  { get; set; }
        public InlineRule                               M_InlineRule                            { get; set; }

        public static InlineStyleAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InlineStyleAccess() { Pointer= p0 };

            value.M_ValuesManaged                           = GetEnumList<StyleValueManaged>(new IntPtr(p + 0x018)); // 0245A67AEFF0 0x18 M_ValuesManaged             ( 000185D0F2F8 ModelEnumListType List`1<StyleValueManaged> List`1<StyleValueManaged> List<StyleValueManaged> Pointer )
            value.Ve                                        = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A67AF010 0x20 Ve                          ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_HasInlineCursor                         = GetBool(new IntPtr(p + 0x028)); // 0245A67AF030 0x28 M_HasInlineCursor           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineCursor                            = (StyleCursor)GetInt32(new IntPtr(p + 0x030)); // 0245A67AF050 0x30 M_InlineCursor              ( 0001866798E0 ModelEnumType StyleCursor StyleCursor StyleCursor Int32 )
            value.M_HasInlineTextShadow                     = GetBool(new IntPtr(p + 0x050)); // 0245A67AF070 0x50 M_HasInlineTextShadow       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineTextShadow                        = (StyleTextShadow)GetInt32(new IntPtr(p + 0x054)); // 0245A67AF090 0x54 M_InlineTextShadow          ( 00018667B3D0 ModelEnumType StyleTextShadow StyleTextShadow StyleTextShadow Int32 )
            value.M_HasInlineTransformOrigin                = GetBool(new IntPtr(p + 0x074)); // 0245A67AF0B0 0x74 M_HasInlineTransformOrigin  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineTransformOrigin                   = (StyleTransformOrigin)GetInt32(new IntPtr(p + 0x078)); // 0245A67AF0D0 0x78 M_InlineTransformOrigin     ( 00018667BAF0 ModelEnumType StyleTransformOrigin StyleTransformOrigin StyleTransformOrigin Int32 )
            value.M_HasInlineTranslate                      = GetBool(new IntPtr(p + 0x090)); // 0245A67AF0F0 0x90 M_HasInlineTranslate        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineTranslateOperation                = (StyleTranslate)GetInt32(new IntPtr(p + 0x094)); // 0245A67AF110 0x94 M_InlineTranslateOperation  ( 00018667C2A0 ModelEnumType StyleTranslate StyleTranslate StyleTranslate Int32 )
            value.M_HasInlineRotate                         = GetBool(new IntPtr(p + 0x0B0)); // 0245A67AF130 0xB0 M_HasInlineRotate           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineRotateOperation                   = (StyleRotate)GetInt32(new IntPtr(p + 0x0B4)); // 0245A67AF150 0xB4 M_InlineRotateOperation     ( 00018667A560 ModelEnumType StyleRotate StyleRotate StyleRotate Int32 )
            value.M_HasInlineScale                          = GetBool(new IntPtr(p + 0x0D0)); // 0245A67AF170 0xD0 M_HasInlineScale            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineScale                             = (StyleScale)GetInt32(new IntPtr(p + 0x0D4)); // 0245A67AF190 0xD4 M_InlineScale               ( 00018667AC60 ModelEnumType StyleScale StyleScale StyleScale Int32 )
            value.M_HasInlineBackgroundSize                 = GetBool(new IntPtr(p + 0x0E8)); // 0245A67AF1B0 0xE8 M_HasInlineBackgroundSize   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InlineBackgroundSize                    = (StyleBackgroundSize)GetInt32(new IntPtr(p + 0x0EC)); // 0245A67AF1D0 0xEC M_InlineBackgroundSize      ( 000186679210 ModelEnumType StyleBackgroundSize StyleBackgroundSize StyleBackgroundSize Int32 )
            value.M_InlineRule                              = (InlineRule)GetInt32(new IntPtr(p + 0x108)); // 0245A67AF1F0 0x108 M_InlineRule                ( 00018661CFB0 ModelEnumType InlineRule InlineRule InlineRule Int32 )

            return value;
        }
    }
}
