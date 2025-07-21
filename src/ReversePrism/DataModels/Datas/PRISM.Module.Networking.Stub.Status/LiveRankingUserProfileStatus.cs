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
    // 018 UserId                                   ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ProduceIdol                              ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstAchievementIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class LiveRankingUserProfileStatus : DataModel
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
            var value   = new LiveRankingUserProfileStatus() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0x28 ProduceIdol                 ( ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x030)); // 0x30 MstAchievementIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
