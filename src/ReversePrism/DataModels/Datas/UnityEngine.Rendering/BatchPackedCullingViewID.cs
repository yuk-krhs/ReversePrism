using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   ModelPrimitiveType ulong ulong ulong UInt64
    public partial class BatchPackedCullingViewID : DataModel
    {
        public ulong                                    Handle                                  { get; set; }

        public static BatchPackedCullingViewID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchPackedCullingViewID() { Pointer= p0 };

            value.Handle                                    = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Handle                      ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
