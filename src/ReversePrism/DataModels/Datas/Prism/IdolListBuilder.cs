using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001866B4D50 ModelClassType IdolListView IdolListView IdolListView Pointer
    // 028 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 PiView                                   000186549360 ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer
    // 038 ScView                                   0001865DF050 ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer
    // 040 FuView                                   000186569790 ModelClassType FesUnitListView FesUnitListView FesUnitListView Pointer
    // 048 FiView                                   000186562520 ModelClassType FesIdolListView FesIdolListView FesIdolListView Pointer
    // 050 PIdolDetailPopupViewFactory              00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer
    // 058 PIdolSearchPopupViewFactory              00018654AD60 ModelClassType ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory Pointer
    // 060 SCharaDetailPopupViewFactory             0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer
    // 068 SCharaSearchPopupViewFactory             0001865E1C90 ModelClassType SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory Pointer
    // 070 FUnitDetailPopupViewFactory              00018654A430 ModelClassType FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory Pointer
    // 078 FUnitSearchPopupViewFactory              00018656AE90 ModelClassType FesUnitSearchPopupViewFactory FesUnitSearchPopupViewFactory FesUnitSearchPopupViewFactory Pointer
    // 080 SelectFavoriteMarkPopupViewFactory       000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 088 FUnitTransferConfirmedPopupViewFactory   00018656F050 ModelClassType FesUnitTransferConfirmedPopupViewFactory FesUnitTransferConfirmedPopupViewFactory FesUnitTransferConfirmedPopupViewFactory Pointer
    // 090 FIdolDetailPopupViewFactory              000186543300 ModelClassType FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory Pointer
    // 098 FIdolSearchPopupViewFactory              000186563470 ModelClassType FesIdolSearchPopupViewFactory FesIdolSearchPopupViewFactory FesIdolSearchPopupViewFactory Pointer
    // 0A0 FIdolTransferConfirmedPopupViewFactory   000186566910 ModelClassType FesIdolTransferConfirmedPopupViewFactory FesIdolTransferConfirmedPopupViewFactory FesIdolTransferConfirmedPopupViewFactory Pointer
    // 0A8 FDataTransferCompletedPopupViewFactory   000186560260 ModelClassType FesDataTransferCompletedPopupViewFactory FesDataTransferCompletedPopupViewFactory FesDataTransferCompletedPopupViewFactory Pointer
    public partial class IdolListBuilder : DataModel
    {
        public IdolListView?                            View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ProduceIdolListView?                     PiView                                  { get; set; }
        public SupportCharaListView?                    ScView                                  { get; set; }
        public FesUnitListView?                         FuView                                  { get; set; }
        public FesIdolListView?                         FiView                                  { get; set; }
        public PIdolDetailPopupViewFactory?             PIdolDetailPopupViewFactory             { get; set; }
        public ProduceIdolSearchPopupViewFactory?       PIdolSearchPopupViewFactory             { get; set; }
        public SCharaDetailPopupViewFactory?            SCharaDetailPopupViewFactory            { get; set; }
        public SupportCharaSearchPopupViewFactory?      SCharaSearchPopupViewFactory            { get; set; }
        public FUnitDetailPopupViewFactory?             FUnitDetailPopupViewFactory             { get; set; }
        public FesUnitSearchPopupViewFactory?           FUnitSearchPopupViewFactory             { get; set; }
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public FesUnitTransferConfirmedPopupViewFactory? FUnitTransferConfirmedPopupViewFactory  { get; set; }
        public FIdolDetailPopupViewFactory?             FIdolDetailPopupViewFactory             { get; set; }
        public FesIdolSearchPopupViewFactory?           FIdolSearchPopupViewFactory             { get; set; }
        public FesIdolTransferConfirmedPopupViewFactory? FIdolTransferConfirmedPopupViewFactory  { get; set; }
        public FesDataTransferCompletedPopupViewFactory? FDataTransferCompletedPopupViewFactory  { get; set; }

        public static IdolListBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListBuilder() { Pointer= p0 };

            value.View                                      = GetObject<IdolListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolListView.FromPointer); // 02466B670D60 0x20 View                        ( 0001866B4D50 ModelClassType IdolListView IdolListView IdolListView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B670D80 0x28 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<ProduceIdolListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolListView.FromPointer); // 02466B670DA0 0x30 PiView                      ( 000186549360 ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer )
            value.ScView                                    = GetObject<SupportCharaListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaListView.FromPointer); // 02466B670DC0 0x38 ScView                      ( 0001865DF050 ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer )
            value.FuView                                    = GetObject<FesUnitListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesUnitListView.FromPointer); // 02466B670DE0 0x40 FuView                      ( 000186569790 ModelClassType FesUnitListView FesUnitListView FesUnitListView Pointer )
            value.FiView                                    = GetObject<FesIdolListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesIdolListView.FromPointer); // 02466B670E00 0x48 FiView                      ( 000186562520 ModelClassType FesIdolListView FesIdolListView FesIdolListView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 02466B670E20 0x50 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )
            value.PIdolSearchPopupViewFactory               = GetObject<ProduceIdolSearchPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceIdolSearchPopupViewFactory.FromPointer); // 02466B670E40 0x58 PIdolSearchPopupViewFactory ( 00018654AD60 ModelClassType ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory ProduceIdolSearchPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 02466B670E60 0x60 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )
            value.SCharaSearchPopupViewFactory              = GetObject<SupportCharaSearchPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportCharaSearchPopupViewFactory.FromPointer); // 02466B670E80 0x68 SCharaSearchPopupViewFactory ( 0001865E1C90 ModelClassType SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory SupportCharaSearchPopupViewFactory Pointer )
            value.FUnitDetailPopupViewFactory               = GetObject<FUnitDetailPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.FUnitDetailPopupViewFactory.FromPointer); // 02466B670EA0 0x70 FUnitDetailPopupViewFactory ( 00018654A430 ModelClassType FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory Pointer )
            value.FUnitSearchPopupViewFactory               = GetObject<FesUnitSearchPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.FesUnitSearchPopupViewFactory.FromPointer); // 02466B670EC0 0x78 FUnitSearchPopupViewFactory ( 00018656AE90 ModelClassType FesUnitSearchPopupViewFactory FesUnitSearchPopupViewFactory FesUnitSearchPopupViewFactory Pointer )
            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 02466B670EE0 0x80 SelectFavoriteMarkPopupViewFactory ( 000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.FUnitTransferConfirmedPopupViewFactory    = GetObject<FesUnitTransferConfirmedPopupViewFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.FesUnitTransferConfirmedPopupViewFactory.FromPointer); // 02466B670F00 0x88 FUnitTransferConfirmedPopupViewFactory ( 00018656F050 ModelClassType FesUnitTransferConfirmedPopupViewFactory FesUnitTransferConfirmedPopupViewFactory FesUnitTransferConfirmedPopupViewFactory Pointer )
            value.FIdolDetailPopupViewFactory               = GetObject<FIdolDetailPopupViewFactory>(new IntPtr(p + 0x090), ReversePrism.DataModels.FIdolDetailPopupViewFactory.FromPointer); // 02466B670F20 0x90 FIdolDetailPopupViewFactory ( 000186543300 ModelClassType FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory Pointer )
            value.FIdolSearchPopupViewFactory               = GetObject<FesIdolSearchPopupViewFactory>(new IntPtr(p + 0x098), ReversePrism.DataModels.FesIdolSearchPopupViewFactory.FromPointer); // 02466B670F40 0x98 FIdolSearchPopupViewFactory ( 000186563470 ModelClassType FesIdolSearchPopupViewFactory FesIdolSearchPopupViewFactory FesIdolSearchPopupViewFactory Pointer )
            value.FIdolTransferConfirmedPopupViewFactory    = GetObject<FesIdolTransferConfirmedPopupViewFactory>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FesIdolTransferConfirmedPopupViewFactory.FromPointer); // 02466B670F60 0xA0 FIdolTransferConfirmedPopupViewFactory ( 000186566910 ModelClassType FesIdolTransferConfirmedPopupViewFactory FesIdolTransferConfirmedPopupViewFactory FesIdolTransferConfirmedPopupViewFactory Pointer )
            value.FDataTransferCompletedPopupViewFactory    = GetObject<FesDataTransferCompletedPopupViewFactory>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FesDataTransferCompletedPopupViewFactory.FromPointer); // 02466B670F80 0xA8 FDataTransferCompletedPopupViewFactory ( 000186560260 ModelClassType FesDataTransferCompletedPopupViewFactory FesDataTransferCompletedPopupViewFactory FesDataTransferCompletedPopupViewFactory Pointer )

            return value;
        }
    }
}
