using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 UnimplementedMethodCallHandler IL2CPP_TYPE_CLASS
    // 010 callHandlerImpl                          DuplexStreamingServerCallHandler`2<sbyte[], sbyte[]> IL2CPP_TYPE_GENERICINST
    public partial class UnimplementedMethodCallHandler
    {

        public static UnimplementedMethodCallHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnimplementedMethodCallHandler();


            return value;
        }
    }
}
