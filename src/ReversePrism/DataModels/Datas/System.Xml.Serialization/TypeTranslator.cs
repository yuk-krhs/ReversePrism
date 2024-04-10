using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 nameCache                                Hashtable IL2CPP_TYPE_CLASS
    // 008 primitiveTypes                           Hashtable IL2CPP_TYPE_CLASS
    // 010 PrimitiveArrayTypes                      0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 NullableTypes                            0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class TypeTranslator : DataModel
    {
        public Hashtable?                               PrimitiveArrayTypes                     { get; set; }
        public Hashtable?                               NullableTypes                           { get; set; }

        public static TypeTranslator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeTranslator() { Pointer= p0 };

            value.PrimitiveArrayTypes                       = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 024667515520 0x10 PrimitiveArrayTypes         ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NullableTypes                             = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 024667515540 0x18 NullableTypes               ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
