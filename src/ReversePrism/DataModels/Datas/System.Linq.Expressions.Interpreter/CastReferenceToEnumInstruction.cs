using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        ModelClassType Type Type Type Pointer
    public partial class CastReferenceToEnumInstruction : DataModel
    {
        public Type?                                    T                                       { get; set; }

        public static CastReferenceToEnumInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CastReferenceToEnumInstruction() { Pointer= p0 };

            value.T                                         = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 T                           ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
