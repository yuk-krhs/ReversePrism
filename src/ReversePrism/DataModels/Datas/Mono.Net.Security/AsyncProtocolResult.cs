using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserResult                               0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Error                                    0001865CC020 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    public partial class AsyncProtocolResult
    {
        public int                                      UserResult                              { get; set; }
        public ExceptionDispatchInfo?                   Error                                   { get; set; }

        public static AsyncProtocolResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncProtocolResult();

            value.UserResult                                = GetInt32(new IntPtr(p + 0x010)); // 0270D790C8A8 0x10 UserResult                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D790C8C8 0x18 Error                       ( 0001865CC020 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )

            return value;
        }
    }
}
