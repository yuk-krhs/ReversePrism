using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 types                                    Dictionary`2<string, MessageDescriptor> IL2CPP_TYPE_GENERICINST
    // 018 fileDescriptorNames                      HashSet`1<string> IL2CPP_TYPE_GENERICINST
    public partial class Builder
    {

        public static Builder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Builder();


            return value;
        }
    }
}
