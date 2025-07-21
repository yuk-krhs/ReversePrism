using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NamespaceList                            ModelClassType NamespaceList NamespaceList NamespaceList Pointer
    // 018 particle                                 <object> IL2CPP_TYPE_OBJECT
    public partial class NamespaceListNode : DataModel
    {
        public NamespaceList?                           NamespaceList                           { get; set; }

        public static NamespaceListNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceListNode() { Pointer= p0 };

            value.NamespaceList                             = GetObject<NamespaceList>(new IntPtr(p + 0x010), ReversePrism.DataModels.NamespaceList.FromPointer); // 0x10 NamespaceList               ( ModelClassType NamespaceList NamespaceList NamespaceList Pointer )

            return value;
        }
    }
}
