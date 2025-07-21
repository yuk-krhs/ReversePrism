using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameter                                ModelEnumType ParameterType ParameterType ParameterType Int32
    // 014 DeckCost                                 ModelEnumType DeckCostType DeckCostType DeckCostType Int32
    // 018 IsAppealMentalDamage                     ModelPrimitiveType bool bool bool Bool
    // 019 IsAppealMentalRecovery                   ModelPrimitiveType bool bool bool Bool
    // 01A IsAppealPointRateUp                      ModelPrimitiveType bool bool bool Bool
    // 01B IsBeforeUseProducePoint                  ModelPrimitiveType bool bool bool Bool
    // 01C IsMentalGuard                            ModelPrimitiveType bool bool bool Bool
    // 01D IsContinueAppeal                         ModelPrimitiveType bool bool bool Bool
    // 01E IsFixValue                               ModelPrimitiveType bool bool bool Bool
    // 01F IsTime                                   ModelPrimitiveType bool bool bool Bool
    // 020 IsNotGet                                 ModelPrimitiveType bool bool bool Bool
    // 021 IsMentalRecoveryOthers                   ModelPrimitiveType bool bool bool Bool
    // 022 IsAppealPointRateUpOthers                ModelPrimitiveType bool bool bool Bool
    // 023 IsRecoveryIdolSkillCountOthers           ModelPrimitiveType bool bool bool Bool
    // 024 IsSwapCardOthers                         ModelPrimitiveType bool bool bool Bool
    // 025 IsGetMentalGuardOthers                   ModelPrimitiveType bool bool bool Bool
    // 026 IsNotGetOthers                           ModelPrimitiveType bool bool bool Bool
    // 027 IsNoneEffectAvoid                        ModelPrimitiveType bool bool bool Bool
    // 028 IsAppealPointRateUpAvoid                 ModelPrimitiveType bool bool bool Bool
    // 029 IsMentalDamageUpAvoid                    ModelPrimitiveType bool bool bool Bool
    // 02A IsAvoidCountRef                          ModelPrimitiveType bool bool bool Bool
    // 02B IsMentalRecoveryAvoid                    ModelPrimitiveType bool bool bool Bool
    // 02C IsNotGetAvoid                            ModelPrimitiveType bool bool bool Bool
    // 02D IsAppealPointRateUpAvoidBuff             ModelPrimitiveType bool bool bool Bool
    // 02E IsAppealPointAvoidCountRateUpAvoidBuff   ModelPrimitiveType bool bool bool Bool
    // 02F IsAppealPointAvoidBuffCountRateUpAvoidBuff ModelPrimitiveType bool bool bool Bool
    // 030 IsNotGetAvoidBuff                        ModelPrimitiveType bool bool bool Bool
    // 031 IsAppealAvoidBuffNoConsumption           ModelPrimitiveType bool bool bool Bool
    // 032 IsAppealAvoidRateRef                     ModelPrimitiveType bool bool bool Bool
    // 033 IsNotGetNoNoctyl                         ModelPrimitiveType bool bool bool Bool
    public partial class CardSelectAiData : DataModel
    {
        public ParameterType                            Parameter                               { get; set; }
        public DeckCostType                             DeckCost                                { get; set; }
        public bool                                     IsAppealMentalDamage                    { get; set; }
        public bool                                     IsAppealMentalRecovery                  { get; set; }
        public bool                                     IsAppealPointRateUp                     { get; set; }
        public bool                                     IsBeforeUseProducePoint                 { get; set; }
        public bool                                     IsMentalGuard                           { get; set; }
        public bool                                     IsContinueAppeal                        { get; set; }
        public bool                                     IsFixValue                              { get; set; }
        public bool                                     IsTime                                  { get; set; }
        public bool                                     IsNotGet                                { get; set; }
        public bool                                     IsMentalRecoveryOthers                  { get; set; }
        public bool                                     IsAppealPointRateUpOthers               { get; set; }
        public bool                                     IsRecoveryIdolSkillCountOthers          { get; set; }
        public bool                                     IsSwapCardOthers                        { get; set; }
        public bool                                     IsGetMentalGuardOthers                  { get; set; }
        public bool                                     IsNotGetOthers                          { get; set; }
        public bool                                     IsNoneEffectAvoid                       { get; set; }
        public bool                                     IsAppealPointRateUpAvoid                { get; set; }
        public bool                                     IsMentalDamageUpAvoid                   { get; set; }
        public bool                                     IsAvoidCountRef                         { get; set; }
        public bool                                     IsMentalRecoveryAvoid                   { get; set; }
        public bool                                     IsNotGetAvoid                           { get; set; }
        public bool                                     IsAppealPointRateUpAvoidBuff            { get; set; }
        public bool                                     IsAppealPointAvoidCountRateUpAvoidBuff  { get; set; }
        public bool                                     IsAppealPointAvoidBuffCountRateUpAvoidBuff { get; set; }
        public bool                                     IsNotGetAvoidBuff                       { get; set; }
        public bool                                     IsAppealAvoidBuffNoConsumption          { get; set; }
        public bool                                     IsAppealAvoidRateRef                    { get; set; }
        public bool                                     IsNotGetNoNoctyl                        { get; set; }

        public static CardSelectAiData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardSelectAiData() { Pointer= p0 };

            value.Parameter                                 = (ParameterType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Parameter                   ( ModelEnumType ParameterType ParameterType ParameterType Int32 )
            value.DeckCost                                  = (DeckCostType)GetInt32(new IntPtr(p + 0x014)); // 0x14 DeckCost                    ( ModelEnumType DeckCostType DeckCostType DeckCostType Int32 )
            value.IsAppealMentalDamage                      = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAppealMentalDamage        ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealMentalRecovery                    = GetBool(new IntPtr(p + 0x019)); // 0x19 IsAppealMentalRecovery      ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUp                       = GetBool(new IntPtr(p + 0x01A)); // 0x1A IsAppealPointRateUp         ( ModelPrimitiveType bool bool bool Bool )
            value.IsBeforeUseProducePoint                   = GetBool(new IntPtr(p + 0x01B)); // 0x1B IsBeforeUseProducePoint     ( ModelPrimitiveType bool bool bool Bool )
            value.IsMentalGuard                             = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsMentalGuard               ( ModelPrimitiveType bool bool bool Bool )
            value.IsContinueAppeal                          = GetBool(new IntPtr(p + 0x01D)); // 0x1D IsContinueAppeal            ( ModelPrimitiveType bool bool bool Bool )
            value.IsFixValue                                = GetBool(new IntPtr(p + 0x01E)); // 0x1E IsFixValue                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsTime                                    = GetBool(new IntPtr(p + 0x01F)); // 0x1F IsTime                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotGet                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsNotGet                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsMentalRecoveryOthers                    = GetBool(new IntPtr(p + 0x021)); // 0x21 IsMentalRecoveryOthers      ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUpOthers                 = GetBool(new IntPtr(p + 0x022)); // 0x22 IsAppealPointRateUpOthers   ( ModelPrimitiveType bool bool bool Bool )
            value.IsRecoveryIdolSkillCountOthers            = GetBool(new IntPtr(p + 0x023)); // 0x23 IsRecoveryIdolSkillCountOthers ( ModelPrimitiveType bool bool bool Bool )
            value.IsSwapCardOthers                          = GetBool(new IntPtr(p + 0x024)); // 0x24 IsSwapCardOthers            ( ModelPrimitiveType bool bool bool Bool )
            value.IsGetMentalGuardOthers                    = GetBool(new IntPtr(p + 0x025)); // 0x25 IsGetMentalGuardOthers      ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetOthers                            = GetBool(new IntPtr(p + 0x026)); // 0x26 IsNotGetOthers              ( ModelPrimitiveType bool bool bool Bool )
            value.IsNoneEffectAvoid                         = GetBool(new IntPtr(p + 0x027)); // 0x27 IsNoneEffectAvoid           ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUpAvoid                  = GetBool(new IntPtr(p + 0x028)); // 0x28 IsAppealPointRateUpAvoid    ( ModelPrimitiveType bool bool bool Bool )
            value.IsMentalDamageUpAvoid                     = GetBool(new IntPtr(p + 0x029)); // 0x29 IsMentalDamageUpAvoid       ( ModelPrimitiveType bool bool bool Bool )
            value.IsAvoidCountRef                           = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsAvoidCountRef             ( ModelPrimitiveType bool bool bool Bool )
            value.IsMentalRecoveryAvoid                     = GetBool(new IntPtr(p + 0x02B)); // 0x2B IsMentalRecoveryAvoid       ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetAvoid                             = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsNotGetAvoid               ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUpAvoidBuff              = GetBool(new IntPtr(p + 0x02D)); // 0x2D IsAppealPointRateUpAvoidBuff ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointAvoidCountRateUpAvoidBuff    = GetBool(new IntPtr(p + 0x02E)); // 0x2E IsAppealPointAvoidCountRateUpAvoidBuff ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointAvoidBuffCountRateUpAvoidBuff = GetBool(new IntPtr(p + 0x02F)); // 0x2F IsAppealPointAvoidBuffCountRateUpAvoidBuff ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetAvoidBuff                         = GetBool(new IntPtr(p + 0x030)); // 0x30 IsNotGetAvoidBuff           ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealAvoidBuffNoConsumption            = GetBool(new IntPtr(p + 0x031)); // 0x31 IsAppealAvoidBuffNoConsumption ( ModelPrimitiveType bool bool bool Bool )
            value.IsAppealAvoidRateRef                      = GetBool(new IntPtr(p + 0x032)); // 0x32 IsAppealAvoidRateRef        ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetNoNoctyl                          = GetBool(new IntPtr(p + 0x033)); // 0x33 IsNotGetNoNoctyl            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
