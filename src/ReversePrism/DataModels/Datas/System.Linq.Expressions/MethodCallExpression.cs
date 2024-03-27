using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class MethodCallExpression
    {
        public MethodInfo?                              Method                                  { get; set; }

        public static MethodCallExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodCallExpression();

            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D9F34508 0x10 Method                      ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
