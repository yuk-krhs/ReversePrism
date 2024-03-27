using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Method                                   000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class MethodBinaryExpression
    {
        public MethodInfo?                              Method                                  { get; set; }

        public static MethodBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodBinaryExpression();

            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D9F17448 0x30 Method                      ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
