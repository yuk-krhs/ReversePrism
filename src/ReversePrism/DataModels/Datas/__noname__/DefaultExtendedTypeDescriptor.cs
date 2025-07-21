using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Node                                     ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer
    // 018 _instance                                <object> IL2CPP_TYPE_OBJECT
    public partial class DefaultExtendedTypeDescriptor : DataModel
    {
        public TypeDescriptionNode?                     Node                                    { get; set; }

        public static DefaultExtendedTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultExtendedTypeDescriptor() { Pointer= p0 };

            value.Node                                      = GetObject<TypeDescriptionNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeDescriptionNode.FromPointer); // 0x10 Node                        ( ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer )

            return value;
        }
    }
}
