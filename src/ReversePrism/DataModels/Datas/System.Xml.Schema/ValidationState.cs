using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNill                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 IsDefault                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 NeedValidateChildren                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 CheckRequiredAttribute                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 ValidationSkipped                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ProcessContents                          0001865B2930 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 01C Validity                                 0001865C3830 ModelEnumType XmlSchemaValidity XmlSchemaValidity XmlSchemaValidity Int32
    // 020 ElementDecl                              0001866E88A0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 028 ElementDeclBeforeXsi                     0001866E88A0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 030 LocalName                                0001866722E0 ModelPrimitiveType string string string String
    // 038 Namespace                                0001866722E0 ModelPrimitiveType string string string String
    // 040 Constr                                   000185B76AE0 ModelClassListType ConstraintStruct[] ConstraintStruct[] List<ConstraintStruct> Pointer
    // 048 CurrentState                             0001865843F0 ModelEnumType StateUnion StateUnion StateUnion Int32
    // 04C HasMatched                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 CurPos                                   000185B71F30 ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer
    // 058 AllElementsSet                           000186593D40 ModelClassType BitSet BitSet BitSet Pointer
    // 060 RunningPositions                         000185CFF568 ModelEnumListType List`1<RangePositionInfo> List`1<RangePositionInfo> List<RangePositionInfo> Pointer
    // 068 TooComplex                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ValidationState
    {
        public bool                                     IsNill                                  { get; set; }
        public bool                                     IsDefault                               { get; set; }
        public bool                                     NeedValidateChildren                    { get; set; }
        public bool                                     CheckRequiredAttribute                  { get; set; }
        public bool                                     ValidationSkipped                       { get; set; }
        public XmlSchemaContentProcessing               ProcessContents                         { get; set; }
        public XmlSchemaValidity                        Validity                                { get; set; }
        public SchemaElementDecl?                       ElementDecl                             { get; set; }
        public SchemaElementDecl?                       ElementDeclBeforeXsi                    { get; set; }
        public string                                   LocalName                               { get; set; }
        public string                                   Namespace                               { get; set; }
        public List<ConstraintStruct>?                  Constr                                  { get; set; }
        public StateUnion                               CurrentState                            { get; set; }
        public bool                                     HasMatched                              { get; set; }
        public List<BitSet>?                            CurPos                                  { get; set; }
        public BitSet?                                  AllElementsSet                          { get; set; }
        public List<RangePositionInfo>?                 RunningPositions                        { get; set; }
        public bool                                     TooComplex                              { get; set; }

        public static ValidationState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidationState();

            value.IsNill                                    = GetBool(new IntPtr(p + 0x010)); // 0270D74F85F0 0x10 IsNill                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x011)); // 0270D74F8610 0x11 IsDefault                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedValidateChildren                      = GetBool(new IntPtr(p + 0x012)); // 0270D74F8630 0x12 NeedValidateChildren        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CheckRequiredAttribute                    = GetBool(new IntPtr(p + 0x013)); // 0270D74F8650 0x13 CheckRequiredAttribute      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ValidationSkipped                         = GetBool(new IntPtr(p + 0x014)); // 0270D74F8670 0x14 ValidationSkipped           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x018)); // 0270D74F8690 0x18 ProcessContents             ( 0001865B2930 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.Validity                                  = (XmlSchemaValidity)GetInt32(new IntPtr(p + 0x01C)); // 0270D74F86B0 0x1C Validity                    ( 0001865C3830 ModelEnumType XmlSchemaValidity XmlSchemaValidity XmlSchemaValidity Int32 )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x020), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0270D74F86D0 0x20 ElementDecl                 ( 0001866E88A0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.ElementDeclBeforeXsi                      = GetObject<SchemaElementDecl>(new IntPtr(p + 0x028), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0270D74F86F0 0x28 ElementDeclBeforeXsi        ( 0001866E88A0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.LocalName                                 = GetString(new IntPtr(p + 0x030)); // 0270D74F8710 0x30 LocalName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x038)); // 0270D74F8730 0x38 Namespace                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Constr                                    = GetObjectList<ConstraintStruct>(new IntPtr(p + 0x040), ReversePrism.DataModels.ConstraintStruct.FromPointer); // 0270D74F8750 0x40 Constr                      ( 000185B76AE0 ModelClassListType ConstraintStruct[] ConstraintStruct[] List<ConstraintStruct> Pointer )
            value.CurrentState                              = (StateUnion)GetInt32(new IntPtr(p + 0x048)); // 0270D74F8770 0x48 CurrentState                ( 0001865843F0 ModelEnumType StateUnion StateUnion StateUnion Int32 )
            value.HasMatched                                = GetBool(new IntPtr(p + 0x04C)); // 0270D74F8790 0x4C HasMatched                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CurPos                                    = GetObjectList<BitSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74F87B0 0x50 CurPos                      ( 000185B71F30 ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer )
            value.AllElementsSet                            = GetObject<BitSet>(new IntPtr(p + 0x058), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74F87D0 0x58 AllElementsSet              ( 000186593D40 ModelClassType BitSet BitSet BitSet Pointer )
            value.RunningPositions                          = GetEnumList<RangePositionInfo>(new IntPtr(p + 0x060)); // 0270D74F87F0 0x60 RunningPositions            ( 000185CFF568 ModelEnumListType List`1<RangePositionInfo> List`1<RangePositionInfo> List<RangePositionInfo> Pointer )
            value.TooComplex                                = GetBool(new IntPtr(p + 0x068)); // 0270D74F8810 0x68 TooComplex                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
