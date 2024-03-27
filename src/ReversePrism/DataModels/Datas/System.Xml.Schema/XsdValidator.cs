using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 StartIDConstraint                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 ValidationStack                          0001866A4660 ModelClassType HWStack HWStack HWStack Pointer
    // 090 AttPresence                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 NsManager                                0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 0A0 BManageNamespaces                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 IDs                                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0B0 IdRefListHead                            0001866A33C0 ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 0B8 InlineSchemaParser                       000186721710 ModelClassType Parser Parser Parser Pointer
    // 0C0 ProcessContents                          0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 000 dtCDATA                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 008 dtQName                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 010 DtStringArray                            0001865B3FA0 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 0C8 NsXmlNs                                  000186671910 ModelPrimitiveType string string string String
    // 0D0 NsXs                                     000186671910 ModelPrimitiveType string string string String
    // 0D8 NsXsi                                    000186671910 ModelPrimitiveType string string string String
    // 0E0 XsiType                                  000186671910 ModelPrimitiveType string string string String
    // 0E8 XsiNil                                   000186671910 ModelPrimitiveType string string string String
    // 0F0 XsiSchemaLocation                        000186671910 ModelPrimitiveType string string string String
    // 0F8 XsiNoNamespaceSchemaLocation             000186671910 ModelPrimitiveType string string string String
    // 100 XsdSchema                                000186671910 ModelPrimitiveType string string string String
    public partial class XsdValidator
    {
        public int                                      StartIDConstraint                       { get; set; }
        public HWStack?                                 ValidationStack                         { get; set; }
        public Hashtable?                               AttPresence                             { get; set; }
        public XmlNamespaceManager?                     NsManager                               { get; set; }
        public bool                                     BManageNamespaces                       { get; set; }
        public Hashtable?                               IDs                                     { get; set; }
        public IdRefNode?                               IdRefListHead                           { get; set; }
        public Parser?                                  InlineSchemaParser                      { get; set; }
        public XmlSchemaContentProcessing               ProcessContents                         { get; set; }
        public XmlSchemaDatatype?                       DtStringArray                           { get; set; }
        public string                                   NsXmlNs                                 { get; set; }
        public string                                   NsXs                                    { get; set; }
        public string                                   NsXsi                                   { get; set; }
        public string                                   XsiType                                 { get; set; }
        public string                                   XsiNil                                  { get; set; }
        public string                                   XsiSchemaLocation                       { get; set; }
        public string                                   XsiNoNamespaceSchemaLocation            { get; set; }
        public string                                   XsdSchema                               { get; set; }

        public static XsdValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdValidator();

            value.StartIDConstraint                         = GetInt32(new IntPtr(p + 0x080)); // 0270D75F4068 0x80 StartIDConstraint           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x088), ReversePrism.DataModels.HWStack.FromPointer); // 0270D75F4088 0x88 ValidationStack             ( 0001866A4660 ModelClassType HWStack HWStack HWStack Pointer )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D75F40A8 0x90 AttPresence                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NsManager                                 = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0270D75F40C8 0x98 NsManager                   ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.BManageNamespaces                         = GetBool(new IntPtr(p + 0x0A0)); // 0270D75F40E8 0xA0 BManageNamespaces           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D75F4108 0xA8 IDs                         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdRefNode.FromPointer); // 0270D75F4128 0xB0 IdRefListHead               ( 0001866A33C0 ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.InlineSchemaParser                        = GetObject<Parser>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Parser.FromPointer); // 0270D75F4148 0xB8 InlineSchemaParser          ( 000186721710 ModelClassType Parser Parser Parser Pointer )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x0C0)); // 0270D75F4168 0xC0 ProcessContents             ( 0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.DtStringArray                             = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0270D75F41C8 0x10 DtStringArray               ( 0001865B3FA0 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x0C8)); // 0270D75F41E8 0xC8 NsXmlNs                     ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXs                                      = GetString(new IntPtr(p + 0x0D0)); // 0270D75F4208 0xD0 NsXs                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x0D8)); // 0270D75F4228 0xD8 NsXsi                       ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiType                                   = GetString(new IntPtr(p + 0x0E0)); // 0270D75F4248 0xE0 XsiType                     ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetString(new IntPtr(p + 0x0E8)); // 0270D75F4268 0xE8 XsiNil                      ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiSchemaLocation                         = GetString(new IntPtr(p + 0x0F0)); // 0270D75F4288 0xF0 XsiSchemaLocation           ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocation              = GetString(new IntPtr(p + 0x0F8)); // 0270D75F42A8 0xF8 XsiNoNamespaceSchemaLocation ( 000186671910 ModelPrimitiveType string string string String )
            value.XsdSchema                                 = GetString(new IntPtr(p + 0x100)); // 0270D75F42C8 0x100 XsdSchema                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
