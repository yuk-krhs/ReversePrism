using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Node                                     000186650D70 ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer
    // 018 ObjectType                               000186692850 ModelClassType Type Type Type Pointer
    // 020 _instance                                <object> IL2CPP_TYPE_OBJECT
    public partial class DefaultTypeDescriptor
    {
        public TypeDescriptionNode?                     Node                                    { get; set; }
        public Type?                                    ObjectType                              { get; set; }

        public static DefaultTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultTypeDescriptor();

            value.Node                                      = GetObject<TypeDescriptionNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeDescriptionNode.FromPointer); // 02700602AC58 0x10 Node                        ( 000186650D70 ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 02700602AC78 0x18 ObjectType                  ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
