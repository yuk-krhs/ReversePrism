using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ValidationStack                          0001866A4660 ModelClassType HWStack HWStack HWStack Pointer
    // 088 AttPresence                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 090 Name                                     0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 NsManager                                0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 0A0 IsProcessContents                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 IDs                                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0B0 IdRefListHead                            0001866A33C0 ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 0B8 InlineSchemaParser                       000186721710 ModelClassType Parser Parser Parser Pointer
    public partial class XdrValidator
    {
        public HWStack?                                 ValidationStack                         { get; set; }
        public Hashtable?                               AttPresence                             { get; set; }
        public XmlQualifiedName?                        Name                                    { get; set; }
        public XmlNamespaceManager?                     NsManager                               { get; set; }
        public bool                                     IsProcessContents                       { get; set; }
        public Hashtable?                               IDs                                     { get; set; }
        public IdRefNode?                               IdRefListHead                           { get; set; }
        public Parser?                                  InlineSchemaParser                      { get; set; }

        public static XdrValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XdrValidator();

            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x080), ReversePrism.DataModels.HWStack.FromPointer); // 0270D7586560 0x80 ValidationStack             ( 0001866A4660 ModelClassType HWStack HWStack HWStack Pointer )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x088), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7586580 0x88 AttPresence                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D75865A0 0x90 Name                        ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.NsManager                                 = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0270D75865C0 0x98 NsManager                   ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.IsProcessContents                         = GetBool(new IntPtr(p + 0x0A0)); // 0270D75865E0 0xA0 IsProcessContents           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7586600 0xA8 IDs                         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdRefNode.FromPointer); // 0270D7586620 0xB0 IdRefListHead               ( 0001866A33C0 ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.InlineSchemaParser                        = GetObject<Parser>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Parser.FromPointer); // 0270D7586640 0xB8 InlineSchemaParser          ( 000186721710 ModelClassType Parser Parser Parser Pointer )

            return value;
        }
    }
}
