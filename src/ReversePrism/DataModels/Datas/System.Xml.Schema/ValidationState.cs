using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNill                                   ModelPrimitiveType bool bool bool Bool
    // 011 IsDefault                                ModelPrimitiveType bool bool bool Bool
    // 012 NeedValidateChildren                     ModelPrimitiveType bool bool bool Bool
    // 013 CheckRequiredAttribute                   ModelPrimitiveType bool bool bool Bool
    // 014 ValidationSkipped                        ModelPrimitiveType bool bool bool Bool
    // 018 ProcessContents                          ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 01C Validity                                 ModelEnumType XmlSchemaValidity XmlSchemaValidity XmlSchemaValidity Int32
    // 020 ElementDecl                              ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 028 ElementDeclBeforeXsi                     ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 030 LocalName                                ModelPrimitiveType string string string String
    // 038 Namespace                                ModelPrimitiveType string string string String
    // 040 Constr                                   ModelClassListType ConstraintStruct[] ConstraintStruct[] List<ConstraintStruct> Pointer
    // 048 CurrentState                             ModelEnumType StateUnion StateUnion StateUnion Int32
    // 04C HasMatched                               ModelPrimitiveType bool bool bool Bool
    // 050 CurPos                                   ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer
    // 058 AllElementsSet                           ModelClassType BitSet BitSet BitSet Pointer
    // 060 RunningPositions                         ModelEnumListType List`1<RangePositionInfo> List`1<RangePositionInfo> List<RangePositionInfo> Pointer
    // 068 TooComplex                               ModelPrimitiveType bool bool bool Bool
    public partial class ValidationState : DataModel
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
            var value   = new ValidationState() { Pointer= p0 };

            value.IsNill                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 IsNill                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x011)); // 0x11 IsDefault                   ( ModelPrimitiveType bool bool bool Bool )
            value.NeedValidateChildren                      = GetBool(new IntPtr(p + 0x012)); // 0x12 NeedValidateChildren        ( ModelPrimitiveType bool bool bool Bool )
            value.CheckRequiredAttribute                    = GetBool(new IntPtr(p + 0x013)); // 0x13 CheckRequiredAttribute      ( ModelPrimitiveType bool bool bool Bool )
            value.ValidationSkipped                         = GetBool(new IntPtr(p + 0x014)); // 0x14 ValidationSkipped           ( ModelPrimitiveType bool bool bool Bool )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x018)); // 0x18 ProcessContents             ( ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.Validity                                  = (XmlSchemaValidity)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Validity                    ( ModelEnumType XmlSchemaValidity XmlSchemaValidity XmlSchemaValidity Int32 )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x020), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0x20 ElementDecl                 ( ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.ElementDeclBeforeXsi                      = GetObject<SchemaElementDecl>(new IntPtr(p + 0x028), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0x28 ElementDeclBeforeXsi        ( ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.LocalName                                 = GetString(new IntPtr(p + 0x030)); // 0x30 LocalName                   ( ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x038)); // 0x38 Namespace                   ( ModelPrimitiveType string string string String )
            value.Constr                                    = GetObjectList<ConstraintStruct>(new IntPtr(p + 0x040), ReversePrism.DataModels.ConstraintStruct.FromPointer); // 0x40 Constr                      ( ModelClassListType ConstraintStruct[] ConstraintStruct[] List<ConstraintStruct> Pointer )
            value.CurrentState                              = (StateUnion)GetInt32(new IntPtr(p + 0x048)); // 0x48 CurrentState                ( ModelEnumType StateUnion StateUnion StateUnion Int32 )
            value.HasMatched                                = GetBool(new IntPtr(p + 0x04C)); // 0x4C HasMatched                  ( ModelPrimitiveType bool bool bool Bool )
            value.CurPos                                    = GetObjectList<BitSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.BitSet.FromPointer); // 0x50 CurPos                      ( ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer )
            value.AllElementsSet                            = GetObject<BitSet>(new IntPtr(p + 0x058), ReversePrism.DataModels.BitSet.FromPointer); // 0x58 AllElementsSet              ( ModelClassType BitSet BitSet BitSet Pointer )
            value.RunningPositions                          = GetEnumList<RangePositionInfo>(new IntPtr(p + 0x060)); // 0x60 RunningPositions            ( ModelEnumListType List`1<RangePositionInfo> List`1<RangePositionInfo> List<RangePositionInfo> Pointer )
            value.TooComplex                                = GetBool(new IntPtr(p + 0x068)); // 0x68 TooComplex                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
