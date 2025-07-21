using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteConnectProviderReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Result                                   ModelPrimitiveType bool bool bool Bool
    // 000 UserFieldNumber                          int IL2CPP_TYPE_I4
    // 020 User                                     ModelClassType SelfStatus SelfStatus SelfStatus Pointer
    public partial class ExecuteConnectProviderReply : DataModel
    {
        public bool                                     Result                                  { get; set; }
        public SelfStatus?                              User                                    { get; set; }

        public static ExecuteConnectProviderReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteConnectProviderReply() { Pointer= p0 };

            value.Result                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 Result                      ( ModelPrimitiveType bool bool bool Bool )
            value.User                                      = GetObject<SelfStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelfStatus.FromPointer); // 0x20 User                        ( ModelClassType SelfStatus SelfStatus SelfStatus Pointer )

            return value;
        }
    }
}
