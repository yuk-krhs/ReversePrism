using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 AttributeFormDefault                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 03C ElementFormDefault                       ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 040 BlockDefault                             ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 044 FinalDefault                             ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 048 TargetNs                                 ModelPrimitiveType string string string String
    // 050 Version                                  ModelPrimitiveType string string string String
    // 058 Includes                                 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 Items                                    ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 068 Id                                       ModelPrimitiveType string string string String
    // 070 MoreAttributes                           ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    // 078 IsCompiled                               ModelPrimitiveType bool bool bool Bool
    // 079 IsCompiledBySet                          ModelPrimitiveType bool bool bool Bool
    // 07A IsPreprocessed                           ModelPrimitiveType bool bool bool Bool
    // 07B IsRedefined                              ModelPrimitiveType bool bool bool Bool
    // 07C ErrorCount                               ModelPrimitiveType int int int Int32
    // 080 Attributes                               ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 088 AttributeGroups                          ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 090 Elements                                 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 098 Types                                    ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A0 Groups                                   ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0A8 Notations                                ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0B0 IdentityConstraints                      ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 000 globalIdCounter                          int IL2CPP_TYPE_I4
    // 0B8 ImportedSchemas                          ModelClassType ArrayList ArrayList ArrayList Pointer
    // 0C0 ImportedNamespaces                       ModelClassType ArrayList ArrayList ArrayList Pointer
    // 0C8 SchemaId                                 ModelPrimitiveType int int int Int32
    // 0D0 BaseUri                                  ModelClassType Uri Uri Uri Pointer
    // 0D8 IsChameleon                              ModelPrimitiveType bool bool bool Bool
    // 0E0 Ids                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0E8 Document                                 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
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

            value.AttributeFormDefault                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x038)); // 0x38 AttributeFormDefault        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.ElementFormDefault                        = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ElementFormDefault          ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.BlockDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x040)); // 0x40 BlockDefault                ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalDefault                              = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x044)); // 0x44 FinalDefault                ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.TargetNs                                  = GetString(new IntPtr(p + 0x048)); // 0x48 TargetNs                    ( ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x050)); // 0x50 Version                     ( ModelPrimitiveType string string string String )
            value.Includes                                  = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x58 Includes                    ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Items                                     = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x60 Items                       ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Id                                        = GetString(new IntPtr(p + 0x068)); // 0x68 Id                          ( ModelPrimitiveType string string string String )
            value.MoreAttributes                            = GetObjectList<XmlAttribute>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0x70 MoreAttributes              ( ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )
            value.IsCompiled                                = GetBool(new IntPtr(p + 0x078)); // 0x78 IsCompiled                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsCompiledBySet                           = GetBool(new IntPtr(p + 0x079)); // 0x79 IsCompiledBySet             ( ModelPrimitiveType bool bool bool Bool )
            value.IsPreprocessed                            = GetBool(new IntPtr(p + 0x07A)); // 0x7A IsPreprocessed              ( ModelPrimitiveType bool bool bool Bool )
            value.IsRedefined                               = GetBool(new IntPtr(p + 0x07B)); // 0x7B IsRedefined                 ( ModelPrimitiveType bool bool bool Bool )
            value.ErrorCount                                = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ErrorCount                  ( ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x80 Attributes                  ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeGroups                           = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x88 AttributeGroups             ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x90 Elements                    ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Types                                     = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x98 Types                       ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Groups                                    = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0xA0 Groups                      ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Notations                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0xA8 Notations                   ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.IdentityConstraints                       = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0xB0 IdentityConstraints         ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.ImportedSchemas                           = GetObject<ArrayList>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ArrayList.FromPointer); // 0xB8 ImportedSchemas             ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ImportedNamespaces                        = GetObject<ArrayList>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ArrayList.FromPointer); // 0xC0 ImportedNamespaces          ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.SchemaId                                  = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 SchemaId                    ( ModelPrimitiveType int int int Int32 )
            value.BaseUri                                   = GetObject<Uri>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Uri.FromPointer); // 0xD0 BaseUri                     ( ModelClassType Uri Uri Uri Pointer )
            value.IsChameleon                               = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 IsChameleon                 ( ModelPrimitiveType bool bool bool Bool )
            value.Ids                                       = GetObject<Hashtable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Hashtable.FromPointer); // 0xE0 Ids                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Document                                  = GetObject<XmlDocument>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlDocument.FromPointer); // 0xE8 Document                    ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )

            return value;
        }
    }
}
