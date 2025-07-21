using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nativeArrayBuffer                        IntPtr IL2CPP_TYPE_PTR
    // 018 LengthInBytes                            ModelPrimitiveType long long long Int64
    public partial class AsyncRequestNativeArrayData : DataModel
    {
        public long                                     LengthInBytes                           { get; set; }

        public static AsyncRequestNativeArrayData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncRequestNativeArrayData() { Pointer= p0 };

            value.LengthInBytes                             = GetInt64(new IntPtr(p + 0x018)); // 0x18 LengthInBytes               ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
