using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolList                                 000185CFBE28 ModelClassListType List`1<ProduceIdol> List`1<ProduceIdol> List<ProduceIdol> Pointer
    // 018 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Hand                                     000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 028 MaxHandCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Graveyard                                000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 038 BanishCards                              000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 040 ProducePoint                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 MaxProducePoint                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 AppealPoint                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C MaxAppealPoint                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 MentalGuard                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 AvoidRate                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 PinchBorder                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 UsableSkillCounts                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 TotalVo                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 06C TotalDa                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 TotalVi                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 074 MaxMe                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 078 CurrentMe                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 07C MentalBreakTime                          000186666050 ModelPrimitiveType float float float Single
    // 080 EffectManager                            000186557AA0 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 088 IdolSkillUseCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 08C ProduceCardUseCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 090 IdolSkillUseIdList                       000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 098 ProduceCardUseIdList                     000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 0A0 MentalBreakCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A4 GetTotalVocalAppealPoint                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A8 GetTotalDanceAppealPoint                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 0AC GetTotalVisualAppealPoint                0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B0 GetAppealPointCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B4 AvoidCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B8 SelfDamage                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class PlayerBaseModel
    {
        public List<ProduceIdol>?                       IdolList                                { get; set; }
        public int                                      UnitId                                  { get; set; }
        public List<IProduceCardStatus>?                Hand                                    { get; set; }
        public int                                      MaxHandCount                            { get; set; }
        public List<IProduceCardStatus>?                Graveyard                               { get; set; }
        public List<IProduceCardStatus>?                BanishCards                             { get; set; }
        public int                                      ProducePoint                            { get; set; }
        public int                                      MaxProducePoint                         { get; set; }
        public int                                      AppealPoint                             { get; set; }
        public int                                      MaxAppealPoint                          { get; set; }
        public int                                      MentalGuard                             { get; set; }
        public int                                      AvoidRate                               { get; set; }
        public int                                      PinchBorder                             { get; set; }
        public List<int>?                               UsableSkillCounts                       { get; set; }
        public int                                      TotalVo                                 { get; set; }
        public int                                      TotalDa                                 { get; set; }
        public int                                      TotalVi                                 { get; set; }
        public int                                      MaxMe                                   { get; set; }
        public int                                      CurrentMe                               { get; set; }
        public float                                    MentalBreakTime                         { get; set; }
        public ProduceInGameEffectManager?              EffectManager                           { get; set; }
        public int                                      IdolSkillUseCount                       { get; set; }
        public int                                      ProduceCardUseCount                     { get; set; }
        public List<int>?                               IdolSkillUseIdList                      { get; set; }
        public List<int>?                               ProduceCardUseIdList                    { get; set; }
        public int                                      MentalBreakCount                        { get; set; }
        public int                                      GetTotalVocalAppealPoint                { get; set; }
        public int                                      GetTotalDanceAppealPoint                { get; set; }
        public int                                      GetTotalVisualAppealPoint               { get; set; }
        public int                                      GetAppealPointCount                     { get; set; }
        public int                                      AvoidCount                              { get; set; }
        public int                                      SelfDamage                              { get; set; }

        public static PlayerBaseModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerBaseModel();

            value.IdolList                                  = GetObjectList<ProduceIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0270D5D91218 0x10 IdolList                    ( 000185CFBE28 ModelClassListType List`1<ProduceIdol> List`1<ProduceIdol> List<ProduceIdol> Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D5D91238 0x18 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hand                                      = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5D91258 0x20 Hand                        ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.MaxHandCount                              = GetInt32(new IntPtr(p + 0x028)); // 0270D5D91278 0x28 MaxHandCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Graveyard                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5D91298 0x30 Graveyard                   ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.BanishCards                               = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5D912B8 0x38 BanishCards                 ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.ProducePoint                              = GetInt32(new IntPtr(p + 0x040)); // 0270D5D912D8 0x40 ProducePoint                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxProducePoint                           = GetInt32(new IntPtr(p + 0x044)); // 0270D5D912F8 0x44 MaxProducePoint             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x048)); // 0270D5D91318 0x48 AppealPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxAppealPoint                            = GetInt32(new IntPtr(p + 0x04C)); // 0270D5D91338 0x4C MaxAppealPoint              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MentalGuard                               = GetInt32(new IntPtr(p + 0x050)); // 0270D5D91358 0x50 MentalGuard                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AvoidRate                                 = GetInt32(new IntPtr(p + 0x054)); // 0270D5D91378 0x54 AvoidRate                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PinchBorder                               = GetInt32(new IntPtr(p + 0x058)); // 0270D5D91398 0x58 PinchBorder                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UsableSkillCounts                         = GetInt32List(new IntPtr(p + 0x060)); // 0270D5D913B8 0x60 UsableSkillCounts           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.TotalVo                                   = GetInt32(new IntPtr(p + 0x068)); // 0270D5D913D8 0x68 TotalVo                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalDa                                   = GetInt32(new IntPtr(p + 0x06C)); // 0270D5D913F8 0x6C TotalDa                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalVi                                   = GetInt32(new IntPtr(p + 0x070)); // 0270D5D91418 0x70 TotalVi                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxMe                                     = GetInt32(new IntPtr(p + 0x074)); // 0270D5D91438 0x74 MaxMe                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentMe                                 = GetInt32(new IntPtr(p + 0x078)); // 0270D5D91458 0x78 CurrentMe                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MentalBreakTime                           = GetSingle(new IntPtr(p + 0x07C)); // 0270D5D91478 0x7C MentalBreakTime             ( 000186666050 ModelPrimitiveType float float float Single )
            value.EffectManager                             = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 0270D5D91498 0x80 EffectManager               ( 000186557AA0 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.IdolSkillUseCount                         = GetInt32(new IntPtr(p + 0x088)); // 0270D5D914B8 0x88 IdolSkillUseCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProduceCardUseCount                       = GetInt32(new IntPtr(p + 0x08C)); // 0270D5D914D8 0x8C ProduceCardUseCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillUseIdList                        = GetInt32List(new IntPtr(p + 0x090)); // 0270D5D914F8 0x90 IdolSkillUseIdList          ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ProduceCardUseIdList                      = GetInt32List(new IntPtr(p + 0x098)); // 0270D5D91518 0x98 ProduceCardUseIdList        ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.MentalBreakCount                          = GetInt32(new IntPtr(p + 0x0A0)); // 0270D5D91538 0xA0 MentalBreakCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetTotalVocalAppealPoint                  = GetInt32(new IntPtr(p + 0x0A4)); // 0270D5D91558 0xA4 GetTotalVocalAppealPoint    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetTotalDanceAppealPoint                  = GetInt32(new IntPtr(p + 0x0A8)); // 0270D5D91578 0xA8 GetTotalDanceAppealPoint    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetTotalVisualAppealPoint                 = GetInt32(new IntPtr(p + 0x0AC)); // 0270D5D91598 0xAC GetTotalVisualAppealPoint   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetAppealPointCount                       = GetInt32(new IntPtr(p + 0x0B0)); // 0270D5D915B8 0xB0 GetAppealPointCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x0B4)); // 0270D5D915D8 0xB4 AvoidCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SelfDamage                                = GetInt32(new IntPtr(p + 0x0B8)); // 0270D5D915F8 0xB8 SelfDamage                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
