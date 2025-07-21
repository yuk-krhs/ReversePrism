using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolList                                 ModelClassListType List`1<ProduceIdol> List`1<ProduceIdol> List<ProduceIdol> Pointer
    // 018 UnitId                                   ModelPrimitiveType int int int Int32
    // 020 Hand                                     ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 028 MaxHandCount                             ModelPrimitiveType int int int Int32
    // 030 Graveyard                                ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 038 BanishCards                              ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 040 ProducePoint                             ModelPrimitiveType int int int Int32
    // 044 MaxProducePoint                          ModelPrimitiveType int int int Int32
    // 048 AppealPoint                              ModelPrimitiveType int int int Int32
    // 04C MaxAppealPoint                           ModelPrimitiveType int int int Int32
    // 050 MentalGuard                              ModelPrimitiveType int int int Int32
    // 054 AvoidRate                                ModelPrimitiveType int int int Int32
    // 058 PinchBorder                              ModelPrimitiveType int int int Int32
    // 060 UsableSkillCounts                        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 TotalVo                                  ModelPrimitiveType int int int Int32
    // 06C TotalDa                                  ModelPrimitiveType int int int Int32
    // 070 TotalVi                                  ModelPrimitiveType int int int Int32
    // 074 MaxMe                                    ModelPrimitiveType int int int Int32
    // 078 CurrentMe                                ModelPrimitiveType int int int Int32
    // 07C MentalBreakTime                          ModelPrimitiveType float float float Single
    // 080 EffectManager                            ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 088 IdolSkillUseCount                        ModelPrimitiveType int int int Int32
    // 08C ProduceCardUseCount                      ModelPrimitiveType int int int Int32
    // 090 IdolSkillUseIdList                       ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 098 ProduceCardUseIdList                     ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 0A0 MentalBreakCount                         ModelPrimitiveType int int int Int32
    // 0A4 GetTotalVocalAppealPoint                 ModelPrimitiveType int int int Int32
    // 0A8 GetTotalDanceAppealPoint                 ModelPrimitiveType int int int Int32
    // 0AC GetTotalVisualAppealPoint                ModelPrimitiveType int int int Int32
    // 0B0 GetAppealPointCount                      ModelPrimitiveType int int int Int32
    // 0B4 AvoidCount                               ModelPrimitiveType int int int Int32
    // 0B8 SelfDamage                               ModelPrimitiveType int int int Int32
    public partial class PlayerBaseModel : DataModel
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
            var value   = new PlayerBaseModel() { Pointer= p0 };

            value.IdolList                                  = GetObjectList<ProduceIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x10 IdolList                    ( ModelClassListType List`1<ProduceIdol> List`1<ProduceIdol> List<ProduceIdol> Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.Hand                                      = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x20 Hand                        ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.MaxHandCount                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxHandCount                ( ModelPrimitiveType int int int Int32 )
            value.Graveyard                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x30 Graveyard                   ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.BanishCards                               = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x38 BanishCards                 ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.ProducePoint                              = GetInt32(new IntPtr(p + 0x040)); // 0x40 ProducePoint                ( ModelPrimitiveType int int int Int32 )
            value.MaxProducePoint                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 MaxProducePoint             ( ModelPrimitiveType int int int Int32 )
            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 AppealPoint                 ( ModelPrimitiveType int int int Int32 )
            value.MaxAppealPoint                            = GetInt32(new IntPtr(p + 0x04C)); // 0x4C MaxAppealPoint              ( ModelPrimitiveType int int int Int32 )
            value.MentalGuard                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 MentalGuard                 ( ModelPrimitiveType int int int Int32 )
            value.AvoidRate                                 = GetInt32(new IntPtr(p + 0x054)); // 0x54 AvoidRate                   ( ModelPrimitiveType int int int Int32 )
            value.PinchBorder                               = GetInt32(new IntPtr(p + 0x058)); // 0x58 PinchBorder                 ( ModelPrimitiveType int int int Int32 )
            value.UsableSkillCounts                         = GetInt32List(new IntPtr(p + 0x060)); // 0x60 UsableSkillCounts           ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.TotalVo                                   = GetInt32(new IntPtr(p + 0x068)); // 0x68 TotalVo                     ( ModelPrimitiveType int int int Int32 )
            value.TotalDa                                   = GetInt32(new IntPtr(p + 0x06C)); // 0x6C TotalDa                     ( ModelPrimitiveType int int int Int32 )
            value.TotalVi                                   = GetInt32(new IntPtr(p + 0x070)); // 0x70 TotalVi                     ( ModelPrimitiveType int int int Int32 )
            value.MaxMe                                     = GetInt32(new IntPtr(p + 0x074)); // 0x74 MaxMe                       ( ModelPrimitiveType int int int Int32 )
            value.CurrentMe                                 = GetInt32(new IntPtr(p + 0x078)); // 0x78 CurrentMe                   ( ModelPrimitiveType int int int Int32 )
            value.MentalBreakTime                           = GetSingle(new IntPtr(p + 0x07C)); // 0x7C MentalBreakTime             ( ModelPrimitiveType float float float Single )
            value.EffectManager                             = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 0x80 EffectManager               ( ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.IdolSkillUseCount                         = GetInt32(new IntPtr(p + 0x088)); // 0x88 IdolSkillUseCount           ( ModelPrimitiveType int int int Int32 )
            value.ProduceCardUseCount                       = GetInt32(new IntPtr(p + 0x08C)); // 0x8C ProduceCardUseCount         ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillUseIdList                        = GetInt32List(new IntPtr(p + 0x090)); // 0x90 IdolSkillUseIdList          ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ProduceCardUseIdList                      = GetInt32List(new IntPtr(p + 0x098)); // 0x98 ProduceCardUseIdList        ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.MentalBreakCount                          = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MentalBreakCount            ( ModelPrimitiveType int int int Int32 )
            value.GetTotalVocalAppealPoint                  = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 GetTotalVocalAppealPoint    ( ModelPrimitiveType int int int Int32 )
            value.GetTotalDanceAppealPoint                  = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 GetTotalDanceAppealPoint    ( ModelPrimitiveType int int int Int32 )
            value.GetTotalVisualAppealPoint                 = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC GetTotalVisualAppealPoint   ( ModelPrimitiveType int int int Int32 )
            value.GetAppealPointCount                       = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 GetAppealPointCount         ( ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 AvoidCount                  ( ModelPrimitiveType int int int Int32 )
            value.SelfDamage                                = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 SelfDamage                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
