using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResultType                               000186675FC0 ModelEnumType ResultType ResultType ResultType Int32
    // 014 StatusCode                               000186587260 ModelEnumType StatusCode StatusCode StatusCode Int32
    // 018 ErrorCode                                000186671910 ModelPrimitiveType string string string String
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    // 028 ErrorDetail                              0001867630D0 ModelClassType IErrorDialogStatus IErrorDialogStatus IErrorDialogStatus Pointer
    // 030 Exception                                0001865CB1C0 ModelClassType Exception Exception Exception Pointer
    public partial class NetworkError
    {
        public ResultType                               ResultType                              { get; set; }
        public StatusCode                               StatusCode                              { get; set; }
        public string                                   ErrorCode                               { get; set; }
        public string                                   Message                                 { get; set; }
        public IErrorDialogStatus?                      ErrorDetail                             { get; set; }
        public Exception?                               Exception                               { get; set; }

        public static NetworkError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetworkError();

            value.ResultType                                = (ResultType)GetInt32(new IntPtr(p + 0x010)); // 0270075681F8 0x10 ResultType                  ( 000186675FC0 ModelEnumType ResultType ResultType ResultType Int32 )
            value.StatusCode                                = (StatusCode)GetInt32(new IntPtr(p + 0x014)); // 027007568218 0x14 StatusCode                  ( 000186587260 ModelEnumType StatusCode StatusCode StatusCode Int32 )
            value.ErrorCode                                 = GetString(new IntPtr(p + 0x018)); // 027007568238 0x18 ErrorCode                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 027007568258 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ErrorDetail                               = GetObject<IErrorDialogStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IErrorDialogStatus.FromPointer); // 027007568278 0x28 ErrorDetail                 ( 0001867630D0 ModelClassType IErrorDialogStatus IErrorDialogStatus IErrorDialogStatus Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x030), ReversePrism.DataModels.Exception.FromPointer); // 027007568298 0x30 Exception                   ( 0001865CB1C0 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
