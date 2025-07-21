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
    // 018 LoginBonusList                           ModelClassListType RepeatedField`1<LoginBonusStatus> RepeatedField`1<LoginBonusStatus> List<LoginBonusStatus> Pointer
    // 000 CostumeFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Costume                                  ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer
    public partial class ExecuteLoginBonusReply : DataModel
    {
        public List<LoginBonusStatus>?                  LoginBonusList                          { get; set; }
        public CharacterCostumeStatus?                  Costume                                 { get; set; }

        public static ExecuteLoginBonusReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteLoginBonusReply() { Pointer= p0 };

            value.LoginBonusList                            = GetObjectList<LoginBonusStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginBonusStatus.FromPointer); // 0x18 LoginBonusList              ( ModelClassListType RepeatedField`1<LoginBonusStatus> RepeatedField`1<LoginBonusStatus> List<LoginBonusStatus> Pointer )
            value.Costume                                   = GetObject<CharacterCostumeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterCostumeStatus.FromPointer); // 0x20 Costume                     ( ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer )

            return value;
        }
    }
}
