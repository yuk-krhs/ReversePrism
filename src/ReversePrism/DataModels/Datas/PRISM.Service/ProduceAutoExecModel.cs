using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 onProduceStartAsync                      Func`3<IProduceBaseInfoStatus, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 020 onProduceResumeAsync                     Func`3<IReadOnlyList`1<IProduceAutoPlayProgressedSeasonStatus>, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 028 onCheckAutoExecStop                      Func`3<ProduceNextOrderType, IProduceBaseInfoStatus, bool> IL2CPP_TYPE_GENERICINST
    // 030 SelectStrategyModel                      00018657F1A0 ModelClassType ProduceSelectStrategyAutoExecModel ProduceSelectStrategyAutoExecModel ProduceSelectStrategyAutoExecModel Pointer
    // 038 SelectScheduleModel                      00018657EAB0 ModelClassType ProduceSelectScheduleAutoExecModel ProduceSelectScheduleAutoExecModel ProduceSelectScheduleAutoExecModel Pointer
    // 040 InGameModel                              000186556690 ModelClassType ProduceInGameAutoExecModel ProduceInGameAutoExecModel ProduceInGameAutoExecModel Pointer
    // 048 ScenarioModel                            00018657CDA0 ModelClassType ProduceScenarioAutoExecModel ProduceScenarioAutoExecModel ProduceScenarioAutoExecModel Pointer
    // 050 ResumeModel                              000186579890 ModelClassType ProduceResumeAutoExecModel ProduceResumeAutoExecModel ProduceResumeAutoExecModel Pointer
    public partial class ProduceAutoExecModel
    {
        public ProduceService?                          Service                                 { get; set; }
        public ProduceSelectStrategyAutoExecModel?      SelectStrategyModel                     { get; set; }
        public ProduceSelectScheduleAutoExecModel?      SelectScheduleModel                     { get; set; }
        public ProduceInGameAutoExecModel?              InGameModel                             { get; set; }
        public ProduceScenarioAutoExecModel?            ScenarioModel                           { get; set; }
        public ProduceResumeAutoExecModel?              ResumeModel                             { get; set; }

        public static ProduceAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoExecModel();

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 0270D645FBA8 0x10 Service                     ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )
            value.SelectStrategyModel                       = GetObject<ProduceSelectStrategyAutoExecModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceSelectStrategyAutoExecModel.FromPointer); // 0270D645FC28 0x30 SelectStrategyModel         ( 00018657F1A0 ModelClassType ProduceSelectStrategyAutoExecModel ProduceSelectStrategyAutoExecModel ProduceSelectStrategyAutoExecModel Pointer )
            value.SelectScheduleModel                       = GetObject<ProduceSelectScheduleAutoExecModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceSelectScheduleAutoExecModel.FromPointer); // 0270D645FC48 0x38 SelectScheduleModel         ( 00018657EAB0 ModelClassType ProduceSelectScheduleAutoExecModel ProduceSelectScheduleAutoExecModel ProduceSelectScheduleAutoExecModel Pointer )
            value.InGameModel                               = GetObject<ProduceInGameAutoExecModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceInGameAutoExecModel.FromPointer); // 0270D645FC68 0x40 InGameModel                 ( 000186556690 ModelClassType ProduceInGameAutoExecModel ProduceInGameAutoExecModel ProduceInGameAutoExecModel Pointer )
            value.ScenarioModel                             = GetObject<ProduceScenarioAutoExecModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceScenarioAutoExecModel.FromPointer); // 0270D645FC88 0x48 ScenarioModel               ( 00018657CDA0 ModelClassType ProduceScenarioAutoExecModel ProduceScenarioAutoExecModel ProduceScenarioAutoExecModel Pointer )
            value.ResumeModel                               = GetObject<ProduceResumeAutoExecModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceResumeAutoExecModel.FromPointer); // 0270D645FCA8 0x50 ResumeModel                 ( 000186579890 ModelClassType ProduceResumeAutoExecModel ProduceResumeAutoExecModel ProduceResumeAutoExecModel Pointer )

            return value;
        }
    }
}
