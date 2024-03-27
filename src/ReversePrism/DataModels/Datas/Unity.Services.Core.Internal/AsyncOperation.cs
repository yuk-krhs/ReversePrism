using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDone                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 Status                                   0001866FCA20 ModelEnumType AsyncOperationStatus AsyncOperationStatus AsyncOperationStatus Int32
    // 018 Exception                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 020 m_CompletedCallback                      Action`1<IAsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class AsyncOperation
    {
        public bool                                     IsDone                                  { get; set; }
        public AsyncOperationStatus                     Status                                  { get; set; }
        public Exception?                               Exception                               { get; set; }

        public static AsyncOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncOperation();

            value.IsDone                                    = GetBool(new IntPtr(p + 0x010)); // 0270DBA5E070 0x10 IsDone                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Status                                    = (AsyncOperationStatus)GetInt32(new IntPtr(p + 0x014)); // 0270DBA5E090 0x14 Status                      ( 0001866FCA20 ModelEnumType AsyncOperationStatus AsyncOperationStatus AsyncOperationStatus Int32 )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0270DBA5E0B0 0x18 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
