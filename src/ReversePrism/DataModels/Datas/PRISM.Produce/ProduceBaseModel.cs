using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnResetBGM                               000186679A00 ModelClassType Action Action Action Pointer
    // 018 OnGetCurrentTimeLimit                    Action`1<float> IL2CPP_TYPE_GENERICINST
    // 020 OnUpdateProduceCardUsable                000186679A00 ModelClassType Action Action Action Pointer
    // 028 OnUpdateBuffDebuffIcon                   000186679A00 ModelClassType Action Action Action Pointer
    // 030 OnUpdatePrediction                       000186679A00 ModelClassType Action Action Action Pointer
    // 038 IsOverTimeMV                             Func`2<float, bool> IL2CPP_TYPE_GENERICINST
    // 040 InitializeCts                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 LessonStatus                             000186602CA0 ModelEnumType LessonStatus LessonStatus LessonStatus Int32
    // 04C ResultStatus                             0001866F4E10 ModelEnumType ResultStatus ResultStatus ResultStatus Int32
    // 050 ExecuteSkillCardIndex                    0001865F3220 ModelPrimitiveType int int int Int32
    // 054 ElapsedTimeSecond                        0001866656B0 ModelPrimitiveType float float float Single
    // 058 CurrentPlayerPPRecoveryTime              000186665B50 ModelPrimitiveType float float float Single
    // 05C ExecuteSkillIndex                        0001865F3220 ModelPrimitiveType int int int Int32
    // 060 StopFlag                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 RandomModel                              0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 070 SkillActionModel                         0001866E7070 ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer
    // 078 PlayerModel                              0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 080 EnemyModel                               0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 088 AiModel                                  00018669CF10 ModelClassType AiModel AiModel AiModel Pointer
    // 090 EnemyAiModel                             00018669D1C0 ModelClassType AiModel AiModel AiModel Pointer
    // 098 AiExternalAccess                         00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 0A0 EnemyAiExternalAccess                    00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 0A8 IsExecuteTrainerSkill                    000186595480 ModelPrimitiveType bool bool bool Bool
    // 0AC EnemySkillTimeCount                      0001865F3220 ModelPrimitiveType int int int Int32
    // 0B0 IsAttackAction                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B8 SelectCardCache                          0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    // 0C0 IsAttackReady                            000186600450 ModelEnumType AttackReadyState AttackReadyState AttackReadyState Int32
    // 0C4 IsDisableInput                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C5 IsDisableInputDrag                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 onExecuteIdolSkillSubject                Subject`1<ValueTuple`3<int, IngameSkillModel, CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 0D0 onExecuteTrainerSkillSubject             Subject`1<ValueTuple`3<int, IngameSkillModel, CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 0D8 onPreExecutePlayerPCardSubject           Subject`1<IngamePCardModel> IL2CPP_TYPE_GENERICINST
    // 0E0 onExecutePlayerPCardSubject              Subject`1<ValueTuple`2<IngamePCardModel, CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    // 0E8 onExecuteEnemyPCardSubject               Subject`1<IngamePCardModel> IL2CPP_TYPE_GENERICINST
    // 0F0 cardAndSkillExecResultPool               InGameActionResultPool`1<CardAndSkillExecResult> IL2CPP_TYPE_GENERICINST
    // 0F8 onGameEndSubject                         Subject`1<GameEndStatus> IL2CPP_TYPE_GENERICINST
    // 100 onSetStopSubject                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 108 Disposables                              0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 110 IsFastForwardEnable                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 114 FastForwardSpeedType                     000186601990 ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32
    // 118 onUpdateFastForwardSpeedEnable           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 120 onUpdateFastForwardSpeed                 Subject`1<FastForwardSpeedType> IL2CPP_TYPE_GENERICINST
    // 128 onUpdateLeftTime                         Subject`1<ValueTuple`2<float, float>> IL2CPP_TYPE_GENERICINST
    // 130 onSetLeftTime                            Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 138 BgmModel                                 0001866E2C50 ModelClassType IngameBgmModel IngameBgmModel IngameBgmModel Pointer
    // 140 TallyModel                               0001866E8E10 ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    // 148 CurrentSelectCardIndex                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 150 EnemyAiNotUseCardList                    000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 158 IsAutoMode                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 159 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 15A IsDisableNPC                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 15B IsLoopBGM                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 160 PredictionModel                          000186545AA0 ModelClassType CardAndSkillPredictionModel CardAndSkillPredictionModel CardAndSkillPredictionModel Pointer
    public partial class ProduceBaseModel : DataModel
    {
        public Action?                                  OnResetBGM                              { get; set; }
        public Action?                                  OnUpdateProduceCardUsable               { get; set; }
        public Action?                                  OnUpdateBuffDebuffIcon                  { get; set; }
        public Action?                                  OnUpdatePrediction                      { get; set; }
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

            value.OnResetBGM                                = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 024664D4D658 0x10 OnResetBGM                  ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnUpdateProduceCardUsable                 = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 024664D4D698 0x20 OnUpdateProduceCardUsable   ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnUpdateBuffDebuffIcon                    = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 024664D4D6B8 0x28 OnUpdateBuffDebuffIcon      ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnUpdatePrediction                        = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 024664D4D6D8 0x30 OnUpdatePrediction          ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.InitializeCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024664D4D718 0x40 InitializeCts               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LessonStatus                              = (LessonStatus)GetInt32(new IntPtr(p + 0x048)); // 024664D4D738 0x48 LessonStatus                ( 000186602CA0 ModelEnumType LessonStatus LessonStatus LessonStatus Int32 )
            value.ResultStatus                              = (ResultStatus)GetInt32(new IntPtr(p + 0x04C)); // 024664D4D758 0x4C ResultStatus                ( 0001866F4E10 ModelEnumType ResultStatus ResultStatus ResultStatus Int32 )
            value.ExecuteSkillCardIndex                     = GetInt32(new IntPtr(p + 0x050)); // 024664D4D778 0x50 ExecuteSkillCardIndex       ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.ElapsedTimeSecond                         = GetSingle(new IntPtr(p + 0x054)); // 024664D4D798 0x54 ElapsedTimeSecond           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentPlayerPPRecoveryTime               = GetSingle(new IntPtr(p + 0x058)); // 024664D4D7B8 0x58 CurrentPlayerPPRecoveryTime ( 000186665B50 ModelPrimitiveType float float float Single )
            value.ExecuteSkillIndex                         = GetInt32(new IntPtr(p + 0x05C)); // 024664D4D7D8 0x5C ExecuteSkillIndex           ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.StopFlag                                  = GetInt32(new IntPtr(p + 0x060)); // 024664D4D7F8 0x60 StopFlag                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 024664D4D818 0x68 RandomModel                 ( 0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.SkillActionModel                          = GetObject<IngameSkillActionModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.IngameSkillActionModel.FromPointer); // 024664D4D838 0x70 SkillActionModel            ( 0001866E7070 ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer )
            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 024664D4D858 0x78 PlayerModel                 ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.EnemyModel                                = GetObject<IngamePlayerModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 024664D4D878 0x80 EnemyModel                  ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.AiModel                                   = GetObject<AiModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.AiModel.FromPointer); // 024664D4D898 0x88 AiModel                     ( 00018669CF10 ModelClassType AiModel AiModel AiModel Pointer )
            value.EnemyAiModel                              = GetObject<AiModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.AiModel.FromPointer); // 024664D4D8B8 0x90 EnemyAiModel                ( 00018669D1C0 ModelClassType AiModel AiModel AiModel Pointer )
            value.AiExternalAccess                          = GetObject<AiExternalAccess>(new IntPtr(p + 0x098), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 024664D4D8D8 0x98 AiExternalAccess            ( 00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.EnemyAiExternalAccess                     = GetObject<AiExternalAccess>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 024664D4D8F8 0xA0 EnemyAiExternalAccess       ( 00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.IsExecuteTrainerSkill                     = GetBool(new IntPtr(p + 0x0A8)); // 024664D4D918 0xA8 IsExecuteTrainerSkill       ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.EnemySkillTimeCount                       = GetInt32(new IntPtr(p + 0x0AC)); // 024664D4D938 0xAC EnemySkillTimeCount         ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.IsAttackAction                            = GetBool(new IntPtr(p + 0x0B0)); // 024664D4D958 0xB0 IsAttackAction              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectCardCache                           = GetObject<IngamePCardModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024664D4D978 0xB8 SelectCardCache             ( 0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )
            value.IsAttackReady                             = (AttackReadyState)GetInt32(new IntPtr(p + 0x0C0)); // 024664D4D998 0xC0 IsAttackReady               ( 000186600450 ModelEnumType AttackReadyState AttackReadyState AttackReadyState Int32 )
            value.IsDisableInput                            = GetBool(new IntPtr(p + 0x0C4)); // 024664D4D9B8 0xC4 IsDisableInput              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDisableInputDrag                        = GetBool(new IntPtr(p + 0x0C5)); // 024664D4D9D8 0xC5 IsDisableInputDrag          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x108), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024664D4DAF8 0x108 Disposables                 ( 0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsFastForwardEnable                       = GetBool(new IntPtr(p + 0x110)); // 024664D4DB18 0x110 IsFastForwardEnable         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FastForwardSpeedType                      = (FastForwardSpeedType)GetInt32(new IntPtr(p + 0x114)); // 024664D4DB38 0x114 FastForwardSpeedType        ( 000186601990 ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32 )
            value.BgmModel                                  = GetObject<IngameBgmModel>(new IntPtr(p + 0x138), ReversePrism.DataModels.IngameBgmModel.FromPointer); // 024664D4DBD8 0x138 BgmModel                    ( 0001866E2C50 ModelClassType IngameBgmModel IngameBgmModel IngameBgmModel Pointer )
            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x140), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 024664D4DBF8 0x140 TallyModel                  ( 0001866E8E10 ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )
            value.CurrentSelectCardIndex                    = GetInt32(new IntPtr(p + 0x148)); // 024664D4DC18 0x148 CurrentSelectCardIndex      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EnemyAiNotUseCardList                     = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x150), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024664D4DC38 0x150 EnemyAiNotUseCardList       ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.IsAutoMode                                = GetBool(new IntPtr(p + 0x158)); // 024664D4DC58 0x158 IsAutoMode                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x159)); // 024664D4DC78 0x159 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDisableNPC                              = GetBool(new IntPtr(p + 0x15A)); // 024664D4DC98 0x15A IsDisableNPC                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLoopBGM                                 = GetBool(new IntPtr(p + 0x15B)); // 024664D4DCB8 0x15B IsLoopBGM                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PredictionModel                           = GetObject<CardAndSkillPredictionModel>(new IntPtr(p + 0x160), ReversePrism.DataModels.CardAndSkillPredictionModel.FromPointer); // 024664D4DCD8 0x160 PredictionModel             ( 000186545AA0 ModelClassType CardAndSkillPredictionModel CardAndSkillPredictionModel CardAndSkillPredictionModel Pointer )

            return value;
        }
    }
}
