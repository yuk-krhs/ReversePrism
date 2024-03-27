using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865A3330 ModelClassType CharacterSelectView CharacterSelectView CharacterSelectView Pointer
    // 028 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 PiView                                   000186549360 ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer
    // 038 ScView                                   0001865DF050 ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer
    // 040 PiUpgradingButtonView                    00018670DF80 ModelClassType PIdolUpgradingButtonView PIdolUpgradingButtonView PIdolUpgradingButtonView Pointer
    // 048 ScUpgradingButtonView                    0001866AC700 ModelClassType SCharaUpgradingButtonView SCharaUpgradingButtonView SCharaUpgradingButtonView Pointer
    // 050 PIdolDetailPopupViewFactory              00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer
    // 058 PIdolSearchPopupViewFactory              00018654AD60 ModelClassType ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory Pointer
    // 060 SCharaDetailPopupViewFactory             0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer
    // 068 SCharaSearchPopupViewFactory             0001865E1C90 ModelClassType SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory Pointer
    public partial class CharacterSelectBuilder
    {
        public CharacterSelectView?                     View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ProduceIdolListView?                     PiView                                  { get; set; }
        public SupportCharaListView?                    ScView                                  { get; set; }
        public PIdolUpgradingButtonView?                PiUpgradingButtonView                   { get; set; }
        public SCharaUpgradingButtonView?               ScUpgradingButtonView                   { get; set; }
        public PIdolDetailPopupViewFactory?             PIdolDetailPopupViewFactory             { get; set; }
        public ProduceIdolSearchPopupViewFactory?       PIdolSearchPopupViewFactory             { get; set; }
        public SCharaDetailPopupViewFactory?            SCharaDetailPopupViewFactory            { get; set; }
        public SupportCharaSearchPopupViewFactory?      SCharaSearchPopupViewFactory            { get; set; }

        public static CharacterSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectBuilder();

            value.View                                      = GetObject<CharacterSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterSelectView.FromPointer); // 0270DB5E74D0 0x20 View                        ( 0001865A3330 ModelClassType CharacterSelectView CharacterSelectView CharacterSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB5E74F0 0x28 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<ProduceIdolListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolListView.FromPointer); // 0270DB5E7510 0x30 PiView                      ( 000186549360 ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer )
            value.ScView                                    = GetObject<SupportCharaListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaListView.FromPointer); // 0270DB5E7530 0x38 ScView                      ( 0001865DF050 ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer )
            value.PiUpgradingButtonView                     = GetObject<PIdolUpgradingButtonView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolUpgradingButtonView.FromPointer); // 0270DB5E7550 0x40 PiUpgradingButtonView       ( 00018670DF80 ModelClassType PIdolUpgradingButtonView PIdolUpgradingButtonView PIdolUpgradingButtonView Pointer )
            value.ScUpgradingButtonView                     = GetObject<SCharaUpgradingButtonView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaUpgradingButtonView.FromPointer); // 0270DB5E7570 0x48 ScUpgradingButtonView       ( 0001866AC700 ModelClassType SCharaUpgradingButtonView SCharaUpgradingButtonView SCharaUpgradingButtonView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 0270DB5E7590 0x50 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )
            value.PIdolSearchPopupViewFactory               = GetObject<ProduceIdolSearchPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceIdolSearchPopupViewFactory.FromPointer); // 0270DB5E75B0 0x58 PIdolSearchPopupViewFactory ( 00018654AD60 ModelClassType ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 0270DB5E75D0 0x60 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )
            value.SCharaSearchPopupViewFactory              = GetObject<SupportCharaSearchPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportCharaSearchPopupViewFactory.FromPointer); // 0270DB5E75F0 0x68 SCharaSearchPopupViewFactory ( 0001865E1C90 ModelClassType SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory Pointer )

            return value;
        }
    }
}
