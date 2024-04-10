using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 AttributeFormDefault                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 03C ElementFormDefault                       0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 040 BlockDefault                             0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 044 FinalDefault                             0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 048 TargetNs                                 000186671910 ModelPrimitiveType string string string String
    // 050 Version                                  000186671910 ModelPrimitiveType string string string String
    // 058 Includes                                 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 Items                                    0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 068 Id                                       000186671910 ModelPrimitiveType string string string String
    // 070 MoreAttributes                           000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    // 078 IsCompiled                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 079 IsCompiledBySet                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07A IsPreprocessed                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07B IsRedefined                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C ErrorCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 Attributes                               0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 088 AttributeGroups                          0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 090 Elements                                 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 098 Types                                    0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A0 Groups                                   0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A8 Notations                                0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0B0 IdentityConstraints                      0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 000 globalIdCounter                          int IL2CPP_TYPE_I4
    // 0B8 ImportedSchemas                          00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 0C0 ImportedNamespaces                       00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 0C8 SchemaId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 BaseUri                                  0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 0D8 IsChameleon                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 Ids                                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0E8 Document                                 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    public partial class XmlSchema : DataModel
    {
        public XmlSchemaForm                            AttributeFormDefault                    { get; set; }
        public XmlSchemaForm                            ElementFormDefault                      { get; set; }
        public XmlSchemaDerivationMethod                BlockDefault                            { get; set; }
        public XmlSchemaDerivationMethod                FinalDefault                            { get; set; }
        public string                                   TargetNs                                { get; set; }
        public string                                   Version                                 { get; set; }
        public XmlSchemaObjectCollection?               Includes                                { get; set; }
        public XmlSchemaObjectCollection?               Items                                   { get; set; }
        public string                                   Id                                      { get; set; }
        public List<XmlAttribute>?                      MoreAttributes                          { get; set; }
        public bool                                     IsCompiled                              { get; set; }
        public bool                                     IsCompiledBySet                         { get; set; }
        public bool                                     IsPreprocessed                          { get; set; }
        public bool                                     IsRedefined                             { get; set; }
        public int                                      ErrorCount                              { get; set; }
        public XmlSchemaObjectTable?                    Attributes                              { get; set; }
        public XmlSchemaObjectTable?                    AttributeGroups                         { get; set; }
        public XmlSchemaObjectTable?                    Elements                                { get; set; }
        public XmlSchemaObjectTable?                    Types                                   { get; set; }
        public XmlSchemaObjectTable?                    Groups                                  { get; set; }
        public XmlSchemaObjectTable?                    Notations                               { get; set; }
        public XmlSchemaObjectTable?                    IdentityConstraints                     { get; set; }
        public ArrayList?                               ImportedSchemas                         { get; set; }
        public ArrayList?                               ImportedNamespaces                      { get; set; }
        public int                                      SchemaId                                { get; set; }
        public Uri?                                     BaseUri                                 { get; set; }
        public bool                                     IsChameleon                             { get; set; }
        public Hashtable?                               Ids                                     { get; set; }
        public XmlDocument?                             Document                                { get; set; }

        public static XmlSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchema() { Pointer= p0 };

            value.AttributeFormDefault                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x038)); // 024667511370 0x38 AttributeFormDefault        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.ElementFormDefault                        = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x03C)); // 024667511390 0x3C ElementFormDefault          ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.BlockDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x040)); // 0246675113B0 0x40 BlockDefault                ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x044)); // 0246675113D0 0x44 FinalDefault                ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.TargetNs                                  = GetString(new IntPtr(p + 0x048)); // 0246675113F0 0x48 TargetNs                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x050)); // 024667511410 0x50 Version                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Includes                                  = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 024667511430 0x58 Includes                    ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Items                                     = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 024667511450 0x60 Items                       ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Id                                        = GetString(new IntPtr(p + 0x068)); // 024667511470 0x68 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.MoreAttributes                            = GetObjectList<XmlAttribute>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlAttribute.FromPointer); // 024667511490 0x70 MoreAttributes              ( 000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )
            value.IsCompiled                                = GetBool(new IntPtr(p + 0x078)); // 0246675114B0 0x78 IsCompiled                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsCompiledBySet                           = GetBool(new IntPtr(p + 0x079)); // 0246675114D0 0x79 IsCompiledBySet             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPreprocessed                            = GetBool(new IntPtr(p + 0x07A)); // 0246675114F0 0x7A IsPreprocessed              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsRedefined                               = GetBool(new IntPtr(p + 0x07B)); // 024667511510 0x7B IsRedefined                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ErrorCount                                = GetInt32(new IntPtr(p + 0x07C)); // 024667511530 0x7C ErrorCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667511550 0x80 Attributes                  ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeGroups                           = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667511570 0x88 AttributeGroups             ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667511590 0x90 Elements                    ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Types                                     = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675115B0 0x98 Types                       ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Groups                                    = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675115D0 0xA0 Groups                      ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Notations                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675115F0 0xA8 Notations                   ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.IdentityConstraints                       = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 024667511610 0xB0 IdentityConstraints         ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.ImportedSchemas                           = GetObject<ArrayList>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ArrayList.FromPointer); // 024667511650 0xB8 ImportedSchemas             ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ImportedNamespaces                        = GetObject<ArrayList>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ArrayList.FromPointer); // 024667511670 0xC0 ImportedNamespaces          ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.SchemaId                                  = GetInt32(new IntPtr(p + 0x0C8)); // 024667511690 0xC8 SchemaId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseUri                                   = GetObject<Uri>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Uri.FromPointer); // 0246675116B0 0xD0 BaseUri                     ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.IsChameleon                               = GetBool(new IntPtr(p + 0x0D8)); // 0246675116D0 0xD8 IsChameleon                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ids                                       = GetObject<Hashtable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Hashtable.FromPointer); // 0246675116F0 0xE0 Ids                         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Document                                  = GetObject<XmlDocument>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlDocument.FromPointer); // 024667511710 0xE8 Document                    ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )

            return value;
        }
    }
}
