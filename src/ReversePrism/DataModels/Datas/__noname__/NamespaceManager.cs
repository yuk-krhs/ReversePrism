using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Namespaces                               ModelClassListType Namespace[] Namespace[] List<Namespace> Pointer
    // 018 LastNameSpace                            ModelClassType Namespace Namespace Namespace Pointer
    // 020 NsCount                                  ModelPrimitiveType int int int Int32
    // 024 Depth                                    ModelPrimitiveType int int int Int32
    // 028 Attributes                               ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    // 030 AttributeCount                           ModelPrimitiveType int int int Int32
    // 034 Space                                    ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 038 Lang                                     ModelPrimitiveType string string string String
    // 040 NamespaceBoundary                        ModelPrimitiveType int int int Int32
    // 044 NsTop                                    ModelPrimitiveType int int int Int32
    // 048 DefaultNamespace                         ModelClassType Namespace Namespace Namespace Pointer
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

            value.Namespaces                                = GetObjectList<Namespace>(new IntPtr(p + 0x010), ReversePrism.DataModels.Namespace.FromPointer); // 0x10 Namespaces                  ( ModelClassListType Namespace[] Namespace[] List<Namespace> Pointer )
            value.LastNameSpace                             = GetObject<Namespace>(new IntPtr(p + 0x018), ReversePrism.DataModels.Namespace.FromPointer); // 0x18 LastNameSpace               ( ModelClassType Namespace Namespace Namespace Pointer )
            value.NsCount                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 NsCount                     ( ModelPrimitiveType int int int Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Depth                       ( ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetObjectList<XmlAttribute>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0x28 Attributes                  ( ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 AttributeCount              ( ModelPrimitiveType int int int Int32 )
            value.Space                                     = (XmlSpace)GetInt32(new IntPtr(p + 0x034)); // 0x34 Space                       ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.Lang                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Lang                        ( ModelPrimitiveType string string string String )
            value.NamespaceBoundary                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 NamespaceBoundary           ( ModelPrimitiveType int int int Int32 )
            value.NsTop                                     = GetInt32(new IntPtr(p + 0x044)); // 0x44 NsTop                       ( ModelPrimitiveType int int int Int32 )
            value.DefaultNamespace                          = GetObject<Namespace>(new IntPtr(p + 0x048), ReversePrism.DataModels.Namespace.FromPointer); // 0x48 DefaultNamespace            ( ModelClassType Namespace Namespace Namespace Pointer )

            return value;
        }
    }
}
