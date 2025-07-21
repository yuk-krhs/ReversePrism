using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_namespaces                             XHashtable`1<WeakReference> IL2CPP_TYPE_GENERICINST
    // 008 s_refNone                                WeakReference IL2CPP_TYPE_CLASS
    // 010 S_refXml                                 ModelClassType WeakReference WeakReference WeakReference Pointer
    // 018 S_refXmlns                               ModelClassType WeakReference WeakReference WeakReference Pointer
    // 010 NamespaceName                            ModelPrimitiveType string string string String
    // 018 HashCode                                 ModelPrimitiveType int int int Int32
    // 020 _names                                   XHashtable`1<XName> IL2CPP_TYPE_GENERICINST
    public partial class XNamespace : DataModel
    {
        public WeakReference?                           S_refXml                                { get; set; }
        public WeakReference?                           S_refXmlns                              { get; set; }
        public string                                   NamespaceName                           { get; set; }
        public int                                      HashCode                                { get; set; }

        public static XNamespace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XNamespace() { Pointer= p0 };

            value.S_refXml                                  = GetObject<WeakReference>(new IntPtr(p + 0x010), ReversePrism.DataModels.WeakReference.FromPointer); // 0x10 S_refXml                    ( ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.S_refXmlns                                = GetObject<WeakReference>(new IntPtr(p + 0x018), ReversePrism.DataModels.WeakReference.FromPointer); // 0x18 S_refXmlns                  ( ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.NamespaceName                             = GetString(new IntPtr(p + 0x010)); // 0x10 NamespaceName               ( ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HashCode                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
