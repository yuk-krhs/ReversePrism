using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolView                                 000186547930 ModelClassType LiveCostumeChangeIdolView LiveCostumeChangeIdolView LiveCostumeChangeIdolView Pointer
    // 028 UiCharacterViewer                        0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 030 MainView                                 000186547E70 ModelClassType LiveCostumeChangeMainView LiveCostumeChangeMainView LiveCostumeChangeMainView Pointer
    // 038 PresetView                               00018654B270 ModelClassType LiveCostumePresetWindow LiveCostumePresetWindow LiveCostumePresetWindow Pointer
    // 040 CostumeSetListView                       000186633EA0 ModelClassType CostumeSetListView CostumeSetListView CostumeSetListView Pointer
    // 048 CostumeGridView                          00018662C860 ModelClassType CostumeGridView CostumeGridView CostumeGridView Pointer
    // 050 factory                                  PopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 058 TitleView                                0001865E9EF0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 060 Model                                    0001865483B0 ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer
    // 068 Argument                                 000186546A20 ModelClassType LiveCostumeChangeArgument LiveCostumeChangeArgument LiveCostumeChangeArgument Pointer
    public partial class LiveCostumeChangeView
    {
        public LiveCostumeChangeIdolView?               IdolView                                { get; set; }
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public LiveCostumeChangeMainView?               MainView                                { get; set; }
        public LiveCostumePresetWindow?                 PresetView                              { get; set; }
        public CostumeSetListView?                      CostumeSetListView                      { get; set; }
        public CostumeGridView?                         CostumeGridView                         { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public LiveCostumeChangeModel?                  Model                                   { get; set; }
        public LiveCostumeChangeArgument?               Argument                                { get; set; }

        public static LiveCostumeChangeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeView();

            value.IdolView                                  = GetObject<LiveCostumeChangeIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveCostumeChangeIdolView.FromPointer); // 0270DB3AFD68 0x20 IdolView                    ( 000186547930 ModelClassType LiveCostumeChangeIdolView LiveCostumeChangeIdolView LiveCostumeChangeIdolView Pointer )
            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x028), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0270DB3AFD88 0x28 UiCharacterViewer           ( 0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.MainView                                  = GetObject<LiveCostumeChangeMainView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveCostumeChangeMainView.FromPointer); // 0270DB3AFDA8 0x30 MainView                    ( 000186547E70 ModelClassType LiveCostumeChangeMainView LiveCostumeChangeMainView LiveCostumeChangeMainView Pointer )
            value.PresetView                                = GetObject<LiveCostumePresetWindow>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveCostumePresetWindow.FromPointer); // 0270DB3AFDC8 0x38 PresetView                  ( 00018654B270 ModelClassType LiveCostumePresetWindow LiveCostumePresetWindow LiveCostumePresetWindow Pointer )
            value.CostumeSetListView                        = GetObject<CostumeSetListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeSetListView.FromPointer); // 0270DB3AFDE8 0x40 CostumeSetListView          ( 000186633EA0 ModelClassType CostumeSetListView CostumeSetListView CostumeSetListView Pointer )
            value.CostumeGridView                           = GetObject<CostumeGridView>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeGridView.FromPointer); // 0270DB3AFE08 0x48 CostumeGridView             ( 00018662C860 ModelClassType CostumeGridView CostumeGridView CostumeGridView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB3AFE48 0x58 TitleView                   ( 0001865E9EF0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Model                                     = GetObject<LiveCostumeChangeModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveCostumeChangeModel.FromPointer); // 0270DB3AFE68 0x60 Model                       ( 0001865483B0 ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer )
            value.Argument                                  = GetObject<LiveCostumeChangeArgument>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveCostumeChangeArgument.FromPointer); // 0270DB3AFE88 0x68 Argument                    ( 000186546A20 ModelClassType LiveCostumeChangeArgument LiveCostumeChangeArgument LiveCostumeChangeArgument Pointer )

            return value;
        }
    }
}
