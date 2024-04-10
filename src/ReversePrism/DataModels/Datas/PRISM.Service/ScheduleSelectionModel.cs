using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceNextOrder                    0001865EE670 ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer
    // 018 CacheStartLessonModel                    0001865718D0 ModelClassType StartLessonModel StartLessonModel StartLessonModel Pointer
    // 020 CacheStartRestModel                      000186576EA0 ModelClassType StartRestModel StartRestModel StartRestModel Pointer
    // 028 CacheStartTraningModel                   00018657F6B0 ModelClassType StartTraningModel StartTraningModel StartTraningModel Pointer
    // 030 CacheStartWorkingModel                   000186580C90 ModelClassType StartWorkingModel StartWorkingModel StartWorkingModel Pointer
    // 038 CacheStartOutingModel                    000186574140 ModelClassType StartOutingModel StartOutingModel StartOutingModel Pointer
    // 040 CacheStartShoppingModel                  00018657C3B0 ModelClassType StartShoppingModel StartShoppingModel StartShoppingModel Pointer
    // 048 CacheStartAdviceModel                    00018656F070 ModelClassType StartAdviceModel StartAdviceModel StartAdviceModel Pointer
    // 050 CacheStartSpecialLessonModel             00018657CDB0 ModelClassType StartSpecialLessonModel StartSpecialLessonModel StartSpecialLessonModel Pointer
    // 058 CacheStartAuditionModel                  00018656FA70 ModelClassType StartAuditionModel StartAuditionModel StartAuditionModel Pointer
    // 060 CacheStartSupportCooperationEventModel   00018657E600 ModelClassType StartSupportCooperationEventModel StartSupportCooperationEventModel StartSupportCooperationEventModel Pointer
    // 068 CacheStartMiniLiveModel                  0001865739E0 ModelClassType StartMiniLiveModel StartMiniLiveModel StartMiniLiveModel Pointer
    // 070 CacheStartTalkShowModel                  00018657F1B0 ModelClassType StartTalkShowModel StartTalkShowModel StartTalkShowModel Pointer
    // 078 CacheFinishTrainingModel                 000186593210 ModelClassType FinishTrainingModel FinishTrainingModel FinishTrainingModel Pointer
    // 080 CacheFinishWorkingModel                  000186594320 ModelClassType FinishWorkingModel FinishWorkingModel FinishWorkingModel Pointer
    // 088 CacheFinishOutingModel                   000186588430 ModelClassType FinishOutingModel FinishOutingModel FinishOutingModel Pointer
    // 090 CacheFinishShoppingModel                 000186590370 ModelClassType FinishShoppingModel FinishShoppingModel FinishShoppingModel Pointer
    // 098 CacheFinishRestModel                     00018658AAF0 ModelClassType FinishRestModel FinishRestModel FinishRestModel Pointer
    // 0A0 CacheFinishAdviceModel                   000186582A80 ModelClassType FinishAdviceModel FinishAdviceModel FinishAdviceModel Pointer
    // 0A8 CacheFinishSupportCooperationEventModel  000186592330 ModelClassType FinishSupportCooperationEventModel FinishSupportCooperationEventModel FinishSupportCooperationEventModel Pointer
    // 0B0 CacheFinishMiniLiveModel                 000186587EF0 ModelClassType FinishMiniLiveModel FinishMiniLiveModel FinishMiniLiveModel Pointer
    // 0B8 CacheFinishTalkShowModel                 000186592D10 ModelClassType FinishTalkShowModel FinishTalkShowModel FinishTalkShowModel Pointer
    public partial class ScheduleSelectionModel : DataModel
    {
        public IProduceNextOrderStatus?                 CacheProduceNextOrder                   { get; set; }
        public StartLessonModel?                        CacheStartLessonModel                   { get; set; }
        public StartRestModel?                          CacheStartRestModel                     { get; set; }
        public StartTraningModel?                       CacheStartTraningModel                  { get; set; }
        public StartWorkingModel?                       CacheStartWorkingModel                  { get; set; }
        public StartOutingModel?                        CacheStartOutingModel                   { get; set; }
        public StartShoppingModel?                      CacheStartShoppingModel                 { get; set; }
        public StartAdviceModel?                        CacheStartAdviceModel                   { get; set; }
        public StartSpecialLessonModel?                 CacheStartSpecialLessonModel            { get; set; }
        public StartAuditionModel?                      CacheStartAuditionModel                 { get; set; }
        public StartSupportCooperationEventModel?       CacheStartSupportCooperationEventModel  { get; set; }
        public StartMiniLiveModel?                      CacheStartMiniLiveModel                 { get; set; }
        public StartTalkShowModel?                      CacheStartTalkShowModel                 { get; set; }
        public FinishTrainingModel?                     CacheFinishTrainingModel                { get; set; }
        public FinishWorkingModel?                      CacheFinishWorkingModel                 { get; set; }
        public FinishOutingModel?                       CacheFinishOutingModel                  { get; set; }
        public FinishShoppingModel?                     CacheFinishShoppingModel                { get; set; }
        public FinishRestModel?                         CacheFinishRestModel                    { get; set; }
        public FinishAdviceModel?                       CacheFinishAdviceModel                  { get; set; }
        public FinishSupportCooperationEventModel?      CacheFinishSupportCooperationEventModel { get; set; }
        public FinishMiniLiveModel?                     CacheFinishMiniLiveModel                { get; set; }
        public FinishTalkShowModel?                     CacheFinishTalkShowModel                { get; set; }

        public static ScheduleSelectionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionModel() { Pointer= p0 };

            value.CacheProduceNextOrder                     = GetObject<IProduceNextOrderStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceNextOrderStatus.FromPointer); // 0246666995C0 0x10 CacheProduceNextOrder       ( 0001865EE670 ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer )
            value.CacheStartLessonModel                     = GetObject<StartLessonModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StartLessonModel.FromPointer); // 0246666995E0 0x18 CacheStartLessonModel       ( 0001865718D0 ModelClassType StartLessonModel StartLessonModel StartLessonModel Pointer )
            value.CacheStartRestModel                       = GetObject<StartRestModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StartRestModel.FromPointer); // 024666699600 0x20 CacheStartRestModel         ( 000186576EA0 ModelClassType StartRestModel StartRestModel StartRestModel Pointer )
            value.CacheStartTraningModel                    = GetObject<StartTraningModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.StartTraningModel.FromPointer); // 024666699620 0x28 CacheStartTraningModel      ( 00018657F6B0 ModelClassType StartTraningModel StartTraningModel StartTraningModel Pointer )
            value.CacheStartWorkingModel                    = GetObject<StartWorkingModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StartWorkingModel.FromPointer); // 024666699640 0x30 CacheStartWorkingModel      ( 000186580C90 ModelClassType StartWorkingModel StartWorkingModel StartWorkingModel Pointer )
            value.CacheStartOutingModel                     = GetObject<StartOutingModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StartOutingModel.FromPointer); // 024666699660 0x38 CacheStartOutingModel       ( 000186574140 ModelClassType StartOutingModel StartOutingModel StartOutingModel Pointer )
            value.CacheStartShoppingModel                   = GetObject<StartShoppingModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.StartShoppingModel.FromPointer); // 024666699680 0x40 CacheStartShoppingModel     ( 00018657C3B0 ModelClassType StartShoppingModel StartShoppingModel StartShoppingModel Pointer )
            value.CacheStartAdviceModel                     = GetObject<StartAdviceModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StartAdviceModel.FromPointer); // 0246666996A0 0x48 CacheStartAdviceModel       ( 00018656F070 ModelClassType StartAdviceModel StartAdviceModel StartAdviceModel Pointer )
            value.CacheStartSpecialLessonModel              = GetObject<StartSpecialLessonModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.StartSpecialLessonModel.FromPointer); // 0246666996C0 0x50 CacheStartSpecialLessonModel ( 00018657CDB0 ModelClassType StartSpecialLessonModel StartSpecialLessonModel StartSpecialLessonModel Pointer )
            value.CacheStartAuditionModel                   = GetObject<StartAuditionModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.StartAuditionModel.FromPointer); // 0246666996E0 0x58 CacheStartAuditionModel     ( 00018656FA70 ModelClassType StartAuditionModel StartAuditionModel StartAuditionModel Pointer )
            value.CacheStartSupportCooperationEventModel    = GetObject<StartSupportCooperationEventModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.StartSupportCooperationEventModel.FromPointer); // 024666699700 0x60 CacheStartSupportCooperationEventModel ( 00018657E600 ModelClassType StartSupportCooperationEventModel StartSupportCooperationEventModel StartSupportCooperationEventModel Pointer )
            value.CacheStartMiniLiveModel                   = GetObject<StartMiniLiveModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.StartMiniLiveModel.FromPointer); // 024666699720 0x68 CacheStartMiniLiveModel     ( 0001865739E0 ModelClassType StartMiniLiveModel StartMiniLiveModel StartMiniLiveModel Pointer )
            value.CacheStartTalkShowModel                   = GetObject<StartTalkShowModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.StartTalkShowModel.FromPointer); // 024666699740 0x70 CacheStartTalkShowModel     ( 00018657F1B0 ModelClassType StartTalkShowModel StartTalkShowModel StartTalkShowModel Pointer )
            value.CacheFinishTrainingModel                  = GetObject<FinishTrainingModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.FinishTrainingModel.FromPointer); // 024666699760 0x78 CacheFinishTrainingModel    ( 000186593210 ModelClassType FinishTrainingModel FinishTrainingModel FinishTrainingModel Pointer )
            value.CacheFinishWorkingModel                   = GetObject<FinishWorkingModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.FinishWorkingModel.FromPointer); // 024666699780 0x80 CacheFinishWorkingModel     ( 000186594320 ModelClassType FinishWorkingModel FinishWorkingModel FinishWorkingModel Pointer )
            value.CacheFinishOutingModel                    = GetObject<FinishOutingModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.FinishOutingModel.FromPointer); // 0246666997A0 0x88 CacheFinishOutingModel      ( 000186588430 ModelClassType FinishOutingModel FinishOutingModel FinishOutingModel Pointer )
            value.CacheFinishShoppingModel                  = GetObject<FinishShoppingModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.FinishShoppingModel.FromPointer); // 0246666997C0 0x90 CacheFinishShoppingModel    ( 000186590370 ModelClassType FinishShoppingModel FinishShoppingModel FinishShoppingModel Pointer )
            value.CacheFinishRestModel                      = GetObject<FinishRestModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.FinishRestModel.FromPointer); // 0246666997E0 0x98 CacheFinishRestModel        ( 00018658AAF0 ModelClassType FinishRestModel FinishRestModel FinishRestModel Pointer )
            value.CacheFinishAdviceModel                    = GetObject<FinishAdviceModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FinishAdviceModel.FromPointer); // 024666699800 0xA0 CacheFinishAdviceModel      ( 000186582A80 ModelClassType FinishAdviceModel FinishAdviceModel FinishAdviceModel Pointer )
            value.CacheFinishSupportCooperationEventModel   = GetObject<FinishSupportCooperationEventModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FinishSupportCooperationEventModel.FromPointer); // 024666699820 0xA8 CacheFinishSupportCooperationEventModel ( 000186592330 ModelClassType FinishSupportCooperationEventModel FinishSupportCooperationEventModel FinishSupportCooperationEventModel Pointer )
            value.CacheFinishMiniLiveModel                  = GetObject<FinishMiniLiveModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.FinishMiniLiveModel.FromPointer); // 024666699840 0xB0 CacheFinishMiniLiveModel    ( 000186587EF0 ModelClassType FinishMiniLiveModel FinishMiniLiveModel FinishMiniLiveModel Pointer )
            value.CacheFinishTalkShowModel                  = GetObject<FinishTalkShowModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.FinishTalkShowModel.FromPointer); // 024666699860 0xB8 CacheFinishTalkShowModel    ( 000186592D10 ModelClassType FinishTalkShowModel FinishTalkShowModel FinishTalkShowModel Pointer )

            return value;
        }
    }
}
