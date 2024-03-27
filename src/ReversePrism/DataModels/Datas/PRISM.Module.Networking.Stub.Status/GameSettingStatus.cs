using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GameSettingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CharacterBirthdayFieldNumber             int IL2CPP_TYPE_I4
    // 018 CharacterBirthday                        00018659C7B0 ModelClassType CharacterBirthdayStatus CharacterBirthdayStatus CharacterBirthdayStatus Pointer
    // 000 RecoverSettingListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_recoverSettingList_codec       FieldCodec`1<RecoverSettingStatus> IL2CPP_TYPE_GENERICINST
    // 020 RecoverSettingList                       000185CEEC28 ModelClassListType RepeatedField`1<RecoverSettingStatus> RepeatedField`1<RecoverSettingStatus> List<RecoverSettingStatus> Pointer
    // 000 ProducerBirthdayFieldNumber              int IL2CPP_TYPE_I4
    // 028 ProducerBirthday                         00018659CF10 ModelClassType ProducerBirthdayStatus ProducerBirthdayStatus ProducerBirthdayStatus Pointer
    // 000 TransferProductListFieldNumber           int IL2CPP_TYPE_I4
    // 010 _repeated_transferProductList_codec      FieldCodec`1<TransferProductStatus> IL2CPP_TYPE_GENERICINST
    // 030 TransferProductList                      000185CF54F8 ModelClassListType RepeatedField`1<TransferProductStatus> RepeatedField`1<TransferProductStatus> List<TransferProductStatus> Pointer
    public partial class GameSettingStatus
    {
        public CharacterBirthdayStatus?                 CharacterBirthday                       { get; set; }
        public List<RecoverSettingStatus>?              RecoverSettingList                      { get; set; }
        public ProducerBirthdayStatus?                  ProducerBirthday                        { get; set; }
        public List<TransferProductStatus>?             TransferProductList                     { get; set; }

        public static GameSettingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameSettingStatus();

            value.CharacterBirthday                         = GetObject<CharacterBirthdayStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterBirthdayStatus.FromPointer); // 0270D1989308 0x18 CharacterBirthday           ( 00018659C7B0 ModelClassType CharacterBirthdayStatus CharacterBirthdayStatus CharacterBirthdayStatus Pointer )
            value.RecoverSettingList                        = GetObjectList<RecoverSettingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RecoverSettingStatus.FromPointer); // 0270D1989368 0x20 RecoverSettingList          ( 000185CEEC28 ModelClassListType RepeatedField`1<RecoverSettingStatus> RepeatedField`1<RecoverSettingStatus> List<RecoverSettingStatus> Pointer )
            value.ProducerBirthday                          = GetObject<ProducerBirthdayStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProducerBirthdayStatus.FromPointer); // 0270D19893A8 0x28 ProducerBirthday            ( 00018659CF10 ModelClassType ProducerBirthdayStatus ProducerBirthdayStatus ProducerBirthdayStatus Pointer )
            value.TransferProductList                       = GetObjectList<TransferProductStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.TransferProductStatus.FromPointer); // 0270D1989408 0x30 TransferProductList         ( 000185CF54F8 ModelClassListType RepeatedField`1<TransferProductStatus> RepeatedField`1<TransferProductStatus> List<TransferProductStatus> Pointer )

            return value;
        }
    }
}
