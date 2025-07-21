using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 StartIDConstraint                        ModelPrimitiveType int int int Int32
    // 088 ValidationStack                          ModelClassType HWStack HWStack HWStack Pointer
    // 090 AttPresence                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 NsManager                                ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 0A0 BManageNamespaces                        ModelPrimitiveType bool bool bool Bool
    // 0A8 IDs                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0B0 IdRefListHead                            ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 0B8 InlineSchemaParser                       ModelClassType Parser Parser Parser Pointer
    // 0C0 ProcessContents                          ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 000 dtCDATA                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 008 dtQName                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 010 DtStringArray                            ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 0C8 NsXmlNs                                  ModelPrimitiveType string string string String
    // 0D0 NsXs                                     ModelPrimitiveType string string string String
    // 0D8 NsXsi                                    ModelPrimitiveType string string string String
    // 0E0 XsiType                                  ModelPrimitiveType string string string String
    // 0E8 XsiNil                                   ModelPrimitiveType string string string String
    // 0F0 XsiSchemaLocation                        ModelPrimitiveType string string string String
    // 0F8 XsiNoNamespaceSchemaLocation             ModelPrimitiveType string string string String
    // 100 XsdSchema                                ModelPrimitiveType string string string String
    public partial class XsdValidator : DataModel
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
            var value   = new XsdValidator() { Pointer= p0 };

            value.StartIDConstraint                         = GetInt32(new IntPtr(p + 0x080)); // 0x80 StartIDConstraint           ( ModelPrimitiveType int int int Int32 )
            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x088), ReversePrism.DataModels.HWStack.FromPointer); // 0x88 ValidationStack             ( ModelClassType HWStack HWStack HWStack Pointer )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0x90 AttPresence                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NsManager                                 = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x98 NsManager                   ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.BManageNamespaces                         = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 BManageNamespaces           ( ModelPrimitiveType bool bool bool Bool )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Hashtable.FromPointer); // 0xA8 IDs                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdRefNode.FromPointer); // 0xB0 IdRefListHead               ( ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.InlineSchemaParser                        = GetObject<Parser>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Parser.FromPointer); // 0xB8 InlineSchemaParser          ( ModelClassType Parser Parser Parser Pointer )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 ProcessContents             ( ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.DtStringArray                             = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x10 DtStringArray               ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x0C8)); // 0xC8 NsXmlNs                     ( ModelPrimitiveType string string string String )
            value.NsXs                                      = GetString(new IntPtr(p + 0x0D0)); // 0xD0 NsXs                        ( ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x0D8)); // 0xD8 NsXsi                       ( ModelPrimitiveType string string string String )
            value.XsiType                                   = GetString(new IntPtr(p + 0x0E0)); // 0xE0 XsiType                     ( ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetString(new IntPtr(p + 0x0E8)); // 0xE8 XsiNil                      ( ModelPrimitiveType string string string String )
            value.XsiSchemaLocation                         = GetString(new IntPtr(p + 0x0F0)); // 0xF0 XsiSchemaLocation           ( ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocation              = GetString(new IntPtr(p + 0x0F8)); // 0xF8 XsiNoNamespaceSchemaLocation ( ModelPrimitiveType string string string String )
            value.XsdSchema                                 = GetString(new IntPtr(p + 0x100)); // 0x100 XsdSchema                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
