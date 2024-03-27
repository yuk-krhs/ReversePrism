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
    // 010 DisplayFunUp                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 UseIdleSkill                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 UseIdleCard                              000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 AlertPinch                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 ResultActionFailure                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 AlertMentalBreak                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 AppealGuageUp                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 MeGuageDown                              000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 ActionMentalguard                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 TimeleftAlert                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 MeGuageRecovery                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 ActionTrainerSkill                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 EffectDeBuff                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 EffectBuff                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 TimeleftAlertLesson                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 100 ResultStatusUp                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 110 ResultRankUp                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 120 ResultTassei                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 130 ResultParameterUp                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 140 ChibicharaOut                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 150 ActionAvoid                              000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 160 ResultActionPerfect                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 170 EffectAppealWave                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 180 EffectAppealLineRed                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 190 EffectAppealLineGreen                    000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1A0 EffectAppealLineBlue                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1B0 ProduceStart                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1C0 SesonStart                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1D0 ScenarioChoice                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1E0 CardRivalTurn                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1F0 CardRefill                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 200 UseIdleSkillIcon                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 210 CountdownStart                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 220 CountdownWord                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 230 ResultLessonFinished                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 240 ResultGageupLoop                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 250 ResultPcardRankupCount                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 260 ResultMissionTassei                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 270 ResultClearLankGreat                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 280 ResultClearLankGood                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 290 ResultClearLankSS                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2A0 ResultClearLankS                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2B0 ResultClearLankA                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2C0 ResultTips                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2D0 DisplayAutoSchedule                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2E0 LessonJingleFailureShort                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 2F0 LessonJingleFailure                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 300 LessonJingleSuccess                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 310 SeProduceSkillIrekae                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class ProduceSE
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
            var value   = new ProduceSE();

            value.DisplayFunUp                              = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0270D5C7BED8 0x10 DisplayFunUp                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UseIdleSkill                              = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0270D5C7BEF8 0x20 UseIdleSkill                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UseIdleCard                               = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0270D5C7BF18 0x30 UseIdleCard                 ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.AlertPinch                                = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0270D5C7BF38 0x40 AlertPinch                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultActionFailure                       = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0270D5C7BF58 0x50 ResultActionFailure         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.AlertMentalBreak                          = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0270D5C7BF78 0x60 AlertMentalBreak            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.AppealGuageUp                             = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0270D5C7BF98 0x70 AppealGuageUp               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MeGuageDown                               = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0270D5C7BFB8 0x80 MeGuageDown                 ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ActionMentalguard                         = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0270D5C7BFD8 0x90 ActionMentalguard           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TimeleftAlert                             = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0270D5C7BFF8 0xA0 TimeleftAlert               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MeGuageRecovery                           = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 0270D5C7C018 0xB0 MeGuageRecovery             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ActionTrainerSkill                        = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 0270D5C7C038 0xC0 ActionTrainerSkill          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectDeBuff                              = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 0270D5C7C058 0xD0 EffectDeBuff                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectBuff                                = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 0270D5C7C078 0xE0 EffectBuff                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TimeleftAlertLesson                       = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 0270D5C7C098 0xF0 TimeleftAlertLesson         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultStatusUp                            = (SoundKey)GetInt32(new IntPtr(p + 0x100)); // 0270D5C7C0B8 0x100 ResultStatusUp              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultRankUp                              = (SoundKey)GetInt32(new IntPtr(p + 0x110)); // 0270D5C7C0D8 0x110 ResultRankUp                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultTassei                              = (SoundKey)GetInt32(new IntPtr(p + 0x120)); // 0270D5C7C0F8 0x120 ResultTassei                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultParameterUp                         = (SoundKey)GetInt32(new IntPtr(p + 0x130)); // 0270D5C7C118 0x130 ResultParameterUp           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ChibicharaOut                             = (SoundKey)GetInt32(new IntPtr(p + 0x140)); // 0270D5C7C138 0x140 ChibicharaOut               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ActionAvoid                               = (SoundKey)GetInt32(new IntPtr(p + 0x150)); // 0270D5C7C158 0x150 ActionAvoid                 ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultActionPerfect                       = (SoundKey)GetInt32(new IntPtr(p + 0x160)); // 0270D5C7C178 0x160 ResultActionPerfect         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealWave                          = (SoundKey)GetInt32(new IntPtr(p + 0x170)); // 0270D5C7C198 0x170 EffectAppealWave            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealLineRed                       = (SoundKey)GetInt32(new IntPtr(p + 0x180)); // 0270D5C7C1B8 0x180 EffectAppealLineRed         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealLineGreen                     = (SoundKey)GetInt32(new IntPtr(p + 0x190)); // 0270D5C7C1D8 0x190 EffectAppealLineGreen       ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EffectAppealLineBlue                      = (SoundKey)GetInt32(new IntPtr(p + 0x1A0)); // 0270D5C7C1F8 0x1A0 EffectAppealLineBlue        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ProduceStart                              = (SoundKey)GetInt32(new IntPtr(p + 0x1B0)); // 0270D5C7C218 0x1B0 ProduceStart                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SesonStart                                = (SoundKey)GetInt32(new IntPtr(p + 0x1C0)); // 0270D5C7C238 0x1C0 SesonStart                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ScenarioChoice                            = (SoundKey)GetInt32(new IntPtr(p + 0x1D0)); // 0270D5C7C258 0x1D0 ScenarioChoice              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CardRivalTurn                             = (SoundKey)GetInt32(new IntPtr(p + 0x1E0)); // 0270D5C7C278 0x1E0 CardRivalTurn               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CardRefill                                = (SoundKey)GetInt32(new IntPtr(p + 0x1F0)); // 0270D5C7C298 0x1F0 CardRefill                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UseIdleSkillIcon                          = (SoundKey)GetInt32(new IntPtr(p + 0x200)); // 0270D5C7C2B8 0x200 UseIdleSkillIcon            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CountdownStart                            = (SoundKey)GetInt32(new IntPtr(p + 0x210)); // 0270D5C7C2D8 0x210 CountdownStart              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.CountdownWord                             = (SoundKey)GetInt32(new IntPtr(p + 0x220)); // 0270D5C7C2F8 0x220 CountdownWord               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultLessonFinished                      = (SoundKey)GetInt32(new IntPtr(p + 0x230)); // 0270D5C7C318 0x230 ResultLessonFinished        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultGageupLoop                          = (SoundKey)GetInt32(new IntPtr(p + 0x240)); // 0270D5C7C338 0x240 ResultGageupLoop            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultPcardRankupCount                    = (SoundKey)GetInt32(new IntPtr(p + 0x250)); // 0270D5C7C358 0x250 ResultPcardRankupCount      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultMissionTassei                       = (SoundKey)GetInt32(new IntPtr(p + 0x260)); // 0270D5C7C378 0x260 ResultMissionTassei         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankGreat                      = (SoundKey)GetInt32(new IntPtr(p + 0x270)); // 0270D5C7C398 0x270 ResultClearLankGreat        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankGood                       = (SoundKey)GetInt32(new IntPtr(p + 0x280)); // 0270D5C7C3B8 0x280 ResultClearLankGood         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankSS                         = (SoundKey)GetInt32(new IntPtr(p + 0x290)); // 0270D5C7C3D8 0x290 ResultClearLankSS           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankS                          = (SoundKey)GetInt32(new IntPtr(p + 0x2A0)); // 0270D5C7C3F8 0x2A0 ResultClearLankS            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultClearLankA                          = (SoundKey)GetInt32(new IntPtr(p + 0x2B0)); // 0270D5C7C418 0x2B0 ResultClearLankA            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultTips                                = (SoundKey)GetInt32(new IntPtr(p + 0x2C0)); // 0270D5C7C438 0x2C0 ResultTips                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.DisplayAutoSchedule                       = (SoundKey)GetInt32(new IntPtr(p + 0x2D0)); // 0270D5C7C458 0x2D0 DisplayAutoSchedule         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LessonJingleFailureShort                  = (SoundKey)GetInt32(new IntPtr(p + 0x2E0)); // 0270D5C7C478 0x2E0 LessonJingleFailureShort    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LessonJingleFailure                       = (SoundKey)GetInt32(new IntPtr(p + 0x2F0)); // 0270D5C7C498 0x2F0 LessonJingleFailure         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LessonJingleSuccess                       = (SoundKey)GetInt32(new IntPtr(p + 0x300)); // 0270D5C7C4B8 0x300 LessonJingleSuccess         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SeProduceSkillIrekae                      = (SoundKey)GetInt32(new IntPtr(p + 0x310)); // 0270D5C7C4D8 0x310 SeProduceSkillIrekae        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
