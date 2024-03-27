using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpProfileStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 FavoriteProduceIdolFieldNumber           int IL2CPP_TYPE_I4
    // 020 FavoriteProduceIdol                      000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class PvpProfileStatus
    {
        public string                                   Name                                    { get; set; }
        public ProduceIdolStatus?                       FavoriteProduceIdol                     { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }

        public static PvpProfileStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpProfileStatus();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D1443B98 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.FavoriteProduceIdol                       = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D1443BD8 0x20 FavoriteProduceIdol         ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x028)); // 0270D1443C38 0x28 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
