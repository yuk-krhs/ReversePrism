using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   FromEventPatternObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 observer                                 IObserver`1<EventPattern`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 handler                                  <var> IL2CPP_TYPE_VAR
    public partial class FromEventPattern : DataModel
    {

        public static FromEventPattern? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FromEventPattern() { Pointer= p0 };


            return value;
        }
    }
}
