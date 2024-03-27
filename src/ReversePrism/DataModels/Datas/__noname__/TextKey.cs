using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GameStartMessage                         ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 010 PressToStart                             ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 020 PressToTransferData                      ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    public partial class TextKey
    {

        public static TextKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextKey();


            return value;
        }
    }
}
