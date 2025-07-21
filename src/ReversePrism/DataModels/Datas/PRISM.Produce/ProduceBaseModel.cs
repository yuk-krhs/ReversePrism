using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnResetBGM                               ModelClassType Action Action Action Pointer
    // 018 IsOverTimeMV                             Func`2<float, bool> IL2CPP_TYPE_GENERICINST
    // 020 InitializeCts                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 LessonStatus                             ModelEnumType LessonStatus LessonStatus LessonStatus Int32
    // 02C ResultStatus                             ModelEnumType ResultStatus ResultStatus ResultStatus Int32
    // 030 ExecuteSkillCardIndex                    ModelPrimitiveType int int int Int32
    // 034 ElapsedTimeSecond                        ModelPrimitiveType float float float Single
    // 038 CurrentPlayerPPRecoveryTime              ModelPrimitiveType float float float Single
    // 03C ExecuteSkillIndex                        ModelPrimitiveType int int int Int32
    // 040 StopFlag                                 ModelPrimitiveType int int int Int32
    // 048 RandomModel                              ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 050 SkillActionModel                         ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer
    // 058 PlayerModel                              ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 060 EnemyModel                               ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 068 AiModel                                  ModelClassType AiModel AiModel AiModel Pointer
    // 070 EnemyAiModel                             ModelClassType AiModel AiModel AiModel Pointer
    // 078 AiExternalAccess                         ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 080 EnemyAiExternalAccess                    ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 088 IsExecuteTrainerSkill                    ModelPrimitiveType bool bool bool Bool
    // 08C EnemySkillTimeCount                      ModelPrimitiveType int int int Int32
    // 090 IsAttackAction                           ModelPrimitiveType bool bool bool Bool
    // 098 SelectCardCache                          ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    // 0A0 IsAttackReady                            ModelEnumType AttackReadyState AttackReadyState AttackReadyState Int32
    // 0A4 IsDisableInput                           ModelPrimitiveType bool bool bool Bool
    // 0A5 IsDisableInputDrag                       ModelPrimitiveType bool bool bool Bool
    // 0A8 onExecuteIdolSkillSubject                Subject`1<ValueTuple`3<int, IngameSkillModel, CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 0B0 onExecuteTrainerSkillSubject             Subject`1<ValueTuple`3<int, IngameSkillModel, CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 0B8 onPreExecutePlayerPCardSubject           Subject`1<IngamePCardModel> IL2CPP_TYPE_GENERICINST
    // 0C0 onExecutePlayerPCardSubject              Subject`1<ValueTuple`2<IngamePCardModel, CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 0C8 onExecuteEnemyPCardSubject               Subject`1<IngamePCardModel> IL2CPP_TYPE_GENERICINST
    // 0D0 cardAndSkillExecResultPool               InGameActionResultPool`1<CardAndSkillExecResult> IL2CPP_TYPE_GENERICINST
    // 0D8 onGameEndSubject                         Subject`1<GameEndStatus> IL2CPP_TYPE_GENERICINST
    // 0E0 onSetStopSubject                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0E8 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0F0 IsFastForwardEnable                      ModelPrimitiveType bool bool bool Bool
    // 0F4 FastForwardSpeedType                     ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32
    // 0F8 onUpdateFastForwardSpeedEnable           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 100 onUpdateFastForwardSpeed                 Subject`1<FastForwardSpeedType> IL2CPP_TYPE_GENERICINST
    // 108 onUpdateLeftTime                         Subject`1<ValueTuple`2<float, float>> IL2CPP_TYPE_GENERICINST
    // 110 onSetLeftTime                            Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 118 onPostPlayerAndAIUpdate                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 120 onPreModelUpdate                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 128 BgmModel                                 ModelClassType IngameBgmModel IngameBgmModel IngameBgmModel Pointer
    // 130 TallyModel                               ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    // 138 CurrentSelectCardIndex                   ModelPrimitiveType int int int Int32
    // 140 EnemyAiNotUseCardList                    ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 148 IsAutoMode                               ModelPrimitiveType bool bool bool Bool
    // 149 IsReady                                  ModelPrimitiveType bool bool bool Bool
    // 14A IsDisableNPC                             ModelPrimitiveType bool bool bool Bool
    // 14B IsLoopBGM                                ModelPrimitiveType bool bool bool Bool
    // 150 PredictionModel                          ModelClassType CardAndSkillPredictionModel CardAndSkillPredictionModel CardAndSkillPredictionModel Pointer
    public partial class ProduceBaseModel : DataModel
    {
        public Action?                                  OnResetBGM                              { get; set; }
        public CancellationTokenSource?                 InitializeCts                           { get; set; }
        public LessonStatus                             LessonStatus                            { get; set; }
        public ResultStatus                             ResultStatus                            { get; set; }
        public int                                      ExecuteSkillCardIndex                   { get; set; }
        public float                                    ElapsedTimeSecond                       { get; set; }
        public float                                    CurrentPlayerPPRecoveryTime             { get; set; }
        public int                                      ExecuteSkillIndex                       { get; set; }
        public int                                      StopFlag                                { get; set; }
        public IngameRandomModel?                       RandomModel                             { get; set; }
        public IngameSkillActionModel?                  SkillActionModel                        { get; set; }
        public IngamePlayerModel?                       PlayerModel                             { get; set; }
        public IngamePlayerModel?                       EnemyModel                              { get; set; }
        public AiModel?                                 AiModel                                 { get; set; }
        public AiModel?                                 EnemyAiModel                            { get; set; }
        public AiExternalAccess?                        AiExternalAccess                        { get; set; }
        public AiExternalAccess?                        EnemyAiExternalAccess                   { get; set; }
        public bool                                     IsExecuteTrainerSkill                   { get; set; }
        public int                                      EnemySkillTimeCount                     { get; set; }
        public bool                                     IsAttackAction                          { get; set; }
        public IngamePCardModel?                        SelectCardCache                         { get; set; }
        public AttackReadyState                         IsAttackReady                           { get; set; }
        public bool                                     IsDisableInput                          { get; set; }
        public bool                                     IsDisableInputDrag                      { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsFastForwardEnable                     { get; set; }
        public FastForwardSpeedType                     FastForwardSpeedType                    { get; set; }
        public IngameBgmModel?                          BgmModel                                { get; set; }
        public IngameTallyModel?                        TallyModel                              { get; set; }
        public int                                      CurrentSelectCardIndex                  { get; set; }
        public List<IngamePCardModel>?                  EnemyAiNotUseCardList                   { get; set; }
        public bool                                     IsAutoMode                              { get; set; }
        public bool                                     IsReady                                 { get; set; }
        public bool                                     IsDisableNPC                            { get; set; }
        public bool                                     IsLoopBGM                               { get; set; }
        public CardAndSkillPredictionModel?             PredictionModel                         { get; set; }

        public static ProduceBaseModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceBaseModel() { Pointer= p0 };

            value.OnResetBGM                                = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 OnResetBGM                  ( ModelClassType Action Action Action Pointer )
            value.InitializeCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 InitializeCts               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LessonStatus                              = (LessonStatus)GetInt32(new IntPtr(p + 0x028)); // 0x28 LessonStatus                ( ModelEnumType LessonStatus LessonStatus LessonStatus Int32 )
            value.ResultStatus                              = (ResultStatus)GetInt32(new IntPtr(p + 0x02C)); // 0x2C ResultStatus                ( ModelEnumType ResultStatus ResultStatus ResultStatus Int32 )
            value.ExecuteSkillCardIndex                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 ExecuteSkillCardIndex       ( ModelPrimitiveType int int int Int32 )
            value.ElapsedTimeSecond                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 ElapsedTimeSecond           ( ModelPrimitiveType float float float Single )
            value.CurrentPlayerPPRecoveryTime               = GetSingle(new IntPtr(p + 0x038)); // 0x38 CurrentPlayerPPRecoveryTime ( ModelPrimitiveType float float float Single )
            value.ExecuteSkillIndex                         = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ExecuteSkillIndex           ( ModelPrimitiveType int int int Int32 )
            value.StopFlag                                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 StopFlag                    ( ModelPrimitiveType int int int Int32 )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 0x48 RandomModel                 ( ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.SkillActionModel                          = GetObject<IngameSkillActionModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IngameSkillActionModel.FromPointer); // 0x50 SkillActionModel            ( ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer )
            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x58 PlayerModel                 ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.EnemyModel                                = GetObject<IngamePlayerModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x60 EnemyModel                  ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.AiModel                                   = GetObject<AiModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.AiModel.FromPointer); // 0x68 AiModel                     ( ModelClassType AiModel AiModel AiModel Pointer )
            value.EnemyAiModel                              = GetObject<AiModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.AiModel.FromPointer); // 0x70 EnemyAiModel                ( ModelClassType AiModel AiModel AiModel Pointer )
            value.AiExternalAccess                          = GetObject<AiExternalAccess>(new IntPtr(p + 0x078), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 0x78 AiExternalAccess            ( ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.EnemyAiExternalAccess                     = GetObject<AiExternalAccess>(new IntPtr(p + 0x080), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 0x80 EnemyAiExternalAccess       ( ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.IsExecuteTrainerSkill                     = GetBool(new IntPtr(p + 0x088)); // 0x88 IsExecuteTrainerSkill       ( ModelPrimitiveType bool bool bool Bool )
            value.EnemySkillTimeCount                       = GetInt32(new IntPtr(p + 0x08C)); // 0x8C EnemySkillTimeCount         ( ModelPrimitiveType int int int Int32 )
            value.IsAttackAction                            = GetBool(new IntPtr(p + 0x090)); // 0x90 IsAttackAction              ( ModelPrimitiveType bool bool bool Bool )
            value.SelectCardCache                           = GetObject<IngamePCardModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x98 SelectCardCache             ( ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )
            value.IsAttackReady                             = (AttackReadyState)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 IsAttackReady               ( ModelEnumType AttackReadyState AttackReadyState AttackReadyState Int32 )
            value.IsDisableInput                            = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 IsDisableInput              ( ModelPrimitiveType bool bool bool Bool )
            value.IsDisableInputDrag                        = GetBool(new IntPtr(p + 0x0A5)); // 0xA5 IsDisableInputDrag          ( ModelPrimitiveType bool bool bool Bool )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xE8 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsFastForwardEnable                       = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsFastForwardEnable         ( ModelPrimitiveType bool bool bool Bool )
            value.FastForwardSpeedType                      = (FastForwardSpeedType)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 FastForwardSpeedType        ( ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32 )
            value.BgmModel                                  = GetObject<IngameBgmModel>(new IntPtr(p + 0x128), ReversePrism.DataModels.IngameBgmModel.FromPointer); // 0x128 BgmModel                    ( ModelClassType IngameBgmModel IngameBgmModel IngameBgmModel Pointer )
            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x130), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 0x130 TallyModel                  ( ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )
            value.CurrentSelectCardIndex                    = GetInt32(new IntPtr(p + 0x138)); // 0x138 CurrentSelectCardIndex      ( ModelPrimitiveType int int int Int32 )
            value.EnemyAiNotUseCardList                     = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x140), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x140 EnemyAiNotUseCardList       ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.IsAutoMode                                = GetBool(new IntPtr(p + 0x148)); // 0x148 IsAutoMode                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x149)); // 0x149 IsReady                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsDisableNPC                              = GetBool(new IntPtr(p + 0x14A)); // 0x14A IsDisableNPC                ( ModelPrimitiveType bool bool bool Bool )
            value.IsLoopBGM                                 = GetBool(new IntPtr(p + 0x14B)); // 0x14B IsLoopBGM                   ( ModelPrimitiveType bool bool bool Bool )
            value.PredictionModel                           = GetObject<CardAndSkillPredictionModel>(new IntPtr(p + 0x150), ReversePrism.DataModels.CardAndSkillPredictionModel.FromPointer); // 0x150 PredictionModel             ( ModelClassType CardAndSkillPredictionModel CardAndSkillPredictionModel CardAndSkillPredictionModel Pointer )

            return value;
        }
    }
}
