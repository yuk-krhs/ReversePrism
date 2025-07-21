using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LayoutElement                            ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 028 VariableNameText                         ModelClassType Text Text Text Pointer
    // 030 VariableNameMask                         ModelClassType Image Image Image Pointer
    // 038 VisibleArea                              ModelClassType MaskableGraphic MaskableGraphic MaskableGraphic Pointer
    // 040 M_inspector                              ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer
    // 048 M_skinVersion                            ModelPrimitiveType int int int Int32
    // 050 M_skin                                   ModelClassType UISkin UISkin UISkin Pointer
    // 058 M_boundVariableType                      ModelClassType Type Type Type Pointer
    // 060 m_value                                  <object> IL2CPP_TYPE_OBJECT
    // 068 M_depth                                  ModelPrimitiveType int int int Int32
    // 06C M_isVisible                              ModelPrimitiveType bool bool bool Bool
    // 070 Getter                                   ModelClassType Getter Getter Getter Pointer
    // 078 Setter                                   ModelClassType Setter Setter Setter Pointer
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

            value.LayoutElement                             = GetObject<LayoutElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.LayoutElement.FromPointer); // 0x20 LayoutElement               ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.VariableNameText                          = GetObject<Text>(new IntPtr(p + 0x028), ReversePrism.DataModels.Text.FromPointer); // 0x28 VariableNameText            ( ModelClassType Text Text Text Pointer )
            value.VariableNameMask                          = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 VariableNameMask            ( ModelClassType Image Image Image Pointer )
            value.VisibleArea                               = GetObject<MaskableGraphic>(new IntPtr(p + 0x038), ReversePrism.DataModels.MaskableGraphic.FromPointer); // 0x38 VisibleArea                 ( ModelClassType MaskableGraphic MaskableGraphic MaskableGraphic Pointer )
            value.M_inspector                               = GetObject<RuntimeInspector>(new IntPtr(p + 0x040), ReversePrism.DataModels.RuntimeInspector.FromPointer); // 0x40 M_inspector                 ( ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_skinVersion               ( ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISkin.FromPointer); // 0x50 M_skin                      ( ModelClassType UISkin UISkin UISkin Pointer )
            value.M_boundVariableType                       = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 0x58 M_boundVariableType         ( ModelClassType Type Type Type Pointer )
            value.M_depth                                   = GetInt32(new IntPtr(p + 0x068)); // 0x68 M_depth                     ( ModelPrimitiveType int int int Int32 )
            value.M_isVisible                               = GetBool(new IntPtr(p + 0x06C)); // 0x6C M_isVisible                 ( ModelPrimitiveType bool bool bool Bool )
            value.Getter                                    = GetObject<Getter>(new IntPtr(p + 0x070), ReversePrism.DataModels.Getter.FromPointer); // 0x70 Getter                      ( ModelClassType Getter Getter Getter Pointer )
            value.Setter                                    = GetObject<Setter>(new IntPtr(p + 0x078), ReversePrism.DataModels.Setter.FromPointer); // 0x78 Setter                      ( ModelClassType Setter Setter Setter Pointer )

            return value;
        }
    }
}
