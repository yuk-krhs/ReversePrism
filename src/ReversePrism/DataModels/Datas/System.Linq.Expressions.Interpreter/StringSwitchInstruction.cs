using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _cases                                   Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 018 _nullCase                                StrongBox`1<int> IL2CPP_TYPE_GENERICINST
    public partial class StringSwitchInstruction : DataModel
    {

        public static StringSwitchInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringSwitchInstruction() { Pointer= p0 };


            return value;
        }
    }
}
