using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nativeArrayBuffer                        IntPtr IL2CPP_TYPE_PTR
    // 018 LengthInBytes                            0001865F7E40 ModelPrimitiveType long long long Int64
    public partial class AsyncRequestNativeArrayData
    {
        public long                                     LengthInBytes                           { get; set; }

        public static AsyncRequestNativeArrayData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncRequestNativeArrayData();

            value.LengthInBytes                             = GetInt64(new IntPtr(p + 0x018)); // 027002446FA8 0x18 LengthInBytes               ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
