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
    // 018 Result                                   ModelPrimitiveType bool bool bool Bool
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 020 UserId                                   ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Secret                                   ModelPrimitiveType string string string String
    // 000 ConnectionResultFieldNumber              int IL2CPP_TYPE_I4
    // 030 ConnectionResult                         ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 038 SearchId                                 ModelPrimitiveType string string string String
    public partial class ExecuteTransferReply : DataModel
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
            var value   = new ExecuteTransferReply() { Pointer= p0 };

            value.Result                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 Result                      ( ModelPrimitiveType bool bool bool Bool )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0x20 UserId                      ( ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Secret                      ( ModelPrimitiveType string string string String )
            value.ConnectionResult                          = (ConnectionResultType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ConnectionResult            ( ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32 )
            value.SearchId                                  = GetString(new IntPtr(p + 0x038)); // 0x38 SearchId                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
