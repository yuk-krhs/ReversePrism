using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConfirmTransferArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ProviderType                             0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 PlatformFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Platform                                 000186671910 ModelPrimitiveType string string string String
    public partial class ConfirmTransferArgs : DataModel
    {
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   Token                                   { get; set; }
        public string                                   Platform                                { get; set; }

        public static ConfirmTransferArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfirmTransferArgs() { Pointer= p0 };

            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x018)); // 0245A3B05E28 0x18 ProviderType                ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x020)); // 0245A3B05E68 0x20 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Platform                                  = GetString(new IntPtr(p + 0x028)); // 0245A3B05EA8 0x28 Platform                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
