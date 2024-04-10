using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAchievementListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AchievementListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_achievementList_codec          FieldCodec`1<AchievementStatus> IL2CPP_TYPE_GENERICINST
    // 018 AchievementList                          000185CCD898 ModelClassListType RepeatedField`1<AchievementStatus> RepeatedField`1<AchievementStatus> List<AchievementStatus> Pointer
    public partial class GetAchievementListReply : DataModel
    {
        public List<AchievementStatus>?                 AchievementList                         { get; set; }

        public static GetAchievementListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAchievementListReply() { Pointer= p0 };

            value.AchievementList                           = GetObjectList<AchievementStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.AchievementStatus.FromPointer); // 024660B10B38 0x18 AchievementList             ( 000185CCD898 ModelClassListType RepeatedField`1<AchievementStatus> RepeatedField`1<AchievementStatus> List<AchievementStatus> Pointer )

            return value;
        }
    }
}
