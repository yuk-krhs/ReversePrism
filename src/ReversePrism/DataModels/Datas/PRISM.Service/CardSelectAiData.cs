using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameter                                00018672C810 ModelEnumType ParameterType ParameterType ParameterType Int32
    // 014 DeckCost                                 00018672C150 ModelEnumType DeckCostType DeckCostType DeckCostType Int32
    // 018 IsAppealMentalDamage                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 IsAppealMentalRecovery                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A IsAppealPointRateUp                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01B IsBeforeUseProducePoint                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C IsMentalGuard                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01D IsContinueAppeal                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01E IsFixValue                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01F IsTime                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 IsNotGet                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 IsMentalRecoveryOthers                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 IsAppealPointRateUpOthers                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 023 IsRecoveryIdolSkillCountOthers           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 IsSwapCardOthers                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 IsGetMentalGuardOthers                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 026 IsNotGetOthers                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 027 IsNoneEffectAvoid                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 IsAppealPointRateUpAvoid                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 IsMentalDamageUpAvoid                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A IsAvoidCountRef                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02B IsMentalRecoveryAvoid                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C IsNotGetAvoid                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D IsAppealPointRateUpAvoidBuff             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02E IsAppealPointAvoidCountRateUpAvoidBuff   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02F IsAppealPointAvoidBuffCountRateUpAvoidBuff 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 IsNotGetAvoidBuff                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsAppealAvoidBuffNoConsumption           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 IsAppealAvoidRateRef                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 033 IsNotGetNoNoctyl                         000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.Parameter                                 = (ParameterType)GetInt32(new IntPtr(p + 0x010)); // 02466AE49880 0x10 Parameter                   ( 00018672C810 ModelEnumType ParameterType ParameterType ParameterType Int32 )
            value.DeckCost                                  = (DeckCostType)GetInt32(new IntPtr(p + 0x014)); // 02466AE498A0 0x14 DeckCost                    ( 00018672C150 ModelEnumType DeckCostType DeckCostType DeckCostType Int32 )
            value.IsAppealMentalDamage                      = GetBool(new IntPtr(p + 0x018)); // 02466AE498C0 0x18 IsAppealMentalDamage        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealMentalRecovery                    = GetBool(new IntPtr(p + 0x019)); // 02466AE498E0 0x19 IsAppealMentalRecovery      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUp                       = GetBool(new IntPtr(p + 0x01A)); // 02466AE49900 0x1A IsAppealPointRateUp         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsBeforeUseProducePoint                   = GetBool(new IntPtr(p + 0x01B)); // 02466AE49920 0x1B IsBeforeUseProducePoint     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMentalGuard                             = GetBool(new IntPtr(p + 0x01C)); // 02466AE49940 0x1C IsMentalGuard               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsContinueAppeal                          = GetBool(new IntPtr(p + 0x01D)); // 02466AE49960 0x1D IsContinueAppeal            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFixValue                                = GetBool(new IntPtr(p + 0x01E)); // 02466AE49980 0x1E IsFixValue                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTime                                    = GetBool(new IntPtr(p + 0x01F)); // 02466AE499A0 0x1F IsTime                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNotGet                                  = GetBool(new IntPtr(p + 0x020)); // 02466AE499C0 0x20 IsNotGet                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMentalRecoveryOthers                    = GetBool(new IntPtr(p + 0x021)); // 02466AE499E0 0x21 IsMentalRecoveryOthers      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUpOthers                 = GetBool(new IntPtr(p + 0x022)); // 02466AE49A00 0x22 IsAppealPointRateUpOthers   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsRecoveryIdolSkillCountOthers            = GetBool(new IntPtr(p + 0x023)); // 02466AE49A20 0x23 IsRecoveryIdolSkillCountOthers ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSwapCardOthers                          = GetBool(new IntPtr(p + 0x024)); // 02466AE49A40 0x24 IsSwapCardOthers            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsGetMentalGuardOthers                    = GetBool(new IntPtr(p + 0x025)); // 02466AE49A60 0x25 IsGetMentalGuardOthers      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetOthers                            = GetBool(new IntPtr(p + 0x026)); // 02466AE49A80 0x26 IsNotGetOthers              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNoneEffectAvoid                         = GetBool(new IntPtr(p + 0x027)); // 02466AE49AA0 0x27 IsNoneEffectAvoid           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUpAvoid                  = GetBool(new IntPtr(p + 0x028)); // 02466AE49AC0 0x28 IsAppealPointRateUpAvoid    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMentalDamageUpAvoid                     = GetBool(new IntPtr(p + 0x029)); // 02466AE49AE0 0x29 IsMentalDamageUpAvoid       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAvoidCountRef                           = GetBool(new IntPtr(p + 0x02A)); // 02466AE49B00 0x2A IsAvoidCountRef             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMentalRecoveryAvoid                     = GetBool(new IntPtr(p + 0x02B)); // 02466AE49B20 0x2B IsMentalRecoveryAvoid       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetAvoid                             = GetBool(new IntPtr(p + 0x02C)); // 02466AE49B40 0x2C IsNotGetAvoid               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointRateUpAvoidBuff              = GetBool(new IntPtr(p + 0x02D)); // 02466AE49B60 0x2D IsAppealPointRateUpAvoidBuff ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointAvoidCountRateUpAvoidBuff    = GetBool(new IntPtr(p + 0x02E)); // 02466AE49B80 0x2E IsAppealPointAvoidCountRateUpAvoidBuff ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealPointAvoidBuffCountRateUpAvoidBuff = GetBool(new IntPtr(p + 0x02F)); // 02466AE49BA0 0x2F IsAppealPointAvoidBuffCountRateUpAvoidBuff ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetAvoidBuff                         = GetBool(new IntPtr(p + 0x030)); // 02466AE49BC0 0x30 IsNotGetAvoidBuff           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealAvoidBuffNoConsumption            = GetBool(new IntPtr(p + 0x031)); // 02466AE49BE0 0x31 IsAppealAvoidBuffNoConsumption ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAppealAvoidRateRef                      = GetBool(new IntPtr(p + 0x032)); // 02466AE49C00 0x32 IsAppealAvoidRateRef        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNotGetNoNoctyl                          = GetBool(new IntPtr(p + 0x033)); // 02466AE49C20 0x33 IsNotGetNoNoctyl            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
