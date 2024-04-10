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
    public partial class CharacterSelectBuilder : DataModel
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
            var value   = new CharacterSelectBuilder() { Pointer= p0 };

            value.View                                      = GetObject<CharacterSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterSelectView.FromPointer); // 02466B66B790 0x20 View                        ( 0001865A3330 ModelClassType CharacterSelectView CharacterSelectView CharacterSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B66B7B0 0x28 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<ProduceIdolListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolListView.FromPointer); // 02466B66B7D0 0x30 PiView                      ( 000186549360 ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer )
            value.ScView                                    = GetObject<SupportCharaListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaListView.FromPointer); // 02466B66B7F0 0x38 ScView                      ( 0001865DF050 ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer )
            value.PiUpgradingButtonView                     = GetObject<PIdolUpgradingButtonView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolUpgradingButtonView.FromPointer); // 02466B66B810 0x40 PiUpgradingButtonView       ( 00018670DF80 ModelClassType PIdolUpgradingButtonView PIdolUpgradingButtonView PIdolUpgradingButtonView Pointer )
            value.ScUpgradingButtonView                     = GetObject<SCharaUpgradingButtonView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaUpgradingButtonView.FromPointer); // 02466B66B830 0x48 ScUpgradingButtonView       ( 0001866AC700 ModelClassType SCharaUpgradingButtonView SCharaUpgradingButtonView SCharaUpgradingButtonView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 02466B66B850 0x50 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )
            value.PIdolSearchPopupViewFactory               = GetObject<ProduceIdolSearchPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceIdolSearchPopupViewFactory.FromPointer); // 02466B66B870 0x58 PIdolSearchPopupViewFactory ( 00018654AD60 ModelClassType ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 02466B66B890 0x60 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )
            value.SCharaSearchPopupViewFactory              = GetObject<SupportCharaSearchPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportCharaSearchPopupViewFactory.FromPointer); // 02466B66B8B0 0x68 SCharaSearchPopupViewFactory ( 0001865E1C90 ModelClassType SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory Pointer )

            return value;
        }
    }
}
