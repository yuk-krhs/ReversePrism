using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Namespaces                               000185CCAA68 ModelClassListType Namespace[] Namespace[] List<Namespace> Pointer
    // 018 LastNameSpace                            0001865A3760 ModelClassType Namespace Namespace Namespace Pointer
    // 020 NsCount                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Attributes                               000185CCAC78 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    // 030 AttributeCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Space                                    0001865CA260 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 038 Lang                                     000186671910 ModelPrimitiveType string string string String
    // 040 NamespaceBoundary                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 NsTop                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 DefaultNamespace                         0001865A3760 ModelClassType Namespace Namespace Namespace Pointer
    public partial class NamespaceManager : DataModel
    {
        public List<Namespace>?                         Namespaces                              { get; set; }
        public Namespace?                               LastNameSpace                           { get; set; }
        public int                                      NsCount                                 { get; set; }
        public int                                      Depth                                   { get; set; }
        public List<XmlAttribute>?                      Attributes                              { get; set; }
        public int                                      AttributeCount                          { get; set; }
        public XmlSpace                                 Space                                   { get; set; }
        public string                                   Lang                                    { get; set; }
        public int                                      NamespaceBoundary                       { get; set; }
        public int                                      NsTop                                   { get; set; }
        public Namespace?                               DefaultNamespace                        { get; set; }

        public static NamespaceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceManager() { Pointer= p0 };

            value.Namespaces                                = GetObjectList<Namespace>(new IntPtr(p + 0x010), ReversePrism.DataModels.Namespace.FromPointer); // 024667C6BFC0 0x10 Namespaces                  ( 000185CCAA68 ModelClassListType Namespace[] Namespace[] List<Namespace> Pointer )
            value.LastNameSpace                             = GetObject<Namespace>(new IntPtr(p + 0x018), ReversePrism.DataModels.Namespace.FromPointer); // 024667C6BFE0 0x18 LastNameSpace               ( 0001865A3760 ModelClassType Namespace Namespace Namespace Pointer )
            value.NsCount                                   = GetInt32(new IntPtr(p + 0x020)); // 024667C6C000 0x20 NsCount                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x024)); // 024667C6C020 0x24 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetObjectList<XmlAttribute>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlAttribute.FromPointer); // 024667C6C040 0x28 Attributes                  ( 000185CCAC78 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x030)); // 024667C6C060 0x30 AttributeCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Space                                     = (XmlSpace)GetInt32(new IntPtr(p + 0x034)); // 024667C6C080 0x34 Space                       ( 0001865CA260 ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.Lang                                      = GetString(new IntPtr(p + 0x038)); // 024667C6C0A0 0x38 Lang                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NamespaceBoundary                         = GetInt32(new IntPtr(p + 0x040)); // 024667C6C0C0 0x40 NamespaceBoundary           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NsTop                                     = GetInt32(new IntPtr(p + 0x044)); // 024667C6C0E0 0x44 NsTop                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DefaultNamespace                          = GetObject<Namespace>(new IntPtr(p + 0x048), ReversePrism.DataModels.Namespace.FromPointer); // 024667C6C100 0x48 DefaultNamespace            ( 0001865A3760 ModelClassType Namespace Namespace Namespace Pointer )

            return value;
        }
    }
}
