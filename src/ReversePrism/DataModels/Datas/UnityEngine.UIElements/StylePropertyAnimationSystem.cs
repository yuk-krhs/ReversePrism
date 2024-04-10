using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CurrentTimeMs                          0001865F7700 ModelPrimitiveType long long long Int64
    // 018 M_Floats                                 00018659F1C0 ModelClassType ValuesFloat ValuesFloat ValuesFloat Pointer
    // 020 M_Ints                                   0001865A0070 ModelClassType ValuesInt ValuesInt ValuesInt Pointer
    // 028 M_Lengths                                0001865A0550 ModelClassType ValuesLength ValuesLength ValuesLength Pointer
    // 030 M_Colors                                 00018659EA60 ModelClassType ValuesColor ValuesColor ValuesColor Pointer
    // 038 M_Backgrounds                            00018659D6D0 ModelClassType ValuesBackground ValuesBackground ValuesBackground Pointer
    // 040 M_FontDefinitions                        00018659FB80 ModelClassType ValuesFontDefinition ValuesFontDefinition ValuesFontDefinition Pointer
    // 048 M_Fonts                                  00018659F6A0 ModelClassType ValuesFont ValuesFont ValuesFont Pointer
    // 050 M_TextShadows                            0001865A1430 ModelClassType ValuesTextShadow ValuesTextShadow ValuesTextShadow Pointer
    // 058 M_Scale                                  0001865A0F30 ModelClassType ValuesScale ValuesScale ValuesScale Pointer
    // 060 M_Rotate                                 0001865A0A30 ModelClassType ValuesRotate ValuesRotate ValuesRotate Pointer
    // 068 M_Translate                              0001865A1DE0 ModelClassType ValuesTranslate ValuesTranslate ValuesTranslate Pointer
    // 070 M_TransformOrigin                        0001865A1910 ModelClassType ValuesTransformOrigin ValuesTransformOrigin ValuesTransformOrigin Pointer
    // 078 M_BackgroundPosition                     00018659DBB0 ModelClassType ValuesBackgroundPosition ValuesBackgroundPosition ValuesBackgroundPosition Pointer
    // 080 M_BackgroundRepeat                       00018659E0D0 ModelClassType ValuesBackgroundRepeat ValuesBackgroundRepeat ValuesBackgroundRepeat Pointer
    // 088 M_BackgroundSize                         00018659E560 ModelClassType ValuesBackgroundSize ValuesBackgroundSize ValuesBackgroundSize Pointer
    // 090 M_AllValues                              000185D2C3C8 ModelClassListType List`1<Values> List`1<Values> List<Values> Pointer
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

            value.M_CurrentTimeMs                           = GetInt64(new IntPtr(p + 0x010)); // 0245A67BDD70 0x10 M_CurrentTimeMs             ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_Floats                                  = GetObject<ValuesFloat>(new IntPtr(p + 0x018), ReversePrism.DataModels.ValuesFloat.FromPointer); // 0245A67BDD90 0x18 M_Floats                    ( 00018659F1C0 ModelClassType ValuesFloat ValuesFloat ValuesFloat Pointer )
            value.M_Ints                                    = GetObject<ValuesInt>(new IntPtr(p + 0x020), ReversePrism.DataModels.ValuesInt.FromPointer); // 0245A67BDDB0 0x20 M_Ints                      ( 0001865A0070 ModelClassType ValuesInt ValuesInt ValuesInt Pointer )
            value.M_Lengths                                 = GetObject<ValuesLength>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValuesLength.FromPointer); // 0245A67BDDD0 0x28 M_Lengths                   ( 0001865A0550 ModelClassType ValuesLength ValuesLength ValuesLength Pointer )
            value.M_Colors                                  = GetObject<ValuesColor>(new IntPtr(p + 0x030), ReversePrism.DataModels.ValuesColor.FromPointer); // 0245A67BDDF0 0x30 M_Colors                    ( 00018659EA60 ModelClassType ValuesColor ValuesColor ValuesColor Pointer )
            value.M_Backgrounds                             = GetObject<ValuesBackground>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValuesBackground.FromPointer); // 0245A67BDE10 0x38 M_Backgrounds               ( 00018659D6D0 ModelClassType ValuesBackground ValuesBackground ValuesBackground Pointer )
            value.M_FontDefinitions                         = GetObject<ValuesFontDefinition>(new IntPtr(p + 0x040), ReversePrism.DataModels.ValuesFontDefinition.FromPointer); // 0245A67BDE30 0x40 M_FontDefinitions           ( 00018659FB80 ModelClassType ValuesFontDefinition ValuesFontDefinition ValuesFontDefinition Pointer )
            value.M_Fonts                                   = GetObject<ValuesFont>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValuesFont.FromPointer); // 0245A67BDE50 0x48 M_Fonts                     ( 00018659F6A0 ModelClassType ValuesFont ValuesFont ValuesFont Pointer )
            value.M_TextShadows                             = GetObject<ValuesTextShadow>(new IntPtr(p + 0x050), ReversePrism.DataModels.ValuesTextShadow.FromPointer); // 0245A67BDE70 0x50 M_TextShadows               ( 0001865A1430 ModelClassType ValuesTextShadow ValuesTextShadow ValuesTextShadow Pointer )
            value.M_Scale                                   = GetObject<ValuesScale>(new IntPtr(p + 0x058), ReversePrism.DataModels.ValuesScale.FromPointer); // 0245A67BDE90 0x58 M_Scale                     ( 0001865A0F30 ModelClassType ValuesScale ValuesScale ValuesScale Pointer )
            value.M_Rotate                                  = GetObject<ValuesRotate>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValuesRotate.FromPointer); // 0245A67BDEB0 0x60 M_Rotate                    ( 0001865A0A30 ModelClassType ValuesRotate ValuesRotate ValuesRotate Pointer )
            value.M_Translate                               = GetObject<ValuesTranslate>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValuesTranslate.FromPointer); // 0245A67BDED0 0x68 M_Translate                 ( 0001865A1DE0 ModelClassType ValuesTranslate ValuesTranslate ValuesTranslate Pointer )
            value.M_TransformOrigin                         = GetObject<ValuesTransformOrigin>(new IntPtr(p + 0x070), ReversePrism.DataModels.ValuesTransformOrigin.FromPointer); // 0245A67BDEF0 0x70 M_TransformOrigin           ( 0001865A1910 ModelClassType ValuesTransformOrigin ValuesTransformOrigin ValuesTransformOrigin Pointer )
            value.M_BackgroundPosition                      = GetObject<ValuesBackgroundPosition>(new IntPtr(p + 0x078), ReversePrism.DataModels.ValuesBackgroundPosition.FromPointer); // 0245A67BDF10 0x78 M_BackgroundPosition        ( 00018659DBB0 ModelClassType ValuesBackgroundPosition ValuesBackgroundPosition ValuesBackgroundPosition Pointer )
            value.M_BackgroundRepeat                        = GetObject<ValuesBackgroundRepeat>(new IntPtr(p + 0x080), ReversePrism.DataModels.ValuesBackgroundRepeat.FromPointer); // 0245A67BDF30 0x80 M_BackgroundRepeat          ( 00018659E0D0 ModelClassType ValuesBackgroundRepeat ValuesBackgroundRepeat ValuesBackgroundRepeat Pointer )
            value.M_BackgroundSize                          = GetObject<ValuesBackgroundSize>(new IntPtr(p + 0x088), ReversePrism.DataModels.ValuesBackgroundSize.FromPointer); // 0245A67BDF50 0x88 M_BackgroundSize            ( 00018659E560 ModelClassType ValuesBackgroundSize ValuesBackgroundSize ValuesBackgroundSize Pointer )
            value.M_AllValues                               = GetObjectList<Values>(new IntPtr(p + 0x090), ReversePrism.DataModels.Values.FromPointer); // 0245A67BDF70 0x90 M_AllValues                 ( 000185D2C3C8 ModelClassListType List`1<Values> List`1<Values> List<Values> Pointer )

            return value;
        }
    }
}
