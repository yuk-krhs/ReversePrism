using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CurrentTimeMs                          ModelPrimitiveType long long long Int64
    // 018 M_Floats                                 ModelClassType ValuesFloat ValuesFloat ValuesFloat Pointer
    // 020 M_Ints                                   ModelClassType ValuesInt ValuesInt ValuesInt Pointer
    // 028 M_Lengths                                ModelClassType ValuesLength ValuesLength ValuesLength Pointer
    // 030 M_Colors                                 ModelClassType ValuesColor ValuesColor ValuesColor Pointer
    // 038 M_Backgrounds                            ModelClassType ValuesBackground ValuesBackground ValuesBackground Pointer
    // 040 M_FontDefinitions                        ModelClassType ValuesFontDefinition ValuesFontDefinition ValuesFontDefinition Pointer
    // 048 M_Fonts                                  ModelClassType ValuesFont ValuesFont ValuesFont Pointer
    // 050 M_TextShadows                            ModelClassType ValuesTextShadow ValuesTextShadow ValuesTextShadow Pointer
    // 058 M_Scale                                  ModelClassType ValuesScale ValuesScale ValuesScale Pointer
    // 060 M_Rotate                                 ModelClassType ValuesRotate ValuesRotate ValuesRotate Pointer
    // 068 M_Translate                              ModelClassType ValuesTranslate ValuesTranslate ValuesTranslate Pointer
    // 070 M_TransformOrigin                        ModelClassType ValuesTransformOrigin ValuesTransformOrigin ValuesTransformOrigin Pointer
    // 078 M_BackgroundPosition                     ModelClassType ValuesBackgroundPosition ValuesBackgroundPosition ValuesBackgroundPosition Pointer
    // 080 M_BackgroundRepeat                       ModelClassType ValuesBackgroundRepeat ValuesBackgroundRepeat ValuesBackgroundRepeat Pointer
    // 088 M_BackgroundSize                         ModelClassType ValuesBackgroundSize ValuesBackgroundSize ValuesBackgroundSize Pointer
    // 090 M_AllValues                              ModelClassListType List`1<Values> List`1<Values> List<Values> Pointer
    // 098 m_PropertyToValues                       Dictionary`2<StylePropertyId, Values> IL2CPP_TYPE_GENERICINST
    public partial class StylePropertyAnimationSystem : DataModel
    {
        public long                                     M_CurrentTimeMs                         { get; set; }
        public ValuesFloat?                             M_Floats                                { get; set; }
        public ValuesInt?                               M_Ints                                  { get; set; }
        public ValuesLength?                            M_Lengths                               { get; set; }
        public ValuesColor?                             M_Colors                                { get; set; }
        public ValuesBackground?                        M_Backgrounds                           { get; set; }
        public ValuesFontDefinition?                    M_FontDefinitions                       { get; set; }
        public ValuesFont?                              M_Fonts                                 { get; set; }
        public ValuesTextShadow?                        M_TextShadows                           { get; set; }
        public ValuesScale?                             M_Scale                                 { get; set; }
        public ValuesRotate?                            M_Rotate                                { get; set; }
        public ValuesTranslate?                         M_Translate                             { get; set; }
        public ValuesTransformOrigin?                   M_TransformOrigin                       { get; set; }
        public ValuesBackgroundPosition?                M_BackgroundPosition                    { get; set; }
        public ValuesBackgroundRepeat?                  M_BackgroundRepeat                      { get; set; }
        public ValuesBackgroundSize?                    M_BackgroundSize                        { get; set; }
        public List<Values>?                            M_AllValues                             { get; set; }

        public static StylePropertyAnimationSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyAnimationSystem() { Pointer= p0 };

            value.M_CurrentTimeMs                           = GetInt64(new IntPtr(p + 0x010)); // 0x10 M_CurrentTimeMs             ( ModelPrimitiveType long long long Int64 )
            value.M_Floats                                  = GetObject<ValuesFloat>(new IntPtr(p + 0x018), ReversePrism.DataModels.ValuesFloat.FromPointer); // 0x18 M_Floats                    ( ModelClassType ValuesFloat ValuesFloat ValuesFloat Pointer )
            value.M_Ints                                    = GetObject<ValuesInt>(new IntPtr(p + 0x020), ReversePrism.DataModels.ValuesInt.FromPointer); // 0x20 M_Ints                      ( ModelClassType ValuesInt ValuesInt ValuesInt Pointer )
            value.M_Lengths                                 = GetObject<ValuesLength>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValuesLength.FromPointer); // 0x28 M_Lengths                   ( ModelClassType ValuesLength ValuesLength ValuesLength Pointer )
            value.M_Colors                                  = GetObject<ValuesColor>(new IntPtr(p + 0x030), ReversePrism.DataModels.ValuesColor.FromPointer); // 0x30 M_Colors                    ( ModelClassType ValuesColor ValuesColor ValuesColor Pointer )
            value.M_Backgrounds                             = GetObject<ValuesBackground>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValuesBackground.FromPointer); // 0x38 M_Backgrounds               ( ModelClassType ValuesBackground ValuesBackground ValuesBackground Pointer )
            value.M_FontDefinitions                         = GetObject<ValuesFontDefinition>(new IntPtr(p + 0x040), ReversePrism.DataModels.ValuesFontDefinition.FromPointer); // 0x40 M_FontDefinitions           ( ModelClassType ValuesFontDefinition ValuesFontDefinition ValuesFontDefinition Pointer )
            value.M_Fonts                                   = GetObject<ValuesFont>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValuesFont.FromPointer); // 0x48 M_Fonts                     ( ModelClassType ValuesFont ValuesFont ValuesFont Pointer )
            value.M_TextShadows                             = GetObject<ValuesTextShadow>(new IntPtr(p + 0x050), ReversePrism.DataModels.ValuesTextShadow.FromPointer); // 0x50 M_TextShadows               ( ModelClassType ValuesTextShadow ValuesTextShadow ValuesTextShadow Pointer )
            value.M_Scale                                   = GetObject<ValuesScale>(new IntPtr(p + 0x058), ReversePrism.DataModels.ValuesScale.FromPointer); // 0x58 M_Scale                     ( ModelClassType ValuesScale ValuesScale ValuesScale Pointer )
            value.M_Rotate                                  = GetObject<ValuesRotate>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValuesRotate.FromPointer); // 0x60 M_Rotate                    ( ModelClassType ValuesRotate ValuesRotate ValuesRotate Pointer )
            value.M_Translate                               = GetObject<ValuesTranslate>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValuesTranslate.FromPointer); // 0x68 M_Translate                 ( ModelClassType ValuesTranslate ValuesTranslate ValuesTranslate Pointer )
            value.M_TransformOrigin                         = GetObject<ValuesTransformOrigin>(new IntPtr(p + 0x070), ReversePrism.DataModels.ValuesTransformOrigin.FromPointer); // 0x70 M_TransformOrigin           ( ModelClassType ValuesTransformOrigin ValuesTransformOrigin ValuesTransformOrigin Pointer )
            value.M_BackgroundPosition                      = GetObject<ValuesBackgroundPosition>(new IntPtr(p + 0x078), ReversePrism.DataModels.ValuesBackgroundPosition.FromPointer); // 0x78 M_BackgroundPosition        ( ModelClassType ValuesBackgroundPosition ValuesBackgroundPosition ValuesBackgroundPosition Pointer )
            value.M_BackgroundRepeat                        = GetObject<ValuesBackgroundRepeat>(new IntPtr(p + 0x080), ReversePrism.DataModels.ValuesBackgroundRepeat.FromPointer); // 0x80 M_BackgroundRepeat          ( ModelClassType ValuesBackgroundRepeat ValuesBackgroundRepeat ValuesBackgroundRepeat Pointer )
            value.M_BackgroundSize                          = GetObject<ValuesBackgroundSize>(new IntPtr(p + 0x088), ReversePrism.DataModels.ValuesBackgroundSize.FromPointer); // 0x88 M_BackgroundSize            ( ModelClassType ValuesBackgroundSize ValuesBackgroundSize ValuesBackgroundSize Pointer )
            value.M_AllValues                               = GetObjectList<Values>(new IntPtr(p + 0x090), ReversePrism.DataModels.Values.FromPointer); // 0x90 M_AllValues                 ( ModelClassListType List`1<Values> List`1<Values> List<Values> Pointer )

            return value;
        }
    }
}
