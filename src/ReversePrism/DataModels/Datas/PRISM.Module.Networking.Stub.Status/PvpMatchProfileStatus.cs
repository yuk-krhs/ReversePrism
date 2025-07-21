using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpMatchProfileStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Rank                                     ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAchievementIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class PvpMatchProfileStatus : DataModel
    {
        public int                                      Rank                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }

        public static PvpMatchProfileStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpMatchProfileStatus() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstAchievementIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
