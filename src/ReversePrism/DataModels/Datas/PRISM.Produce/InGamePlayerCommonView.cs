using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GaugeAnimationTime                       ModelPrimitiveType float float float Single
    // 028 AppealGauge                              ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer
    // 030 MentalGauge                              ModelClassType MentalGaugeContent MentalGaugeContent MentalGaugeContent Pointer
    // 038 MentalGuard                              ModelClassType MentalGuardContent MentalGuardContent MentalGuardContent Pointer
    // 040 AvoidRate                                ModelClassType EvasionRateContent EvasionRateContent EvasionRateContent Pointer
    // 048 AvoidEffectContent                       ModelClassType AvoidEffectContent AvoidEffectContent AvoidEffectContent Pointer
    // 050 BuffDebuffContent                        ModelClassType BuffDebuffContent BuffDebuffContent BuffDebuffContent Pointer
    // 058 ProducePoint                             ModelClassType ProducePointContent ProducePointContent ProducePointContent Pointer
    // 060 CardAndSkillEffectController             ModelClassType UsePCardAndSkillEffectController UsePCardAndSkillEffectController UsePCardAndSkillEffectController Pointer
    public partial class InGamePlayerCommonView : DataModel
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
            var value   = new InGamePlayerCommonView() { Pointer= p0 };

            value.GaugeAnimationTime                        = GetSingle(new IntPtr(p + 0x020)); // 0x20 GaugeAnimationTime          ( ModelPrimitiveType float float float Single )
            value.AppealGauge                               = GetObject<AppealPointGaugeContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AppealPointGaugeContent.FromPointer); // 0x28 AppealGauge                 ( ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer )
            value.MentalGauge                               = GetObject<MentalGaugeContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.MentalGaugeContent.FromPointer); // 0x30 MentalGauge                 ( ModelClassType MentalGaugeContent MentalGaugeContent MentalGaugeContent Pointer )
            value.MentalGuard                               = GetObject<MentalGuardContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.MentalGuardContent.FromPointer); // 0x38 MentalGuard                 ( ModelClassType MentalGuardContent MentalGuardContent MentalGuardContent Pointer )
            value.AvoidRate                                 = GetObject<EvasionRateContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.EvasionRateContent.FromPointer); // 0x40 AvoidRate                   ( ModelClassType EvasionRateContent EvasionRateContent EvasionRateContent Pointer )
            value.AvoidEffectContent                        = GetObject<AvoidEffectContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.AvoidEffectContent.FromPointer); // 0x48 AvoidEffectContent          ( ModelClassType AvoidEffectContent AvoidEffectContent AvoidEffectContent Pointer )
            value.BuffDebuffContent                         = GetObject<BuffDebuffContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.BuffDebuffContent.FromPointer); // 0x50 BuffDebuffContent           ( ModelClassType BuffDebuffContent BuffDebuffContent BuffDebuffContent Pointer )
            value.ProducePoint                              = GetObject<ProducePointContent>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProducePointContent.FromPointer); // 0x58 ProducePoint                ( ModelClassType ProducePointContent ProducePointContent ProducePointContent Pointer )
            value.CardAndSkillEffectController              = GetObject<UsePCardAndSkillEffectController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UsePCardAndSkillEffectController.FromPointer); // 0x60 CardAndSkillEffectController ( ModelClassType UsePCardAndSkillEffectController UsePCardAndSkillEffectController UsePCardAndSkillEffectController Pointer )

            return value;
        }
    }
}
