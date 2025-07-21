using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CategoryId                             ModelPrimitiveType ushort ushort ushort UInt16
    public partial class ProfilerCategory : DataModel
    {
        public ushort                                   M_CategoryId                            { get; set; }

        public static ProfilerCategory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerCategory() { Pointer= p0 };

            value.M_CategoryId                              = GetUInt16(new IntPtr(p + 0x010)); // 0x10 M_CategoryId                ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
