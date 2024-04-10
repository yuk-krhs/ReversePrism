using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlAnyAttribute                          000186586D30 ModelClassType XmlAnyAttributeAttribute XmlAnyAttributeAttribute XmlAnyAttributeAttribute Pointer
    // 018 XmlAnyElements                           000186587790 ModelClassType XmlAnyElementAttributes XmlAnyElementAttributes XmlAnyElementAttributes Pointer
    // 020 XmlArray                                 000186587F30 ModelClassType XmlArrayAttribute XmlArrayAttribute XmlArrayAttribute Pointer
    // 028 XmlArrayItems                            0001865886D0 ModelClassType XmlArrayItemAttributes XmlArrayItemAttributes XmlArrayItemAttributes Pointer
    // 030 XmlAttribute                             00018658A0C0 ModelClassType XmlAttributeAttribute XmlAttributeAttribute XmlAttributeAttribute Pointer
    // 038 XmlChoiceIdentifier                      000186590620 ModelClassType XmlChoiceIdentifierAttribute XmlChoiceIdentifierAttribute XmlChoiceIdentifierAttribute Pointer
    // 040 xmlDefaultValue                          <object> IL2CPP_TYPE_OBJECT
    // 048 XmlElements                              000186598390 ModelClassType XmlElementAttributes XmlElementAttributes XmlElementAttributes Pointer
    // 050 XmlEnum                                  00018659A160 ModelClassType XmlEnumAttribute XmlEnumAttribute XmlEnumAttribute Pointer
    // 058 XmlIgnore                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 Xmlns                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 XmlRoot                                  0001865AC5C0 ModelClassType XmlRootAttribute XmlRootAttribute XmlRootAttribute Pointer
    // 068 XmlText                                  0001865CC8B0 ModelClassType XmlTextAttribute XmlTextAttribute XmlTextAttribute Pointer
    // 070 XmlType                                  0001865CEC70 ModelClassType XmlTypeAttribute XmlTypeAttribute XmlTypeAttribute Pointer
    public partial class XmlAttributes : DataModel
    {
        public XmlAnyAttributeAttribute?                XmlAnyAttribute                         { get; set; }
        public XmlAnyElementAttributes?                 XmlAnyElements                          { get; set; }
        public XmlArrayAttribute?                       XmlArray                                { get; set; }
        public XmlArrayItemAttributes?                  XmlArrayItems                           { get; set; }
        public XmlAttributeAttribute?                   XmlAttribute                            { get; set; }
        public XmlChoiceIdentifierAttribute?            XmlChoiceIdentifier                     { get; set; }
        public XmlElementAttributes?                    XmlElements                             { get; set; }
        public XmlEnumAttribute?                        XmlEnum                                 { get; set; }
        public bool                                     XmlIgnore                               { get; set; }
        public bool                                     Xmlns                                   { get; set; }
        public XmlRootAttribute?                        XmlRoot                                 { get; set; }
        public XmlTextAttribute?                        XmlText                                 { get; set; }
        public XmlTypeAttribute?                        XmlType                                 { get; set; }

        public static XmlAttributes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAttributes() { Pointer= p0 };

            value.XmlAnyAttribute                           = GetObject<XmlAnyAttributeAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlAnyAttributeAttribute.FromPointer); // 024667517678 0x10 XmlAnyAttribute             ( 000186586D30 ModelClassType XmlAnyAttributeAttribute XmlAnyAttributeAttribute XmlAnyAttributeAttribute Pointer )
            value.XmlAnyElements                            = GetObject<XmlAnyElementAttributes>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlAnyElementAttributes.FromPointer); // 024667517698 0x18 XmlAnyElements              ( 000186587790 ModelClassType XmlAnyElementAttributes XmlAnyElementAttributes XmlAnyElementAttributes Pointer )
            value.XmlArray                                  = GetObject<XmlArrayAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlArrayAttribute.FromPointer); // 0246675176B8 0x20 XmlArray                    ( 000186587F30 ModelClassType XmlArrayAttribute XmlArrayAttribute XmlArrayAttribute Pointer )
            value.XmlArrayItems                             = GetObject<XmlArrayItemAttributes>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlArrayItemAttributes.FromPointer); // 0246675176D8 0x28 XmlArrayItems               ( 0001865886D0 ModelClassType XmlArrayItemAttributes XmlArrayItemAttributes XmlArrayItemAttributes Pointer )
            value.XmlAttribute                              = GetObject<XmlAttributeAttribute>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlAttributeAttribute.FromPointer); // 0246675176F8 0x30 XmlAttribute                ( 00018658A0C0 ModelClassType XmlAttributeAttribute XmlAttributeAttribute XmlAttributeAttribute Pointer )
            value.XmlChoiceIdentifier                       = GetObject<XmlChoiceIdentifierAttribute>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlChoiceIdentifierAttribute.FromPointer); // 024667517718 0x38 XmlChoiceIdentifier         ( 000186590620 ModelClassType XmlChoiceIdentifierAttribute XmlChoiceIdentifierAttribute XmlChoiceIdentifierAttribute Pointer )
            value.XmlElements                               = GetObject<XmlElementAttributes>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlElementAttributes.FromPointer); // 024667517758 0x48 XmlElements                 ( 000186598390 ModelClassType XmlElementAttributes XmlElementAttributes XmlElementAttributes Pointer )
            value.XmlEnum                                   = GetObject<XmlEnumAttribute>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlEnumAttribute.FromPointer); // 024667517778 0x50 XmlEnum                     ( 00018659A160 ModelClassType XmlEnumAttribute XmlEnumAttribute XmlEnumAttribute Pointer )
            value.XmlIgnore                                 = GetBool(new IntPtr(p + 0x058)); // 024667517798 0x58 XmlIgnore                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Xmlns                                     = GetBool(new IntPtr(p + 0x059)); // 0246675177B8 0x59 Xmlns                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlRoot                                   = GetObject<XmlRootAttribute>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlRootAttribute.FromPointer); // 0246675177D8 0x60 XmlRoot                     ( 0001865AC5C0 ModelClassType XmlRootAttribute XmlRootAttribute XmlRootAttribute Pointer )
            value.XmlText                                   = GetObject<XmlTextAttribute>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlTextAttribute.FromPointer); // 0246675177F8 0x68 XmlText                     ( 0001865CC8B0 ModelClassType XmlTextAttribute XmlTextAttribute XmlTextAttribute Pointer )
            value.XmlType                                   = GetObject<XmlTypeAttribute>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlTypeAttribute.FromPointer); // 024667517818 0x70 XmlType                     ( 0001865CEC70 ModelClassType XmlTypeAttribute XmlTypeAttribute XmlTypeAttribute Pointer )

            return value;
        }
    }
}
