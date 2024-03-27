using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AchievementStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AchievementIdFieldNumber                 int IL2CPP_TYPE_I4
    // 018 AchievementId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AchievementTypeFieldNumber               int IL2CPP_TYPE_I4
    // 01C AchievementType                          000186678350 ModelEnumType AchievementType AchievementType AchievementType Int32
    // 000 AchievementCategoryFieldNumber           int IL2CPP_TYPE_I4
    // 020 AchievementCategory                      000186673420 ModelEnumType AchievementCategory AchievementCategory AchievementCategory Int32
    public partial class AchievementStatus
    {
        public int                                      AchievementId                           { get; set; }
        public AchievementType                          AchievementType                         { get; set; }
        public AchievementCategory                      AchievementCategory                     { get; set; }

        public static AchievementStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementStatus();

            value.AchievementId                             = GetInt32(new IntPtr(p + 0x018)); // 0270D0B26040 0x18 AchievementId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AchievementType                           = (AchievementType)GetInt32(new IntPtr(p + 0x01C)); // 0270D0B26080 0x1C AchievementType             ( 000186678350 ModelEnumType AchievementType AchievementType AchievementType Int32 )
            value.AchievementCategory                       = (AchievementCategory)GetInt32(new IntPtr(p + 0x020)); // 0270D0B260C0 0x20 AchievementCategory         ( 000186673420 ModelEnumType AchievementCategory AchievementCategory AchievementCategory Int32 )

            return value;
        }
    }
}
