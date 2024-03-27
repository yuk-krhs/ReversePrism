using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NullCollection                           int IL2CPP_TYPE_I4
    // 000 WideTag                                  sbyte IL2CPP_TYPE_U1
    // 000 ReferenceId                              sbyte IL2CPP_TYPE_U1
    // 000 Reserved1                                sbyte IL2CPP_TYPE_U1
    // 000 Reserved2                                sbyte IL2CPP_TYPE_U1
    // 000 Reserved3                                sbyte IL2CPP_TYPE_U1
    // 000 Reserved4                                sbyte IL2CPP_TYPE_U1
    // 000 Reserved5                                sbyte IL2CPP_TYPE_U1
    // 000 NullObject                               sbyte IL2CPP_TYPE_U1
    public partial class MemoryPackCode
    {

        public static MemoryPackCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackCode();


            return value;
        }
    }
}
