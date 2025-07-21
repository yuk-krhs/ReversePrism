using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_StylePropertyReader                    StylePropertyReader IL2CPP_TYPE_CLASS
    // 018 M_ValuesManaged                          ModelEnumListType List`1<StyleValueManaged> List`1<StyleValueManaged> List<StyleValueManaged> Pointer
    // 020 Ve                                       ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 M_HasInlineCursor                        ModelPrimitiveType bool bool bool Bool
    // 030 M_InlineCursor                           ModelEnumType StyleCursor StyleCursor StyleCursor Int32
    // 050 M_HasInlineTextShadow                    ModelPrimitiveType bool bool bool Bool
    // 054 M_InlineTextShadow                       ModelEnumType StyleTextShadow StyleTextShadow StyleTextShadow Int32
    // 074 M_HasInlineTransformOrigin               ModelPrimitiveType bool bool bool Bool
    // 078 M_InlineTransformOrigin                  ModelEnumType StyleTransformOrigin StyleTransformOrigin StyleTransformOrigin Int32
    // 090 M_HasInlineTranslate                     ModelPrimitiveType bool bool bool Bool
    // 094 M_InlineTranslateOperation               ModelEnumType StyleTranslate StyleTranslate StyleTranslate Int32
    // 0B0 M_HasInlineRotate                        ModelPrimitiveType bool bool bool Bool
    // 0B4 M_InlineRotateOperation                  ModelEnumType StyleRotate StyleRotate StyleRotate Int32
    // 0D0 M_HasInlineScale                         ModelPrimitiveType bool bool bool Bool
    // 0D4 M_InlineScale                            ModelEnumType StyleScale StyleScale StyleScale Int32
    // 0E8 M_HasInlineBackgroundSize                ModelPrimitiveType bool bool bool Bool
    // 0EC M_InlineBackgroundSize                   ModelEnumType StyleBackgroundSize StyleBackgroundSize StyleBackgroundSize Int32
    // 108 M_InlineRule                             ModelEnumType InlineRule InlineRule InlineRule Int32
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

            value.M_ValuesManaged                           = GetEnumList<StyleValueManaged>(new IntPtr(p + 0x018)); // 0x18 M_ValuesManaged             ( ModelEnumListType List`1<StyleValueManaged> List`1<StyleValueManaged> List<StyleValueManaged> Pointer )
            value.Ve                                        = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 0x20 Ve                          ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_HasInlineCursor                         = GetBool(new IntPtr(p + 0x028)); // 0x28 M_HasInlineCursor           ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineCursor                            = (StyleCursor)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_InlineCursor              ( ModelEnumType StyleCursor StyleCursor StyleCursor Int32 )
            value.M_HasInlineTextShadow                     = GetBool(new IntPtr(p + 0x050)); // 0x50 M_HasInlineTextShadow       ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineTextShadow                        = (StyleTextShadow)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_InlineTextShadow          ( ModelEnumType StyleTextShadow StyleTextShadow StyleTextShadow Int32 )
            value.M_HasInlineTransformOrigin                = GetBool(new IntPtr(p + 0x074)); // 0x74 M_HasInlineTransformOrigin  ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineTransformOrigin                   = (StyleTransformOrigin)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_InlineTransformOrigin     ( ModelEnumType StyleTransformOrigin StyleTransformOrigin StyleTransformOrigin Int32 )
            value.M_HasInlineTranslate                      = GetBool(new IntPtr(p + 0x090)); // 0x90 M_HasInlineTranslate        ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineTranslateOperation                = (StyleTranslate)GetInt32(new IntPtr(p + 0x094)); // 0x94 M_InlineTranslateOperation  ( ModelEnumType StyleTranslate StyleTranslate StyleTranslate Int32 )
            value.M_HasInlineRotate                         = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 M_HasInlineRotate           ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineRotateOperation                   = (StyleRotate)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 M_InlineRotateOperation     ( ModelEnumType StyleRotate StyleRotate StyleRotate Int32 )
            value.M_HasInlineScale                          = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 M_HasInlineScale            ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineScale                             = (StyleScale)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 M_InlineScale               ( ModelEnumType StyleScale StyleScale StyleScale Int32 )
            value.M_HasInlineBackgroundSize                 = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 M_HasInlineBackgroundSize   ( ModelPrimitiveType bool bool bool Bool )
            value.M_InlineBackgroundSize                    = (StyleBackgroundSize)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC M_InlineBackgroundSize      ( ModelEnumType StyleBackgroundSize StyleBackgroundSize StyleBackgroundSize Int32 )
            value.M_InlineRule                              = (InlineRule)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_InlineRule                ( ModelEnumType InlineRule InlineRule InlineRule Int32 )

            return value;
        }
    }
}
