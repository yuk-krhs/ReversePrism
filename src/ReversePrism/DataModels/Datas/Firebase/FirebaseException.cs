using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ErrorCode                                ModelPrimitiveType int int int Int32
    public partial class FirebaseException : DataModel
    {
        public int                                      ErrorCode                               { get; set; }

        public static FirebaseException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseException() { Pointer= p0 };

            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x090)); // 0x90 ErrorCode                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
