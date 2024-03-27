using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyParameters                          <object>[] IL2CPP_TYPE_SZARRAY
    // 010 values                                   IDictionary`2<int, IExtensionValue> IL2CPP_TYPE_GENERICINST
    public partial class CustomOptions
    {

        public static CustomOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomOptions();


            return value;
        }
    }
}
