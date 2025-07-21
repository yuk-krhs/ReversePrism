using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ValidationStack                          ModelClassType HWStack HWStack HWStack Pointer
    // 088 AttPresence                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 090 Name                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 NsManager                                ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 0A0 IsProcessContents                        ModelPrimitiveType bool bool bool Bool
    // 0A8 IDs                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0B0 IdRefListHead                            ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 0B8 InlineSchemaParser                       ModelClassType Parser Parser Parser Pointer
    public partial class XdrValidator : DataModel
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
            var value   = new XdrValidator() { Pointer= p0 };

            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x080), ReversePrism.DataModels.HWStack.FromPointer); // 0x80 ValidationStack             ( ModelClassType HWStack HWStack HWStack Pointer )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x088), ReversePrism.DataModels.Hashtable.FromPointer); // 0x88 AttPresence                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x90 Name                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.NsManager                                 = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x98 NsManager                   ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.IsProcessContents                         = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsProcessContents           ( ModelPrimitiveType bool bool bool Bool )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Hashtable.FromPointer); // 0xA8 IDs                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdRefNode.FromPointer); // 0xB0 IdRefListHead               ( ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.InlineSchemaParser                        = GetObject<Parser>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Parser.FromPointer); // 0xB8 InlineSchemaParser          ( ModelClassType Parser Parser Parser Pointer )

            return value;
        }
    }
}
