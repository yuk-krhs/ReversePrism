using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 View                                     0001865E85C0 ModelClassType SupportCharaUpgradingView SupportCharaUpgradingView SupportCharaUpgradingView Pointer
    // 030 StatusView                               0001865E33C0 ModelClassType SupportCharaStatusView SupportCharaStatusView SupportCharaStatusView Pointer
    // 038 TrainingView                             0001865E5410 ModelClassType SupportCharaTrainingView SupportCharaTrainingView SupportCharaTrainingView Pointer
    // 040 MasterTrainingView                       0001865E0C60 ModelClassType SupportCharaMasterTrainingView SupportCharaMasterTrainingView SupportCharaMasterTrainingView Pointer
    // 048 SCharaDetailPopupViewFactory             0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer
    // 050 SelectFavoriteMarkPopupViewFactory       000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 058 ScTrainingExecutionConfirmedPopupViewFactory 0001866A27A0 ModelClassType SCTrainingExecutionConfirmedPopupViewFactory SCTrainingExecutionConfirmedPopupViewFactory SCTrainingExecutionConfirmedPopupViewFactory Pointer
    // 060 SupportCharaLvUpCompletedPopupViewFactory 0001865DFE20 ModelClassType SupportCharaLvUpCompletedPopupViewFactory SupportCharaLvUpCompletedPopupViewFactory SupportCharaLvUpCompletedPopupViewFactory Pointer
    // 068 MasterTrainingExecutionConfirmedPopupViewFactory 0001865DA760 ModelClassType MasterTrainingExecutionConfirmedPopupViewFactory MasterTrainingExecutionConfirmedPopupViewFactory MasterTrainingExecutionConfirmedPopupViewFactory Pointer
    public partial class SupportCharaUpgradingBuilder
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public SupportCharaUpgradingView?               View                                    { get; set; }
        public SupportCharaStatusView?                  StatusView                              { get; set; }
        public SupportCharaTrainingView?                TrainingView                            { get; set; }
        public SupportCharaMasterTrainingView?          MasterTrainingView                      { get; set; }
        public SCharaDetailPopupViewFactory?            SCharaDetailPopupViewFactory            { get; set; }
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public SCTrainingExecutionConfirmedPopupViewFactory? ScTrainingExecutionConfirmedPopupViewFactory { get; set; }
        public SupportCharaLvUpCompletedPopupViewFactory? SupportCharaLvUpCompletedPopupViewFactory { get; set; }
        public MasterTrainingExecutionConfirmedPopupViewFactory? MasterTrainingExecutionConfirmedPopupViewFactory { get; set; }

        public static SupportCharaUpgradingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingBuilder();

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB60E7D0 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.View                                      = GetObject<SupportCharaUpgradingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharaUpgradingView.FromPointer); // 0270DB60E7F0 0x28 View                        ( 0001865E85C0 ModelClassType SupportCharaUpgradingView SupportCharaUpgradingView SupportCharaUpgradingView Pointer )
            value.StatusView                                = GetObject<SupportCharaStatusView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharaStatusView.FromPointer); // 0270DB60E810 0x30 StatusView                  ( 0001865E33C0 ModelClassType SupportCharaStatusView SupportCharaStatusView SupportCharaStatusView Pointer )
            value.TrainingView                              = GetObject<SupportCharaTrainingView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaTrainingView.FromPointer); // 0270DB60E830 0x38 TrainingView                ( 0001865E5410 ModelClassType SupportCharaTrainingView SupportCharaTrainingView SupportCharaTrainingView Pointer )
            value.MasterTrainingView                        = GetObject<SupportCharaMasterTrainingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharaMasterTrainingView.FromPointer); // 0270DB60E850 0x40 MasterTrainingView          ( 0001865E0C60 ModelClassType SupportCharaMasterTrainingView SupportCharaMasterTrainingView SupportCharaMasterTrainingView Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 0270DB60E870 0x48 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )
            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 0270DB60E890 0x50 SelectFavoriteMarkPopupViewFactory ( 000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.ScTrainingExecutionConfirmedPopupViewFactory = GetObject<SCTrainingExecutionConfirmedPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.SCTrainingExecutionConfirmedPopupViewFactory.FromPointer); // 0270DB60E8B0 0x58 ScTrainingExecutionConfirmedPopupViewFactory ( 0001866A27A0 ModelClassType SCTrainingExecutionConfirmedPopupViewFactory SCTrainingExecutionConfirmedPopupViewFactory SCTrainingExecutionConfirmedPopupViewFactory Pointer )
            value.SupportCharaLvUpCompletedPopupViewFactory = GetObject<SupportCharaLvUpCompletedPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportCharaLvUpCompletedPopupViewFactory.FromPointer); // 0270DB60E8D0 0x60 SupportCharaLvUpCompletedPopupViewFactory ( 0001865DFE20 ModelClassType SupportCharaLvUpCompletedPopupViewFactory SupportCharaLvUpCompletedPopupViewFactory SupportCharaLvUpCompletedPopupViewFactory Pointer )
            value.MasterTrainingExecutionConfirmedPopupViewFactory = GetObject<MasterTrainingExecutionConfirmedPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.MasterTrainingExecutionConfirmedPopupViewFactory.FromPointer); // 0270DB60E8F0 0x68 MasterTrainingExecutionConfirmedPopupViewFactory ( 0001865DA760 ModelClassType MasterTrainingExecutionConfirmedPopupViewFactory MasterTrainingExecutionConfirmedPopupViewFactory MasterTrainingExecutionConfirmedPopupViewFactory Pointer )

            return value;
        }
    }
}
