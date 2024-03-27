using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolStatus                               0001867209A0 ModelClassType IChallengeTourIdolStatus IChallengeTourIdolStatus IChallengeTourIdolStatus Pointer
    // 018 ProduceIdol                              0001865EB0E0 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 020 PIdolIcon                                00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 028 IdolSkill                                0001865780F0 ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    // 030 VoDaViMeParameter                        0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 038 BaseParameter                            000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 040 ParameterDetailViewModel                 000186705CD0 ModelClassType PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel Pointer
    public partial class ChallengeTourPIdolUnitViewModel
    {
        public IChallengeTourIdolStatus?                IdolStatus                              { get; set; }
        public IProduceIdolStatus?                      ProduceIdol                             { get; set; }
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public IIdolSkillStatus?                        IdolSkill                               { get; set; }
        public IProduceParameterStatus?                 VoDaViMeParameter                       { get; set; }
        public IIdolParameterStatus?                    BaseParameter                           { get; set; }
        public PFIdolParameterDetailPopupViewModel?     ParameterDetailViewModel                { get; set; }

        public static ChallengeTourPIdolUnitViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolUnitViewModel();

            value.IdolStatus                                = GetObject<IChallengeTourIdolStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourIdolStatus.FromPointer); // 0270D649A598 0x10 IdolStatus                  ( 0001867209A0 ModelClassType IChallengeTourIdolStatus IChallengeTourIdolStatus IChallengeTourIdolStatus Pointer )
            value.ProduceIdol                               = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0270D649A5B8 0x18 ProduceIdol                 ( 0001865EB0E0 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0270D649A5D8 0x20 PIdolIcon                   ( 00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.IdolSkill                                 = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0270D649A5F8 0x28 IdolSkill                   ( 0001865780F0 ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )
            value.VoDaViMeParameter                         = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D649A618 0x30 VoDaViMeParameter           ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.BaseParameter                             = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0270D649A638 0x38 BaseParameter               ( 000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.ParameterDetailViewModel                  = GetObject<PFIdolParameterDetailPopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolParameterDetailPopupViewModel.FromPointer); // 0270D649A658 0x40 ParameterDetailViewModel    ( 000186705CD0 ModelClassType PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel Pointer )

            return value;
        }
    }
}
