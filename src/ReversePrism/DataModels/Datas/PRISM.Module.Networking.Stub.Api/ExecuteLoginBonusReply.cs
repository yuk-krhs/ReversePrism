using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteLoginBonusReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LoginBonusListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_loginBonusList_codec           FieldCodec`1<LoginBonusStatus> IL2CPP_TYPE_GENERICINST
    // 018 LoginBonusList                           000185CE4E38 ModelClassListType RepeatedField`1<LoginBonusStatus> RepeatedField`1<LoginBonusStatus> List<LoginBonusStatus> Pointer
    // 000 CostumeFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Costume                                  00018659DB60 ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer
    public partial class ExecuteLoginBonusReply
    {
        public List<LoginBonusStatus>?                  LoginBonusList                          { get; set; }
        public CharacterCostumeStatus?                  Costume                                 { get; set; }

        public static ExecuteLoginBonusReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteLoginBonusReply();

            value.LoginBonusList                            = GetObjectList<LoginBonusStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginBonusStatus.FromPointer); // 0270D2207898 0x18 LoginBonusList              ( 000185CE4E38 ModelClassListType RepeatedField`1<LoginBonusStatus> RepeatedField`1<LoginBonusStatus> List<LoginBonusStatus> Pointer )
            value.Costume                                   = GetObject<CharacterCostumeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterCostumeStatus.FromPointer); // 0270D22078D8 0x20 Costume                     ( 00018659DB60 ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer )

            return value;
        }
    }
}
