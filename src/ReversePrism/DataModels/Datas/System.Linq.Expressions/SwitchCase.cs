using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <TestValues>k__BackingField              ReadOnlyCollection`1<Expression> IL2CPP_TYPE_GENERICINST
    // 018 Body                                     0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class SwitchCase
    {
        public Expression?                              Body                                    { get; set; }

        public static SwitchCase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchCase();

            value.Body                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F80520 0x18 Body                        ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
