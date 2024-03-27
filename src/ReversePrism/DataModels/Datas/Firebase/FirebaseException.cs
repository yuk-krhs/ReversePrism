using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ErrorCode                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FirebaseException
    {
        public int                                      ErrorCode                               { get; set; }

        public static FirebaseException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseException();

            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x090)); // 0270DB744950 0x90 ErrorCode                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
