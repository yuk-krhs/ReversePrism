using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheGetProduceTopReplyDto               000186546C80 ModelClassType IGetProduceTopReply IGetProduceTopReply IGetProduceTopReply Pointer
    // 018 SelectedScheduleIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IsTouchMiniCharacterDisplay              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 scheduleIndexDic                         Dictionary`2<ScheduleType, int> IL2CPP_TYPE_GENERICINST
    // 028 WeekScheduleList                         000185CEA238 ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer
    // 030 ProduceBaseInfo                          0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    public partial class ScheduleModel
    {
        public IGetProduceTopReply?                     CacheGetProduceTopReplyDto              { get; set; }
        public int                                      SelectedScheduleIndex                   { get; set; }
        public bool                                     IsTouchMiniCharacterDisplay             { get; set; }
        public List<IWeekScheduleStatus>?               WeekScheduleList                        { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }

        public static ScheduleModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleModel();

            value.CacheGetProduceTopReplyDto                = GetObject<IGetProduceTopReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGetProduceTopReply.FromPointer); // 0270D5D083D0 0x10 CacheGetProduceTopReplyDto  ( 000186546C80 ModelClassType IGetProduceTopReply IGetProduceTopReply IGetProduceTopReply Pointer )
            value.SelectedScheduleIndex                     = GetInt32(new IntPtr(p + 0x018)); // 0270D5D083F0 0x18 SelectedScheduleIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsTouchMiniCharacterDisplay               = GetBool(new IntPtr(p + 0x01C)); // 0270D5D08410 0x1C IsTouchMiniCharacterDisplay ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WeekScheduleList                          = GetObjectList<IWeekScheduleStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IWeekScheduleStatus.FromPointer); // 0270D5D08450 0x28 WeekScheduleList            ( 000185CEA238 ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0270D5D08470 0x30 ProduceBaseInfo             ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )

            return value;
        }
    }
}
