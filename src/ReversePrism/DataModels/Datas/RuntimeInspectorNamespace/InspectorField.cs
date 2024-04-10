using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LayoutElement                            00018650C5A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 028 VariableNameText                         000186631E10 ModelClassType Text Text Text Pointer
    // 030 VariableNameMask                         0001866CD000 ModelClassType Image Image Image Pointer
    // 038 VisibleArea                              0001865D8B60 ModelClassType MaskableGraphic MaskableGraphic MaskableGraphic Pointer
    // 040 M_inspector                              00018669ADC0 ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer
    // 048 M_skinVersion                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 M_skin                                   0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 058 M_boundVariableType                      000186692850 ModelClassType Type Type Type Pointer
    // 060 m_value                                  <object> IL2CPP_TYPE_OBJECT
    // 068 M_depth                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C M_isVisible                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 Getter                                   000186640A10 ModelClassType Getter Getter Getter Pointer
    // 078 Setter                                   000186640ED0 ModelClassType Setter Setter Setter Pointer
    public partial class InspectorField : DataModel
    {
        public LayoutElement?                           LayoutElement                           { get; set; }
        public Text?                                    VariableNameText                        { get; set; }
        public Image?                                   VariableNameMask                        { get; set; }
        public MaskableGraphic?                         VisibleArea                             { get; set; }
        public RuntimeInspector?                        M_inspector                             { get; set; }
        public int                                      M_skinVersion                           { get; set; }
        public UISkin?                                  M_skin                                  { get; set; }
        public Type?                                    M_boundVariableType                     { get; set; }
        public int                                      M_depth                                 { get; set; }
        public bool                                     M_isVisible                             { get; set; }
        public Getter?                                  Getter                                  { get; set; }
        public Setter?                                  Setter                                  { get; set; }

        public static InspectorField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectorField() { Pointer= p0 };

            value.LayoutElement                             = GetObject<LayoutElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.LayoutElement.FromPointer); // 02466B21E108 0x20 LayoutElement               ( 00018650C5A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.VariableNameText                          = GetObject<Text>(new IntPtr(p + 0x028), ReversePrism.DataModels.Text.FromPointer); // 02466B21E128 0x28 VariableNameText            ( 000186631E10 ModelClassType Text Text Text Pointer )
            value.VariableNameMask                          = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 02466B21E148 0x30 VariableNameMask            ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.VisibleArea                               = GetObject<MaskableGraphic>(new IntPtr(p + 0x038), ReversePrism.DataModels.MaskableGraphic.FromPointer); // 02466B21E168 0x38 VisibleArea                 ( 0001865D8B60 ModelClassType MaskableGraphic MaskableGraphic MaskableGraphic Pointer )
            value.M_inspector                               = GetObject<RuntimeInspector>(new IntPtr(p + 0x040), ReversePrism.DataModels.RuntimeInspector.FromPointer); // 02466B21E188 0x40 M_inspector                 ( 00018669ADC0 ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x048)); // 02466B21E1A8 0x48 M_skinVersion               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISkin.FromPointer); // 02466B21E1C8 0x50 M_skin                      ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.M_boundVariableType                       = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 02466B21E1E8 0x58 M_boundVariableType         ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_depth                                   = GetInt32(new IntPtr(p + 0x068)); // 02466B21E228 0x68 M_depth                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_isVisible                               = GetBool(new IntPtr(p + 0x06C)); // 02466B21E248 0x6C M_isVisible                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Getter                                    = GetObject<Getter>(new IntPtr(p + 0x070), ReversePrism.DataModels.Getter.FromPointer); // 02466B21E268 0x70 Getter                      ( 000186640A10 ModelClassType Getter Getter Getter Pointer )
            value.Setter                                    = GetObject<Setter>(new IntPtr(p + 0x078), ReversePrism.DataModels.Setter.FromPointer); // 02466B21E288 0x78 Setter                      ( 000186640ED0 ModelClassType Setter Setter Setter Pointer )

            return value;
        }
    }
}
