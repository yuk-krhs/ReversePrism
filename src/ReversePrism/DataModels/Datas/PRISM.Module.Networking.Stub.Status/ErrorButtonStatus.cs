using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ErrorButtonStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ButtonValueFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ButtonValue                              ModelPrimitiveType string string string String
    // 000 ErrorDialogButtonTypeFieldNumber         int IL2CPP_TYPE_I4
    // 020 ErrorDialogButtonType                    ModelEnumType ErrorDialogButtonType ErrorDialogButtonType ErrorDialogButtonType Int32
    // 000 ButtonTextFieldNumber                    int IL2CPP_TYPE_I4
    // 028 ButtonText                               ModelPrimitiveType string string string String
    public partial class ErrorButtonStatus : DataModel
    {
        public string                                   ButtonValue                             { get; set; }
        public ErrorDialogButtonType                    ErrorDialogButtonType                   { get; set; }
        public string                                   ButtonText                              { get; set; }

        public static ErrorButtonStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorButtonStatus() { Pointer= p0 };

            value.ButtonValue                               = GetString(new IntPtr(p + 0x018)); // 0x18 ButtonValue                 ( ModelPrimitiveType string string string String )
            value.ErrorDialogButtonType                     = (ErrorDialogButtonType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ErrorDialogButtonType       ( ModelEnumType ErrorDialogButtonType ErrorDialogButtonType ErrorDialogButtonType Int32 )
            value.ButtonText                                = GetString(new IntPtr(p + 0x028)); // 0x28 ButtonText                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
