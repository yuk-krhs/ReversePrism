using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteTransferReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Result                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 020 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Secret                                   000186671910 ModelPrimitiveType string string string String
    // 000 ConnectionResultFieldNumber              int IL2CPP_TYPE_I4
    // 030 ConnectionResult                         000186604590 ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 038 SearchId                                 000186671910 ModelPrimitiveType string string string String
    public partial class ExecuteTransferReply
    {
        public bool                                     Result                                  { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Secret                                  { get; set; }
        public ConnectionResultType                     ConnectionResult                        { get; set; }
        public string                                   SearchId                                { get; set; }

        public static ExecuteTransferReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteTransferReply();

            value.Result                                    = GetBool(new IntPtr(p + 0x018)); // 0270D0B45F80 0x18 Result                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0270D0B45FC0 0x20 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x028)); // 0270D0B46000 0x28 Secret                      ( 000186671910 ModelPrimitiveType string string string String )
            value.ConnectionResult                          = (ConnectionResultType)GetInt32(new IntPtr(p + 0x030)); // 0270D0B46040 0x30 ConnectionResult            ( 000186604590 ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32 )
            value.SearchId                                  = GetString(new IntPtr(p + 0x038)); // 0270D0B46080 0x38 SearchId                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
