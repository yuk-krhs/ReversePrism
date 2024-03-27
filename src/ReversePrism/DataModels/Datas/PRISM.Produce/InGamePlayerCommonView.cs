using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GaugeAnimationTime                       0001866656B0 ModelPrimitiveType float float float Single
    // 028 AppealGauge                              0001866CCFE0 ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer
    // 030 MentalGauge                              0001865FC110 ModelClassType MentalGaugeContent MentalGaugeContent MentalGaugeContent Pointer
    // 038 MentalGuard                              0001865FC590 ModelClassType MentalGuardContent MentalGuardContent MentalGuardContent Pointer
    // 040 AvoidRate                                00018674C470 ModelClassType EvasionRateContent EvasionRateContent EvasionRateContent Pointer
    // 048 AvoidEffectContent                       00018672C010 ModelClassType AvoidEffectContent AvoidEffectContent AvoidEffectContent Pointer
    // 050 BuffDebuffContent                        0001867794E0 ModelClassType BuffDebuffContent BuffDebuffContent BuffDebuffContent Pointer
    // 058 ProducePoint                             000186563700 ModelClassType ProducePointContent ProducePointContent ProducePointContent Pointer
    // 060 CardAndSkillEffectController             00018674A090 ModelClassType UsePCardAndSkillEffectController UsePCardAndSkillEffectController UsePCardAndSkillEffectController Pointer
    public partial class InGamePlayerCommonView
    {
        public float                                    GaugeAnimationTime                      { get; set; }
        public AppealPointGaugeContent?                 AppealGauge                             { get; set; }
        public MentalGaugeContent?                      MentalGauge                             { get; set; }
        public MentalGuardContent?                      MentalGuard                             { get; set; }
        public EvasionRateContent?                      AvoidRate                               { get; set; }
        public AvoidEffectContent?                      AvoidEffectContent                      { get; set; }
        public BuffDebuffContent?                       BuffDebuffContent                       { get; set; }
        public ProducePointContent?                     ProducePoint                            { get; set; }
        public UsePCardAndSkillEffectController?        CardAndSkillEffectController            { get; set; }

        public static InGamePlayerCommonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePlayerCommonView();

            value.GaugeAnimationTime                        = GetSingle(new IntPtr(p + 0x020)); // 0270D5BC8348 0x20 GaugeAnimationTime          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AppealGauge                               = GetObject<AppealPointGaugeContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AppealPointGaugeContent.FromPointer); // 0270D5BC8368 0x28 AppealGauge                 ( 0001866CCFE0 ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer )
            value.MentalGauge                               = GetObject<MentalGaugeContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.MentalGaugeContent.FromPointer); // 0270D5BC8388 0x30 MentalGauge                 ( 0001865FC110 ModelClassType MentalGaugeContent MentalGaugeContent MentalGaugeContent Pointer )
            value.MentalGuard                               = GetObject<MentalGuardContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.MentalGuardContent.FromPointer); // 0270D5BC83A8 0x38 MentalGuard                 ( 0001865FC590 ModelClassType MentalGuardContent MentalGuardContent MentalGuardContent Pointer )
            value.AvoidRate                                 = GetObject<EvasionRateContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.EvasionRateContent.FromPointer); // 0270D5BC83C8 0x40 AvoidRate                   ( 00018674C470 ModelClassType EvasionRateContent EvasionRateContent EvasionRateContent Pointer )
            value.AvoidEffectContent                        = GetObject<AvoidEffectContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.AvoidEffectContent.FromPointer); // 0270D5BC83E8 0x48 AvoidEffectContent          ( 00018672C010 ModelClassType AvoidEffectContent AvoidEffectContent AvoidEffectContent Pointer )
            value.BuffDebuffContent                         = GetObject<BuffDebuffContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.BuffDebuffContent.FromPointer); // 0270D5BC8408 0x50 BuffDebuffContent           ( 0001867794E0 ModelClassType BuffDebuffContent BuffDebuffContent BuffDebuffContent Pointer )
            value.ProducePoint                              = GetObject<ProducePointContent>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProducePointContent.FromPointer); // 0270D5BC8428 0x58 ProducePoint                ( 000186563700 ModelClassType ProducePointContent ProducePointContent ProducePointContent Pointer )
            value.CardAndSkillEffectController              = GetObject<UsePCardAndSkillEffectController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UsePCardAndSkillEffectController.FromPointer); // 0270D5BC8448 0x60 CardAndSkillEffectController ( 00018674A090 ModelClassType UsePCardAndSkillEffectController UsePCardAndSkillEffectController UsePCardAndSkillEffectController Pointer )

            return value;
        }
    }
}
