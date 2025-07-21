using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Hash                                     ModelPrimitiveType int int int Int32
    public partial class HashException : DataModel
    {
        public int                                      Hash                                    { get; set; }

        public static HashException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HashException() { Pointer= p0 };

            value.Hash                                      = GetInt32(new IntPtr(p + 0x090)); // 0x90 Hash                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
