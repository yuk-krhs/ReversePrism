using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConverterType                            ModelClassType Type Type Type Pointer
    // 018 <ConverterParameters>k__BackingField     <object>[] IL2CPP_TYPE_SZARRAY
    public partial class JsonConverterAttribute : DataModel
    {
        public Type?                                    ConverterType                           { get; set; }

        public static JsonConverterAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonConverterAttribute() { Pointer= p0 };

            value.ConverterType                             = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ConverterType               ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
