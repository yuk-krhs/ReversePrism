using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    public partial class FullConditionalExpressionWithType
    {
        public Type?                                    Type                                    { get; set; }

        public static FullConditionalExpressionWithType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FullConditionalExpressionWithType();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0270D9F3C910 0x28 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
