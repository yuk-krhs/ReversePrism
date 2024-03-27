using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Type                                     000186692F60 ModelClassType Type Type Type Pointer
    public partial class ObjectListField
    {
        public Type?                                    Type                                    { get; set; }

        public static ObjectListField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectListField();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0270D918D4B8 0x60 Type                        ( 000186692F60 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
