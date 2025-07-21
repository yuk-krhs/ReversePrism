using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GenericTypeName                          ModelPrimitiveType string string string String
    // 018 genericParams                            <object>[] IL2CPP_TYPE_SZARRAY
    // 020 nestedParamCounts                        IList`1<int> IL2CPP_TYPE_GENERICINST
    public partial class GenericNameProvider : DataModel
    {
        public string                                   GenericTypeName                         { get; set; }

        public static GenericNameProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenericNameProvider() { Pointer= p0 };

            value.GenericTypeName                           = GetString(new IntPtr(p + 0x010)); // 0x10 GenericTypeName             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
