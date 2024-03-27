using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteLoginBonusPassReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LastPassFieldNumber                      int IL2CPP_TYPE_I4
    // 018 LastPass                                 0001865B77B0 ModelClassType LoginBonusPassStatus LoginBonusPassStatus LoginBonusPassStatus Pointer
    public partial class ExecuteLoginBonusPassReply
    {
        public LoginBonusPassStatus?                    LastPass                                { get; set; }

        public static ExecuteLoginBonusPassReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteLoginBonusPassReply();

            value.LastPass                                  = GetObject<LoginBonusPassStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginBonusPassStatus.FromPointer); // 0270D2261D18 0x18 LastPass                    ( 0001865B77B0 ModelClassType LoginBonusPassStatus LoginBonusPassStatus LoginBonusPassStatus Pointer )

            return value;
        }
    }
}
