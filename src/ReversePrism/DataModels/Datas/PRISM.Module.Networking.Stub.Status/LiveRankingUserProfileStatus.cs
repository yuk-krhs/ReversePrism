using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveRankingUserProfileStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ProduceIdol                              000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class LiveRankingUserProfileStatus
    {
        public string                                   UserId                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }

        public static LiveRankingUserProfileStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveRankingUserProfileStatus();

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0270D1354030 0x18 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D1354070 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D13540B0 0x28 ProduceIdol                 ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x030)); // 0270D1354110 0x30 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
