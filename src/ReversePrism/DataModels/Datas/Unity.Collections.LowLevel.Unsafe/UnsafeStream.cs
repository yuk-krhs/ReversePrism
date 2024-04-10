using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BlockData                              0001866CD820 ModelEnumType Block Block Block Int32
    public partial class UnsafeStream : DataModel
    {
        public Block                                    M_BlockData                             { get; set; }

        public static UnsafeStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeStream() { Pointer= p0 };

            value.M_BlockData                               = (Block)GetInt32(new IntPtr(p + 0x010)); // 0246608B35D0 0x10 M_BlockData                 ( 0001866CD820 ModelEnumType Block Block Block Int32 )

            return value;
        }
    }
}
