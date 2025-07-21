using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTransferURLArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ProviderType                             ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 PassPhraseFieldNumber                    int IL2CPP_TYPE_I4
    // 020 PassPhrase                               ModelPrimitiveType string string string String
    public partial class GetTransferURLArgs : DataModel
    {
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   PassPhrase                              { get; set; }

        public static GetTransferURLArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTransferURLArgs() { Pointer= p0 };

            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ProviderType                ( ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.PassPhrase                                = GetString(new IntPtr(p + 0x020)); // 0x20 PassPhrase                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
