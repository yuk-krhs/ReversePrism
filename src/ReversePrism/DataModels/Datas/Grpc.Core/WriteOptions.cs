using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  WriteOptions IL2CPP_TYPE_CLASS
    // 010 Flags                                    00018655FDA0 ModelEnumType WriteFlags WriteFlags WriteFlags Int32
    public partial class WriteOptions : DataModel
    {
        public WriteFlags                               Flags                                   { get; set; }

        public static WriteOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteOptions() { Pointer= p0 };

            value.Flags                                     = (WriteFlags)GetInt32(new IntPtr(p + 0x010)); // 0246693B53B0 0x10 Flags                       ( 00018655FDA0 ModelEnumType WriteFlags WriteFlags WriteFlags Int32 )

            return value;
        }
    }
}
