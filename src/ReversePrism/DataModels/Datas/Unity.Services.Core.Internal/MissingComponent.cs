using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntendedType                             0001866936B0 ModelClassType Type Type Type Pointer
    public partial class MissingComponent
    {
        public Type?                                    IntendedType                            { get; set; }

        public static MissingComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissingComponent();

            value.IntendedType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027003B60748 0x10 IntendedType                ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
