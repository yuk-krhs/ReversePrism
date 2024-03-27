using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClrTypes                                 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 SchemaTypes                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 000 empty_modifiers                          ParameterModifier[] IL2CPP_TYPE_SZARRAY
    public partial class ReflectionHelper
    {
        public Hashtable?                               ClrTypes                                { get; set; }
        public Hashtable?                               SchemaTypes                             { get; set; }

        public static ReflectionHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionHelper();

            value.ClrTypes                                  = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74B2058 0x10 ClrTypes                    ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SchemaTypes                               = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74B2078 0x18 SchemaTypes                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
