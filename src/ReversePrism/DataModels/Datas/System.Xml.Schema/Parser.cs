using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaType                               ModelEnumType SchemaType SchemaType SchemaType Int32
    // 018 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 SchemaNames                              ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 028 EventHandler                             ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 030 NamespaceManager                         ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 038 Reader                                   ModelClassType XmlReader XmlReader XmlReader Pointer
    // 040 PositionInfo                             ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 048 IsProcessNamespaces                      ModelPrimitiveType bool bool bool Bool
    // 04C SchemaXmlDepth                           ModelPrimitiveType int int int Int32
    // 050 MarkupDepth                              ModelPrimitiveType int int int Int32
    // 058 Builder                                  ModelClassType SchemaBuilder SchemaBuilder SchemaBuilder Pointer
    // 060 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 068 XdrSchema                                ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 070 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 078 DummyDocument                            ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 080 ProcessMarkup                            ModelPrimitiveType bool bool bool Bool
    // 088 ParentNode                               ModelClassType XmlNode XmlNode XmlNode Pointer
    // 090 AnnotationNSManager                      ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 098 Xmlns                                    ModelPrimitiveType string string string String
    // 0A0 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    public partial class Parser : DataModel
    {
        public SchemaType                               SchemaType                              { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public ValidationEventHandler?                  EventHandler                            { get; set; }
        public XmlNamespaceManager?                     NamespaceManager                        { get; set; }
        public XmlReader?                               Reader                                  { get; set; }
        public PositionInfo?                            PositionInfo                            { get; set; }
        public bool                                     IsProcessNamespaces                     { get; set; }
        public int                                      SchemaXmlDepth                          { get; set; }
        public int                                      MarkupDepth                             { get; set; }
        public SchemaBuilder?                           Builder                                 { get; set; }
        public XmlSchema?                               Schema                                  { get; set; }
        public SchemaInfo?                              XdrSchema                               { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }
        public XmlDocument?                             DummyDocument                           { get; set; }
        public bool                                     ProcessMarkup                           { get; set; }
        public XmlNode?                                 ParentNode                              { get; set; }
        public XmlNamespaceManager?                     AnnotationNSManager                     { get; set; }
        public string                                   Xmlns                                   { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }

        public static Parser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Parser() { Pointer= p0 };

            value.SchemaType                                = (SchemaType)GetInt32(new IntPtr(p + 0x010)); // 0x10 SchemaType                  ( ModelEnumType SchemaType SchemaType SchemaType Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x18 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x020), ReversePrism.DataModels.SchemaNames.FromPointer); // 0x20 SchemaNames                 ( ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x28 EventHandler                ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x30 NamespaceManager            ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlReader.FromPointer); // 0x38 Reader                      ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.PositionInfo.FromPointer); // 0x40 PositionInfo                ( ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.IsProcessNamespaces                       = GetBool(new IntPtr(p + 0x048)); // 0x48 IsProcessNamespaces         ( ModelPrimitiveType bool bool bool Bool )
            value.SchemaXmlDepth                            = GetInt32(new IntPtr(p + 0x04C)); // 0x4C SchemaXmlDepth              ( ModelPrimitiveType int int int Int32 )
            value.MarkupDepth                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 MarkupDepth                 ( ModelPrimitiveType int int int Int32 )
            value.Builder                                   = GetObject<SchemaBuilder>(new IntPtr(p + 0x058), ReversePrism.DataModels.SchemaBuilder.FromPointer); // 0x58 Builder                     ( ModelClassType SchemaBuilder SchemaBuilder SchemaBuilder Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x60 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.XdrSchema                                 = GetObject<SchemaInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x68 XdrSchema                   ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x70 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.DummyDocument                             = GetObject<XmlDocument>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlDocument.FromPointer); // 0x78 DummyDocument               ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.ProcessMarkup                             = GetBool(new IntPtr(p + 0x080)); // 0x80 ProcessMarkup               ( ModelPrimitiveType bool bool bool Bool )
            value.ParentNode                                = GetObject<XmlNode>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlNode.FromPointer); // 0x88 ParentNode                  ( ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.AnnotationNSManager                       = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x90 AnnotationNSManager         ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.Xmlns                                     = GetString(new IntPtr(p + 0x098)); // 0x98 Xmlns                       ( ModelPrimitiveType string string string String )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )

            return value;
        }
    }
}
