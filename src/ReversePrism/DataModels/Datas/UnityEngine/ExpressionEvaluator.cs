using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Random                                 PcgRandom IL2CPP_TYPE_VALUETYPE
    // 010 s_Operators                              Dictionary`2<string, Operator> IL2CPP_TYPE_GENERICINST
    public partial class ExpressionEvaluator
    {

        public static ExpressionEvaluator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionEvaluator();


            return value;
        }
    }
}
