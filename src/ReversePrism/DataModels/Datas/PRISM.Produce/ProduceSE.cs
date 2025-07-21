using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 ResultActionSuccess                      SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 DisplayFunUp                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 UseIdleSkill                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 UseIdleCard                              ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 AlertPinch                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 ResultActionFailure                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 AlertMentalBreak                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 AppealGuageUp                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 MeGuageDown                              ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 ActionMentalguard                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 TimeleftAlert                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 MeGuageRecovery                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 ActionTrainerSkill                       ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 EffectDeBuff                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 EffectBuff                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 TimeleftAlertLesson                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 100 ResultStatusUp                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 110 ResultRankUp                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 120 ResultTassei                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 130 ResultParameterUp                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 140 ChibicharaOut                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 150 ActionAvoid                              ModelEnumType SoundKey SoundKey SoundKey Int32
    // 160 ResultActionPerfect                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 170 EffectAppealWave                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 180 EffectAppealLineRed                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 190 EffectAppealLineGreen                    ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1A0 EffectAppealLineBlue                     ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1B0 ProduceStart                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1C0 SesonStart                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1D0 ScenarioChoice                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1E0 CardRivalTurn                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1F0 CardRefill                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 200 UseIdleSkillIcon                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 210 CountdownStart                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 220 CountdownWord                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 230 ResultLessonFinished                     ModelEnumType SoundKey SoundKey SoundKey Int32
    // 240 ResultGageupLoop                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 250 ResultPcardRankupCount                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 260 ResultMissionTassei                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 270 ResultClearLankGreat                     ModelEnumType SoundKey SoundKey SoundKey Int32
    // 280 ResultClearLankGood                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 290 ResultClearLankSS                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2A0 ResultClearLankS                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2B0 ResultClearLankA                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2C0 ResultTips                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2D0 DisplayAutoSchedule                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2E0 LessonJingleFailureShort                 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2F0 LessonJingleFailure                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 300 LessonJingleSuccess                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 310 SeProduceSkillIrekae                     ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class ProduceSE : DataModel
    {
        public SoundKey                                 DisplayFunUp                            { get; set; }
        public SoundKey                                 UseIdleSkill                            { get; set; }
        public SoundKey                                 UseIdleCard                             { get; set; }
        public SoundKey                                 AlertPinch                              { get; set; }
        public SoundKey                                 ResultActionFailure                     { get; set; }
        public SoundKey                                 AlertMentalBreak                        { get; set; }
        public SoundKey                                 AppealGuageUp                           { get; set; }
        public SoundKey                                 MeGuageDown                             { get; set; }
        public SoundKey                                 ActionMentalguard                       { get; set; }
        public SoundKey                                 TimeleftAlert                           { get; set; }
        public SoundKey                                 MeGuageRecovery                         { get; set; }
        public SoundKey                                 ActionTrainerSkill                      { get; set; }
        public SoundKey                                 EffectDeBuff                            { get; set; }
        public SoundKey                                 EffectBuff                              { get; set; }
        public SoundKey                                 TimeleftAlertLesson                     { get; set; }
        public SoundKey                                 ResultStatusUp                          { get; set; }
        public SoundKey                                 ResultRankUp                            { get; set; }
        public SoundKey                                 ResultTassei                            { get; set; }
        public SoundKey                                 ResultParameterUp                       { get; set; }
        public SoundKey                                 ChibicharaOut                           { get; set; }
        public SoundKey                                 ActionAvoid                             { get; set; }
        public SoundKey                                 ResultActionPerfect                     { get; set; }
        public SoundKey                                 EffectAppealWave                        { get; set; }
        public SoundKey                                 EffectAppealLineRed                     { get; set; }
        public SoundKey                                 EffectAppealLineGreen                   { get; set; }
        public SoundKey                                 EffectAppealLineBlue                    { get; set; }
        public SoundKey                                 ProduceStart                            { get; set; }
        public SoundKey                                 SesonStart                              { get; set; }
        public SoundKey                                 ScenarioChoice                          { get; set; }
        public SoundKey                                 CardRivalTurn                           { get; set; }
        public SoundKey                                 CardRefill                              { get; set; }
        public SoundKey                                 UseIdleSkillIcon                        { get; set; }
        public SoundKey                                 CountdownStart                          { get; set; }
        public SoundKey                                 CountdownWord                           { get; set; }
        public SoundKey                                 ResultLessonFinished                    { get; set; }
        public SoundKey                                 ResultGageupLoop                        { get; set; }
        public SoundKey                                 ResultPcardRankupCount                  { get; set; }
        public SoundKey                                 ResultMissionTassei                     { get; set; }
        public SoundKey                                 ResultClearLankGreat                    { get; set; }
        public SoundKey                                 ResultClearLankGood                     { get; set; }
        public SoundKey                                 ResultClearLankSS                       { get; set; }
        public SoundKey                                 ResultClearLankS                        { get; set; }
        public SoundKey                                 ResultClearLankA                        { get; set; }
        public SoundKey                                 ResultTips                              { get; set; }
        public SoundKey                                 DisplayAutoSchedule                     { get; set; }
        public SoundKey                                 LessonJingleFailureShort                { get; set; }
        public SoundKey                                 LessonJingleFailure                     { get; set; }
        public SoundKey                                 LessonJingleSuccess                     { get; set; }
        public SoundKey                                 SeProduceSkillIrekae                    { get; set; }

        public static ProduceSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSE() { Pointer= p0 };

            value.DisplayFunUp                              = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 DisplayFunUp                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UseIdleSkill                              = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 UseIdleSkill                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UseIdleCard                               = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0x30 UseIdleCard                 ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.AlertPinch                                = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0x40 AlertPinch                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultActionFailure                       = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0x50 ResultActionFailure         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.AlertMentalBreak                          = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0x60 AlertMentalBreak            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.AppealGuageUp                             = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0x70 AppealGuageUp               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MeGuageDown                               = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0x80 MeGuageDown                 ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ActionMentalguard                         = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0x90 ActionMentalguard           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TimeleftAlert                             = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 TimeleftAlert               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MeGuageRecovery                           = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 MeGuageRecovery             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ActionTrainerSkill                        = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 ActionTrainerSkill          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectDeBuff                              = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 EffectDeBuff                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectBuff                                = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 EffectBuff                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TimeleftAlertLesson                       = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 TimeleftAlertLesson         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultStatusUp                            = (SoundKey)GetInt32(new IntPtr(p + 0x100)); // 0x100 ResultStatusUp              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultRankUp                              = (SoundKey)GetInt32(new IntPtr(p + 0x110)); // 0x110 ResultRankUp                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultTassei                              = (SoundKey)GetInt32(new IntPtr(p + 0x120)); // 0x120 ResultTassei                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultParameterUp                         = (SoundKey)GetInt32(new IntPtr(p + 0x130)); // 0x130 ResultParameterUp           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ChibicharaOut                             = (SoundKey)GetInt32(new IntPtr(p + 0x140)); // 0x140 ChibicharaOut               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ActionAvoid                               = (SoundKey)GetInt32(new IntPtr(p + 0x150)); // 0x150 ActionAvoid                 ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultActionPerfect                       = (SoundKey)GetInt32(new IntPtr(p + 0x160)); // 0x160 ResultActionPerfect         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealWave                          = (SoundKey)GetInt32(new IntPtr(p + 0x170)); // 0x170 EffectAppealWave            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealLineRed                       = (SoundKey)GetInt32(new IntPtr(p + 0x180)); // 0x180 EffectAppealLineRed         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealLineGreen                     = (SoundKey)GetInt32(new IntPtr(p + 0x190)); // 0x190 EffectAppealLineGreen       ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealLineBlue                      = (SoundKey)GetInt32(new IntPtr(p + 0x1A0)); // 0x1A0 EffectAppealLineBlue        ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ProduceStart                              = (SoundKey)GetInt32(new IntPtr(p + 0x1B0)); // 0x1B0 ProduceStart                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SesonStart                                = (SoundKey)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 SesonStart                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ScenarioChoice                            = (SoundKey)GetInt32(new IntPtr(p + 0x1D0)); // 0x1D0 ScenarioChoice              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CardRivalTurn                             = (SoundKey)GetInt32(new IntPtr(p + 0x1E0)); // 0x1E0 CardRivalTurn               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CardRefill                                = (SoundKey)GetInt32(new IntPtr(p + 0x1F0)); // 0x1F0 CardRefill                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UseIdleSkillIcon                          = (SoundKey)GetInt32(new IntPtr(p + 0x200)); // 0x200 UseIdleSkillIcon            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CountdownStart                            = (SoundKey)GetInt32(new IntPtr(p + 0x210)); // 0x210 CountdownStart              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CountdownWord                             = (SoundKey)GetInt32(new IntPtr(p + 0x220)); // 0x220 CountdownWord               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultLessonFinished                      = (SoundKey)GetInt32(new IntPtr(p + 0x230)); // 0x230 ResultLessonFinished        ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultGageupLoop                          = (SoundKey)GetInt32(new IntPtr(p + 0x240)); // 0x240 ResultGageupLoop            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultPcardRankupCount                    = (SoundKey)GetInt32(new IntPtr(p + 0x250)); // 0x250 ResultPcardRankupCount      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultMissionTassei                       = (SoundKey)GetInt32(new IntPtr(p + 0x260)); // 0x260 ResultMissionTassei         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankGreat                      = (SoundKey)GetInt32(new IntPtr(p + 0x270)); // 0x270 ResultClearLankGreat        ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankGood                       = (SoundKey)GetInt32(new IntPtr(p + 0x280)); // 0x280 ResultClearLankGood         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankSS                         = (SoundKey)GetInt32(new IntPtr(p + 0x290)); // 0x290 ResultClearLankSS           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankS                          = (SoundKey)GetInt32(new IntPtr(p + 0x2A0)); // 0x2A0 ResultClearLankS            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankA                          = (SoundKey)GetInt32(new IntPtr(p + 0x2B0)); // 0x2B0 ResultClearLankA            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultTips                                = (SoundKey)GetInt32(new IntPtr(p + 0x2C0)); // 0x2C0 ResultTips                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.DisplayAutoSchedule                       = (SoundKey)GetInt32(new IntPtr(p + 0x2D0)); // 0x2D0 DisplayAutoSchedule         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LessonJingleFailureShort                  = (SoundKey)GetInt32(new IntPtr(p + 0x2E0)); // 0x2E0 LessonJingleFailureShort    ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LessonJingleFailure                       = (SoundKey)GetInt32(new IntPtr(p + 0x2F0)); // 0x2F0 LessonJingleFailure         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LessonJingleSuccess                       = (SoundKey)GetInt32(new IntPtr(p + 0x300)); // 0x300 LessonJingleSuccess         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SeProduceSkillIrekae                      = (SoundKey)GetInt32(new IntPtr(p + 0x310)); // 0x310 SeProduceSkillIrekae        ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
