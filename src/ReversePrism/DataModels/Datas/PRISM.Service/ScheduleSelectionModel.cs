using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartLessonModel                    ModelClassType StartLessonModel StartLessonModel StartLessonModel Pointer
    // 018 CacheStartRestModel                      ModelClassType StartRestModel StartRestModel StartRestModel Pointer
    // 020 CacheStartTraningModel                   ModelClassType StartTraningModel StartTraningModel StartTraningModel Pointer
    // 028 CacheStartWorkingModel                   ModelClassType StartWorkingModel StartWorkingModel StartWorkingModel Pointer
    // 030 CacheStartOutingModel                    ModelClassType StartOutingModel StartOutingModel StartOutingModel Pointer
    // 038 CacheStartShoppingModel                  ModelClassType StartShoppingModel StartShoppingModel StartShoppingModel Pointer
    // 040 CacheStartAdviceModel                    ModelClassType StartAdviceModel StartAdviceModel StartAdviceModel Pointer
    // 048 CacheStartSpecialLessonModel             ModelClassType StartSpecialLessonModel StartSpecialLessonModel StartSpecialLessonModel Pointer
    // 050 CacheStartAuditionModel                  ModelClassType StartAuditionModel StartAuditionModel StartAuditionModel Pointer
    // 058 CacheStartSupportCooperationEventModel   ModelClassType StartSupportCooperationEventModel StartSupportCooperationEventModel StartSupportCooperationEventModel Pointer
    // 060 CacheStartMiniLiveModel                  ModelClassType StartMiniLiveModel StartMiniLiveModel StartMiniLiveModel Pointer
    // 068 CacheStartTalkShowModel                  ModelClassType StartTalkShowModel StartTalkShowModel StartTalkShowModel Pointer
    // 070 StartScriptReadingReply                  ModelClassType IStartScheduleScriptReadingReply IStartScheduleScriptReadingReply IStartScheduleScriptReadingReply Pointer
    // 078 StartCostumeFittingReply                 ModelClassType IStartScheduleCostumeFittingReply IStartScheduleCostumeFittingReply IStartScheduleCostumeFittingReply Pointer
    // 080 StartPublicRelationsReply                ModelClassType IStartSchedulePublicRelationsReply IStartSchedulePublicRelationsReply IStartSchedulePublicRelationsReply Pointer
    // 088 StartActingPracticeReply                 ModelClassType IStartScheduleActingPracticeReply IStartScheduleActingPracticeReply IStartScheduleActingPracticeReply Pointer
    // 090 CacheFinishTrainingModel                 ModelClassType FinishTrainingModel FinishTrainingModel FinishTrainingModel Pointer
    // 098 CacheFinishWorkingModel                  ModelClassType FinishWorkingModel FinishWorkingModel FinishWorkingModel Pointer
    // 0A0 CacheFinishOutingModel                   ModelClassType FinishOutingModel FinishOutingModel FinishOutingModel Pointer
    // 0A8 CacheFinishShoppingModel                 ModelClassType FinishShoppingModel FinishShoppingModel FinishShoppingModel Pointer
    // 0B0 CacheFinishRestModel                     ModelClassType FinishRestModel FinishRestModel FinishRestModel Pointer
    // 0B8 CacheFinishAdviceModel                   ModelClassType FinishAdviceModel FinishAdviceModel FinishAdviceModel Pointer
    // 0C0 CacheFinishSupportCooperationEventModel  ModelClassType FinishSupportCooperationEventModel FinishSupportCooperationEventModel FinishSupportCooperationEventModel Pointer
    // 0C8 CacheFinishMiniLiveModel                 ModelClassType FinishMiniLiveModel FinishMiniLiveModel FinishMiniLiveModel Pointer
    // 0D0 CacheFinishTalkShowModel                 ModelClassType FinishTalkShowModel FinishTalkShowModel FinishTalkShowModel Pointer
    // 0D8 FinishScriptReadingReply                 ModelClassType IFinishScheduleScriptReadingReply IFinishScheduleScriptReadingReply IFinishScheduleScriptReadingReply Pointer
    // 0E0 FinishCostumeFittingReply                ModelClassType IFinishScheduleCostumeFittingReply IFinishScheduleCostumeFittingReply IFinishScheduleCostumeFittingReply Pointer
    // 0E8 FinishPublicRelationsReply               ModelClassType IFinishSchedulePublicRelationsReply IFinishSchedulePublicRelationsReply IFinishSchedulePublicRelationsReply Pointer
    // 0F0 FinishActingPracticeReply                ModelClassType IFinishScheduleActingPracticeReply IFinishScheduleActingPracticeReply IFinishScheduleActingPracticeReply Pointer
    public partial class ScheduleSelectionModel : DataModel
    {
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
        public IStartScheduleScriptReadingReply?        StartScriptReadingReply                 { get; set; }
        public IStartScheduleCostumeFittingReply?       StartCostumeFittingReply                { get; set; }
        public IStartSchedulePublicRelationsReply?      StartPublicRelationsReply               { get; set; }
        public IStartScheduleActingPracticeReply?       StartActingPracticeReply                { get; set; }
        public FinishTrainingModel?                     CacheFinishTrainingModel                { get; set; }
        public FinishWorkingModel?                      CacheFinishWorkingModel                 { get; set; }
        public FinishOutingModel?                       CacheFinishOutingModel                  { get; set; }
        public FinishShoppingModel?                     CacheFinishShoppingModel                { get; set; }
        public FinishRestModel?                         CacheFinishRestModel                    { get; set; }
        public FinishAdviceModel?                       CacheFinishAdviceModel                  { get; set; }
        public FinishSupportCooperationEventModel?      CacheFinishSupportCooperationEventModel { get; set; }
        public FinishMiniLiveModel?                     CacheFinishMiniLiveModel                { get; set; }
        public FinishTalkShowModel?                     CacheFinishTalkShowModel                { get; set; }
        public IFinishScheduleScriptReadingReply?       FinishScriptReadingReply                { get; set; }
        public IFinishScheduleCostumeFittingReply?      FinishCostumeFittingReply               { get; set; }
        public IFinishSchedulePublicRelationsReply?     FinishPublicRelationsReply              { get; set; }
        public IFinishScheduleActingPracticeReply?      FinishActingPracticeReply               { get; set; }

        public static ScheduleSelectionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionModel() { Pointer= p0 };

            value.CacheStartLessonModel                     = GetObject<StartLessonModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StartLessonModel.FromPointer); // 0x10 CacheStartLessonModel       ( ModelClassType StartLessonModel StartLessonModel StartLessonModel Pointer )
            value.CacheStartRestModel                       = GetObject<StartRestModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StartRestModel.FromPointer); // 0x18 CacheStartRestModel         ( ModelClassType StartRestModel StartRestModel StartRestModel Pointer )
            value.CacheStartTraningModel                    = GetObject<StartTraningModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StartTraningModel.FromPointer); // 0x20 CacheStartTraningModel      ( ModelClassType StartTraningModel StartTraningModel StartTraningModel Pointer )
            value.CacheStartWorkingModel                    = GetObject<StartWorkingModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.StartWorkingModel.FromPointer); // 0x28 CacheStartWorkingModel      ( ModelClassType StartWorkingModel StartWorkingModel StartWorkingModel Pointer )
            value.CacheStartOutingModel                     = GetObject<StartOutingModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StartOutingModel.FromPointer); // 0x30 CacheStartOutingModel       ( ModelClassType StartOutingModel StartOutingModel StartOutingModel Pointer )
            value.CacheStartShoppingModel                   = GetObject<StartShoppingModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StartShoppingModel.FromPointer); // 0x38 CacheStartShoppingModel     ( ModelClassType StartShoppingModel StartShoppingModel StartShoppingModel Pointer )
            value.CacheStartAdviceModel                     = GetObject<StartAdviceModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.StartAdviceModel.FromPointer); // 0x40 CacheStartAdviceModel       ( ModelClassType StartAdviceModel StartAdviceModel StartAdviceModel Pointer )
            value.CacheStartSpecialLessonModel              = GetObject<StartSpecialLessonModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StartSpecialLessonModel.FromPointer); // 0x48 CacheStartSpecialLessonModel ( ModelClassType StartSpecialLessonModel StartSpecialLessonModel StartSpecialLessonModel Pointer )
            value.CacheStartAuditionModel                   = GetObject<StartAuditionModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.StartAuditionModel.FromPointer); // 0x50 CacheStartAuditionModel     ( ModelClassType StartAuditionModel StartAuditionModel StartAuditionModel Pointer )
            value.CacheStartSupportCooperationEventModel    = GetObject<StartSupportCooperationEventModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.StartSupportCooperationEventModel.FromPointer); // 0x58 CacheStartSupportCooperationEventModel ( ModelClassType StartSupportCooperationEventModel StartSupportCooperationEventModel StartSupportCooperationEventModel Pointer )
            value.CacheStartMiniLiveModel                   = GetObject<StartMiniLiveModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.StartMiniLiveModel.FromPointer); // 0x60 CacheStartMiniLiveModel     ( ModelClassType StartMiniLiveModel StartMiniLiveModel StartMiniLiveModel Pointer )
            value.CacheStartTalkShowModel                   = GetObject<StartTalkShowModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.StartTalkShowModel.FromPointer); // 0x68 CacheStartTalkShowModel     ( ModelClassType StartTalkShowModel StartTalkShowModel StartTalkShowModel Pointer )
            value.StartScriptReadingReply                   = GetObject<IStartScheduleScriptReadingReply>(new IntPtr(p + 0x070), ReversePrism.DataModels.IStartScheduleScriptReadingReply.FromPointer); // 0x70 StartScriptReadingReply     ( ModelClassType IStartScheduleScriptReadingReply IStartScheduleScriptReadingReply IStartScheduleScriptReadingReply Pointer )
            value.StartCostumeFittingReply                  = GetObject<IStartScheduleCostumeFittingReply>(new IntPtr(p + 0x078), ReversePrism.DataModels.IStartScheduleCostumeFittingReply.FromPointer); // 0x78 StartCostumeFittingReply    ( ModelClassType IStartScheduleCostumeFittingReply IStartScheduleCostumeFittingReply IStartScheduleCostumeFittingReply Pointer )
            value.StartPublicRelationsReply                 = GetObject<IStartSchedulePublicRelationsReply>(new IntPtr(p + 0x080), ReversePrism.DataModels.IStartSchedulePublicRelationsReply.FromPointer); // 0x80 StartPublicRelationsReply   ( ModelClassType IStartSchedulePublicRelationsReply IStartSchedulePublicRelationsReply IStartSchedulePublicRelationsReply Pointer )
            value.StartActingPracticeReply                  = GetObject<IStartScheduleActingPracticeReply>(new IntPtr(p + 0x088), ReversePrism.DataModels.IStartScheduleActingPracticeReply.FromPointer); // 0x88 StartActingPracticeReply    ( ModelClassType IStartScheduleActingPracticeReply IStartScheduleActingPracticeReply IStartScheduleActingPracticeReply Pointer )
            value.CacheFinishTrainingModel                  = GetObject<FinishTrainingModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.FinishTrainingModel.FromPointer); // 0x90 CacheFinishTrainingModel    ( ModelClassType FinishTrainingModel FinishTrainingModel FinishTrainingModel Pointer )
            value.CacheFinishWorkingModel                   = GetObject<FinishWorkingModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.FinishWorkingModel.FromPointer); // 0x98 CacheFinishWorkingModel     ( ModelClassType FinishWorkingModel FinishWorkingModel FinishWorkingModel Pointer )
            value.CacheFinishOutingModel                    = GetObject<FinishOutingModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FinishOutingModel.FromPointer); // 0xA0 CacheFinishOutingModel      ( ModelClassType FinishOutingModel FinishOutingModel FinishOutingModel Pointer )
            value.CacheFinishShoppingModel                  = GetObject<FinishShoppingModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FinishShoppingModel.FromPointer); // 0xA8 CacheFinishShoppingModel    ( ModelClassType FinishShoppingModel FinishShoppingModel FinishShoppingModel Pointer )
            value.CacheFinishRestModel                      = GetObject<FinishRestModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.FinishRestModel.FromPointer); // 0xB0 CacheFinishRestModel        ( ModelClassType FinishRestModel FinishRestModel FinishRestModel Pointer )
            value.CacheFinishAdviceModel                    = GetObject<FinishAdviceModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.FinishAdviceModel.FromPointer); // 0xB8 CacheFinishAdviceModel      ( ModelClassType FinishAdviceModel FinishAdviceModel FinishAdviceModel Pointer )
            value.CacheFinishSupportCooperationEventModel   = GetObject<FinishSupportCooperationEventModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.FinishSupportCooperationEventModel.FromPointer); // 0xC0 CacheFinishSupportCooperationEventModel ( ModelClassType FinishSupportCooperationEventModel FinishSupportCooperationEventModel FinishSupportCooperationEventModel Pointer )
            value.CacheFinishMiniLiveModel                  = GetObject<FinishMiniLiveModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.FinishMiniLiveModel.FromPointer); // 0xC8 CacheFinishMiniLiveModel    ( ModelClassType FinishMiniLiveModel FinishMiniLiveModel FinishMiniLiveModel Pointer )
            value.CacheFinishTalkShowModel                  = GetObject<FinishTalkShowModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.FinishTalkShowModel.FromPointer); // 0xD0 CacheFinishTalkShowModel    ( ModelClassType FinishTalkShowModel FinishTalkShowModel FinishTalkShowModel Pointer )
            value.FinishScriptReadingReply                  = GetObject<IFinishScheduleScriptReadingReply>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IFinishScheduleScriptReadingReply.FromPointer); // 0xD8 FinishScriptReadingReply    ( ModelClassType IFinishScheduleScriptReadingReply IFinishScheduleScriptReadingReply IFinishScheduleScriptReadingReply Pointer )
            value.FinishCostumeFittingReply                 = GetObject<IFinishScheduleCostumeFittingReply>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IFinishScheduleCostumeFittingReply.FromPointer); // 0xE0 FinishCostumeFittingReply   ( ModelClassType IFinishScheduleCostumeFittingReply IFinishScheduleCostumeFittingReply IFinishScheduleCostumeFittingReply Pointer )
            value.FinishPublicRelationsReply                = GetObject<IFinishSchedulePublicRelationsReply>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IFinishSchedulePublicRelationsReply.FromPointer); // 0xE8 FinishPublicRelationsReply  ( ModelClassType IFinishSchedulePublicRelationsReply IFinishSchedulePublicRelationsReply IFinishSchedulePublicRelationsReply Pointer )
            value.FinishActingPracticeReply                 = GetObject<IFinishScheduleActingPracticeReply>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IFinishScheduleActingPracticeReply.FromPointer); // 0xF0 FinishActingPracticeReply   ( ModelClassType IFinishScheduleActingPracticeReply IFinishScheduleActingPracticeReply IFinishScheduleActingPracticeReply Pointer )

            return value;
        }
    }
}
