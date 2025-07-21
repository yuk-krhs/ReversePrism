using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxProducePointGaugeValue                ModelPrimitiveType int int int Int32
    // 018 StartLessonReplyDto                      ModelClassType IStartLessonReply IStartLessonReply IStartLessonReply Pointer
    // 020 StartSpecialLessonReplyDto               ModelClassType IStartSpecialLessonReply IStartSpecialLessonReply IStartSpecialLessonReply Pointer
    // 028 StartAuditionReplyDto                    ModelClassType IStartAuditionReply IStartAuditionReply IStartAuditionReply Pointer
    // 030 ProduceNextOrderType                     ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 038 GetProduceCardList                       ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 SelectedSupportSkillList                 ModelClassListType IReadOnlyList`1<ISelectionSupportSkillStatus> IReadOnlyList`1<ISelectionSupportSkillStatus> List<ISelectionSupportSkillStatus> Pointer
    // 048 CacheScheduleDetailType                  ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 04C CacheScheduleLevel                       ModelPrimitiveType int int int Int32
    public partial class InGameDataManager : DataModel
    {
        public int                                      MaxProducePointGaugeValue               { get; set; }
        public IStartLessonReply?                       StartLessonReplyDto                     { get; set; }
        public IStartSpecialLessonReply?                StartSpecialLessonReplyDto              { get; set; }
        public IStartAuditionReply?                     StartAuditionReplyDto                   { get; set; }
        public ProduceNextOrderType                     ProduceNextOrderType                    { get; set; }
        public List<string>?                            GetProduceCardList                      { get; set; }
        public List<ISelectionSupportSkillStatus>?      SelectedSupportSkillList                { get; set; }
        public ScheduleDetailType                       CacheScheduleDetailType                 { get; set; }
        public int                                      CacheScheduleLevel                      { get; set; }

        public static InGameDataManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameDataManager() { Pointer= p0 };

            value.MaxProducePointGaugeValue                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxProducePointGaugeValue   ( ModelPrimitiveType int int int Int32 )
            value.StartLessonReplyDto                       = GetObject<IStartLessonReply>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStartLessonReply.FromPointer); // 0x18 StartLessonReplyDto         ( ModelClassType IStartLessonReply IStartLessonReply IStartLessonReply Pointer )
            value.StartSpecialLessonReplyDto                = GetObject<IStartSpecialLessonReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStartSpecialLessonReply.FromPointer); // 0x20 StartSpecialLessonReplyDto  ( ModelClassType IStartSpecialLessonReply IStartSpecialLessonReply IStartSpecialLessonReply Pointer )
            value.StartAuditionReplyDto                     = GetObject<IStartAuditionReply>(new IntPtr(p + 0x028), ReversePrism.DataModels.IStartAuditionReply.FromPointer); // 0x28 StartAuditionReplyDto       ( ModelClassType IStartAuditionReply IStartAuditionReply IStartAuditionReply Pointer )
            value.ProduceNextOrderType                      = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ProduceNextOrderType        ( ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.GetProduceCardList                        = GetStringList(new IntPtr(p + 0x038)); // 0x38 GetProduceCardList          ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedSupportSkillList                  = GetObjectList<ISelectionSupportSkillStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ISelectionSupportSkillStatus.FromPointer); // 0x40 SelectedSupportSkillList    ( ModelClassListType IReadOnlyList`1<ISelectionSupportSkillStatus> IReadOnlyList`1<ISelectionSupportSkillStatus> List<ISelectionSupportSkillStatus> Pointer )
            value.CacheScheduleDetailType                   = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x048)); // 0x48 CacheScheduleDetailType     ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.CacheScheduleLevel                        = GetInt32(new IntPtr(p + 0x04C)); // 0x4C CacheScheduleLevel          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
