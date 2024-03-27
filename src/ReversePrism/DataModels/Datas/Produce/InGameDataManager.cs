using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxProducePointGaugeValue                0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 CurrentExecuteScheduleIndex              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 StartLessonReplyDto                      00018664F4F0 ModelClassType IStartLessonReply IStartLessonReply IStartLessonReply Pointer
    // 020 StartSpecialLessonReplyDto               000186655E30 ModelClassType IStartSpecialLessonReply IStartSpecialLessonReply IStartSpecialLessonReply Pointer
    // 028 StartAuditionReplyDto                    00018664E6A0 ModelClassType IStartAuditionReply IStartAuditionReply IStartAuditionReply Pointer
    // 030 ProduceNextOrderType                     00018660CD30 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 038 GetProduceCardList                       000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 SelectedSupportSkill                     000186633DE0 ModelClassType ISelectionSupportSkillStatus ISelectionSupportSkillStatus ISelectionSupportSkillStatus Pointer
    // 048 DeleteProduceCardList                    000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 050 RankupProduceCardList                    000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 058 CacheScheduleDetailType                  0001866150C0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 05C CacheScheduleLevel                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class InGameDataManager
    {
        public int                                      MaxProducePointGaugeValue               { get; set; }
        public int                                      CurrentExecuteScheduleIndex             { get; set; }
        public IStartLessonReply?                       StartLessonReplyDto                     { get; set; }
        public IStartSpecialLessonReply?                StartSpecialLessonReplyDto              { get; set; }
        public IStartAuditionReply?                     StartAuditionReplyDto                   { get; set; }
        public ProduceNextOrderType                     ProduceNextOrderType                    { get; set; }
        public List<string>?                            GetProduceCardList                      { get; set; }
        public ISelectionSupportSkillStatus?            SelectedSupportSkill                    { get; set; }
        public List<string>?                            DeleteProduceCardList                   { get; set; }
        public List<string>?                            RankupProduceCardList                   { get; set; }
        public ScheduleDetailType                       CacheScheduleDetailType                 { get; set; }
        public int                                      CacheScheduleLevel                      { get; set; }

        public static InGameDataManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameDataManager();

            value.MaxProducePointGaugeValue                 = GetInt32(new IntPtr(p + 0x010)); // 0270D4B93988 0x10 MaxProducePointGaugeValue   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentExecuteScheduleIndex               = GetInt32(new IntPtr(p + 0x014)); // 0270D4B939A8 0x14 CurrentExecuteScheduleIndex ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StartLessonReplyDto                       = GetObject<IStartLessonReply>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStartLessonReply.FromPointer); // 0270D4B939C8 0x18 StartLessonReplyDto         ( 00018664F4F0 ModelClassType IStartLessonReply IStartLessonReply IStartLessonReply Pointer )
            value.StartSpecialLessonReplyDto                = GetObject<IStartSpecialLessonReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStartSpecialLessonReply.FromPointer); // 0270D4B939E8 0x20 StartSpecialLessonReplyDto  ( 000186655E30 ModelClassType IStartSpecialLessonReply IStartSpecialLessonReply IStartSpecialLessonReply Pointer )
            value.StartAuditionReplyDto                     = GetObject<IStartAuditionReply>(new IntPtr(p + 0x028), ReversePrism.DataModels.IStartAuditionReply.FromPointer); // 0270D4B93A08 0x28 StartAuditionReplyDto       ( 00018664E6A0 ModelClassType IStartAuditionReply IStartAuditionReply IStartAuditionReply Pointer )
            value.ProduceNextOrderType                      = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x030)); // 0270D4B93A28 0x30 ProduceNextOrderType        ( 00018660CD30 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.GetProduceCardList                        = GetStringList(new IntPtr(p + 0x038)); // 0270D4B93A48 0x38 GetProduceCardList          ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedSupportSkill                      = GetObject<ISelectionSupportSkillStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ISelectionSupportSkillStatus.FromPointer); // 0270D4B93A68 0x40 SelectedSupportSkill        ( 000186633DE0 ModelClassType ISelectionSupportSkillStatus ISelectionSupportSkillStatus ISelectionSupportSkillStatus Pointer )
            value.DeleteProduceCardList                     = GetStringList(new IntPtr(p + 0x048)); // 0270D4B93A88 0x48 DeleteProduceCardList       ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.RankupProduceCardList                     = GetStringList(new IntPtr(p + 0x050)); // 0270D4B93AA8 0x50 RankupProduceCardList       ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CacheScheduleDetailType                   = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x058)); // 0270D4B93AC8 0x58 CacheScheduleDetailType     ( 0001866150C0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.CacheScheduleLevel                        = GetInt32(new IntPtr(p + 0x05C)); // 0270D4B93AE8 0x5C CacheScheduleLevel          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
