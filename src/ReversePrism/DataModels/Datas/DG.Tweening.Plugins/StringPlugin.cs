using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _Buffer                                  StringBuilder IL2CPP_TYPE_CLASS
    // 008 _OpenedTags                              List`1<char> IL2CPP_TYPE_GENERICINST
    public partial class StringPlugin
    {

        public static StringPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringPlugin();


            return value;
        }
    }
}
