using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaType                               0001866EB700 ModelEnumType SchemaType SchemaType SchemaType Int32
    // 018 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 SchemaNames                              0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 028 EventHandler                             000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 030 NamespaceManager                         0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 038 Reader                                   0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 040 PositionInfo                             000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 048 IsProcessNamespaces                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C SchemaXmlDepth                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 MarkupDepth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Builder                                  0001866E7800 ModelClassType SchemaBuilder SchemaBuilder SchemaBuilder Pointer
    // 060 Schema                                   0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 068 XdrSchema                                0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 070 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 078 DummyDocument                            000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 080 ProcessMarkup                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 ParentNode                               0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 090 AnnotationNSManager                      0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 098 Xmlns                                    000186671910 ModelPrimitiveType string string string String
    // 0A0 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
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

            value.SchemaType                                = (SchemaType)GetInt32(new IntPtr(p + 0x010)); // 024667499468 0x10 SchemaType                  ( 0001866EB700 ModelEnumType SchemaType SchemaType SchemaType Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667499488 0x18 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x020), ReversePrism.DataModels.SchemaNames.FromPointer); // 0246674994A8 0x20 SchemaNames                 ( 0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0246674994C8 0x28 EventHandler                ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0246674994E8 0x30 NamespaceManager            ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlReader.FromPointer); // 024667499508 0x38 Reader                      ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.PositionInfo.FromPointer); // 024667499528 0x40 PositionInfo                ( 000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.IsProcessNamespaces                       = GetBool(new IntPtr(p + 0x048)); // 024667499548 0x48 IsProcessNamespaces         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SchemaXmlDepth                            = GetInt32(new IntPtr(p + 0x04C)); // 024667499568 0x4C SchemaXmlDepth              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MarkupDepth                               = GetInt32(new IntPtr(p + 0x050)); // 024667499588 0x50 MarkupDepth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Builder                                   = GetObject<SchemaBuilder>(new IntPtr(p + 0x058), ReversePrism.DataModels.SchemaBuilder.FromPointer); // 0246674995A8 0x58 Builder                     ( 0001866E7800 ModelClassType SchemaBuilder SchemaBuilder SchemaBuilder Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchema.FromPointer); // 0246674995C8 0x60 Schema                      ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.XdrSchema                                 = GetObject<SchemaInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0246674995E8 0x68 XdrSchema                   ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlResolver.FromPointer); // 024667499608 0x70 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.DummyDocument                             = GetObject<XmlDocument>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlDocument.FromPointer); // 024667499628 0x78 DummyDocument               ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.ProcessMarkup                             = GetBool(new IntPtr(p + 0x080)); // 024667499648 0x80 ProcessMarkup               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ParentNode                                = GetObject<XmlNode>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlNode.FromPointer); // 024667499668 0x88 ParentNode                  ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.AnnotationNSManager                       = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 024667499688 0x90 AnnotationNSManager         ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.Xmlns                                     = GetString(new IntPtr(p + 0x098)); // 0246674996A8 0x98 Xmlns                       ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x0A0)); // 0246674996C8 0xA0 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )

            return value;
        }
    }
}
