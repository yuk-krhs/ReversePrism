using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteConnectProviderAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Result                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UserFieldNumber                          int IL2CPP_TYPE_I4
    // 020 User                                     000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer
    public partial class ExecuteConnectProviderAndTokenReply : DataModel
    {
        public bool                                     Result                                  { get; set; }
        public SelfStatus?                              User                                    { get; set; }

        public static ExecuteConnectProviderAndTokenReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteConnectProviderAndTokenReply() { Pointer= p0 };

            value.Result                                    = GetBool(new IntPtr(p + 0x018)); // 024660B24780 0x18 Result                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.User                                      = GetObject<SelfStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelfStatus.FromPointer); // 024660B247C0 0x20 User                        ( 000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer )

            return value;
        }
    }
}
