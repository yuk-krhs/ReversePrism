using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SerializationBinder                      ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    public partial class SerializationBinderAdapter : DataModel
    {
        public SerializationBinder?                     SerializationBinder                     { get; set; }

        public static SerializationBinderAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationBinderAdapter() { Pointer= p0 };

            value.SerializationBinder                       = GetObject<SerializationBinder>(new IntPtr(p + 0x010), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0x10 SerializationBinder         ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )

            return value;
        }
    }
}
