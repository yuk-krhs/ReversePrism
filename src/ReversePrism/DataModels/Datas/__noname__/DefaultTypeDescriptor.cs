using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Node                                     ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer
    // 018 ObjectType                               ModelClassType Type Type Type Pointer
    // 020 _instance                                <object> IL2CPP_TYPE_OBJECT
    public partial class DefaultTypeDescriptor : DataModel
    {
        public TypeDescriptionNode?                     Node                                    { get; set; }
        public Type?                                    ObjectType                              { get; set; }

        public static DefaultTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultTypeDescriptor() { Pointer= p0 };

            value.Node                                      = GetObject<TypeDescriptionNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeDescriptionNode.FromPointer); // 0x10 Node                        ( ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 ObjectType                  ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
