using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 namespaceManager                         NamespaceManager IL2CPP_TYPE_CLASS
    // 080 ValidationStack                          ModelClassType HWStack HWStack HWStack Pointer
    // 088 AttPresence                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 090 Name                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 IDs                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0A0 IdRefListHead                            ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 0A8 ProcessIdentityConstraints               ModelPrimitiveType bool bool bool Bool
    public partial class DtdValidator : DataModel
    {
        public HWStack?                                 ValidationStack                         { get; set; }
        public Hashtable?                               AttPresence                             { get; set; }
        public XmlQualifiedName?                        Name                                    { get; set; }
        public Hashtable?                               IDs                                     { get; set; }
        public IdRefNode?                               IdRefListHead                           { get; set; }
        public bool                                     ProcessIdentityConstraints              { get; set; }

        public static DtdValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DtdValidator() { Pointer= p0 };

            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x080), ReversePrism.DataModels.HWStack.FromPointer); // 0x80 ValidationStack             ( ModelClassType HWStack HWStack HWStack Pointer )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x088), ReversePrism.DataModels.Hashtable.FromPointer); // 0x88 AttPresence                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x90 Name                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x098), ReversePrism.DataModels.Hashtable.FromPointer); // 0x98 IDs                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IdRefNode.FromPointer); // 0xA0 IdRefListHead               ( ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.ProcessIdentityConstraints                = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 ProcessIdentityConstraints  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
