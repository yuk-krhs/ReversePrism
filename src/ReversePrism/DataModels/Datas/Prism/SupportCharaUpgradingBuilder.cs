using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 View                                     ModelClassType SupportCharaUpgradingView SupportCharaUpgradingView SupportCharaUpgradingView Pointer
    // 030 StatusView                               ModelClassType SupportCharaStatusView SupportCharaStatusView SupportCharaStatusView Pointer
    // 038 TrainingView                             ModelClassType SupportCharaTrainingView SupportCharaTrainingView SupportCharaTrainingView Pointer
    // 040 MasterTrainingView                       ModelClassType SupportCharaMasterTrainingView SupportCharaMasterTrainingView SupportCharaMasterTrainingView Pointer
    public partial class SupportCharaUpgradingBuilder : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public SupportCharaUpgradingView?               View                                    { get; set; }
        public SupportCharaStatusView?                  StatusView                              { get; set; }
        public SupportCharaTrainingView?                TrainingView                            { get; set; }
        public SupportCharaMasterTrainingView?          MasterTrainingView                      { get; set; }

        public static SupportCharaUpgradingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingBuilder() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.View                                      = GetObject<SupportCharaUpgradingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharaUpgradingView.FromPointer); // 0x28 View                        ( ModelClassType SupportCharaUpgradingView SupportCharaUpgradingView SupportCharaUpgradingView Pointer )
            value.StatusView                                = GetObject<SupportCharaStatusView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharaStatusView.FromPointer); // 0x30 StatusView                  ( ModelClassType SupportCharaStatusView SupportCharaStatusView SupportCharaStatusView Pointer )
            value.TrainingView                              = GetObject<SupportCharaTrainingView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaTrainingView.FromPointer); // 0x38 TrainingView                ( ModelClassType SupportCharaTrainingView SupportCharaTrainingView SupportCharaTrainingView Pointer )
            value.MasterTrainingView                        = GetObject<SupportCharaMasterTrainingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharaMasterTrainingView.FromPointer); // 0x40 MasterTrainingView          ( ModelClassType SupportCharaMasterTrainingView SupportCharaMasterTrainingView SupportCharaMasterTrainingView Pointer )

            return value;
        }
    }
}
