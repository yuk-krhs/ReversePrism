using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResultType                               ModelEnumType ResultType ResultType ResultType Int32
    // 014 StatusCode                               ModelEnumType StatusCode StatusCode StatusCode Int32
    // 018 ErrorCode                                ModelPrimitiveType string string string String
    // 020 Message                                  ModelPrimitiveType string string string String
    // 028 ErrorDetail                              ModelClassType IErrorDialogStatus IErrorDialogStatus IErrorDialogStatus Pointer
    // 030 Exception                                ModelClassType Exception Exception Exception Pointer
    public partial class NetworkError : DataModel
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
            var value   = new NetworkError() { Pointer= p0 };

            value.ResultType                                = (ResultType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ResultType                  ( ModelEnumType ResultType ResultType ResultType Int32 )
            value.StatusCode                                = (StatusCode)GetInt32(new IntPtr(p + 0x014)); // 0x14 StatusCode                  ( ModelEnumType StatusCode StatusCode StatusCode Int32 )
            value.ErrorCode                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ErrorCode                   ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )
            value.ErrorDetail                               = GetObject<IErrorDialogStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IErrorDialogStatus.FromPointer); // 0x28 ErrorDetail                 ( ModelClassType IErrorDialogStatus IErrorDialogStatus IErrorDialogStatus Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x030), ReversePrism.DataModels.Exception.FromPointer); // 0x30 Exception                   ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
