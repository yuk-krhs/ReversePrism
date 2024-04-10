using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Values>k__BackingField                  IDictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    public partial class InitializationOptions : DataModel
    {

        public static InitializationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitializationOptions() { Pointer= p0 };


            return value;
        }
    }
}
