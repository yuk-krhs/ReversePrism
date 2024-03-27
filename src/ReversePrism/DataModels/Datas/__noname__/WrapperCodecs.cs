using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Codecs                                   Dictionary`2<Type, <object>> IL2CPP_TYPE_GENERICINST
    // 008 Readers                                  Dictionary`2<Type, <object>> IL2CPP_TYPE_GENERICINST
    public partial class WrapperCodecs
    {

        public static WrapperCodecs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WrapperCodecs();


            return value;
        }
    }
}
