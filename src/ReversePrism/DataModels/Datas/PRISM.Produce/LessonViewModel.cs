using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 020 ChallengeMission                         ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer
    // 028 ChallengeMissionTargetPIdol              ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 030 ChallengeMissionUpParameter              ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer
    public partial class LessonViewModel : DataModel
    {
        public int                                      ScheduleLevel                           { get; set; }
        public IChallengeMissionStatus?                 ChallengeMission                        { get; set; }
        public IInProduceIdolStatus?                    ChallengeMissionTargetPIdol             { get; set; }
        public IBuildUpParameterValueStatus?            ChallengeMissionUpParameter             { get; set; }

        public static LessonViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonViewModel() { Pointer= p0 };

            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.ChallengeMission                          = GetObject<IChallengeMissionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IChallengeMissionStatus.FromPointer); // 0x20 ChallengeMission            ( ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer )
            value.ChallengeMissionTargetPIdol               = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0x28 ChallengeMissionTargetPIdol ( ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.ChallengeMissionUpParameter               = GetObject<IBuildUpParameterValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IBuildUpParameterValueStatus.FromPointer); // 0x30 ChallengeMissionUpParameter ( ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
