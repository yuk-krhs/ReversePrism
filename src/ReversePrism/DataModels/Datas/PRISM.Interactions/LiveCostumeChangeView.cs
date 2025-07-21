using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolView                                 ModelClassType LiveCostumeChangeIdolView LiveCostumeChangeIdolView LiveCostumeChangeIdolView Pointer
    // 028 UiCharacterViewer                        ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 030 MainView                                 ModelClassType LiveCostumeChangeMainView LiveCostumeChangeMainView LiveCostumeChangeMainView Pointer
    // 038 PresetView                               ModelClassType LiveCostumePresetWindow LiveCostumePresetWindow LiveCostumePresetWindow Pointer
    // 040 CostumeSetListView                       ModelClassType CostumeSetListView CostumeSetListView CostumeSetListView Pointer
    // 048 CostumeGridView                          ModelClassType CostumeGridView CostumeGridView CostumeGridView Pointer
    // 050 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 058 Model                                    ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer
    public partial class LiveCostumeChangeView : DataModel
    {
        public LiveCostumeChangeIdolView?               IdolView                                { get; set; }
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public LiveCostumeChangeMainView?               MainView                                { get; set; }
        public LiveCostumePresetWindow?                 PresetView                              { get; set; }
        public CostumeSetListView?                      CostumeSetListView                      { get; set; }
        public CostumeGridView?                         CostumeGridView                         { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public LiveCostumeChangeModel?                  Model                                   { get; set; }

        public static LiveCostumeChangeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeView() { Pointer= p0 };

            value.IdolView                                  = GetObject<LiveCostumeChangeIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveCostumeChangeIdolView.FromPointer); // 0x20 IdolView                    ( ModelClassType LiveCostumeChangeIdolView LiveCostumeChangeIdolView LiveCostumeChangeIdolView Pointer )
            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x028), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0x28 UiCharacterViewer           ( ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.MainView                                  = GetObject<LiveCostumeChangeMainView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveCostumeChangeMainView.FromPointer); // 0x30 MainView                    ( ModelClassType LiveCostumeChangeMainView LiveCostumeChangeMainView LiveCostumeChangeMainView Pointer )
            value.PresetView                                = GetObject<LiveCostumePresetWindow>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveCostumePresetWindow.FromPointer); // 0x38 PresetView                  ( ModelClassType LiveCostumePresetWindow LiveCostumePresetWindow LiveCostumePresetWindow Pointer )
            value.CostumeSetListView                        = GetObject<CostumeSetListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeSetListView.FromPointer); // 0x40 CostumeSetListView          ( ModelClassType CostumeSetListView CostumeSetListView CostumeSetListView Pointer )
            value.CostumeGridView                           = GetObject<CostumeGridView>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeGridView.FromPointer); // 0x48 CostumeGridView             ( ModelClassType CostumeGridView CostumeGridView CostumeGridView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x50 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Model                                     = GetObject<LiveCostumeChangeModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveCostumeChangeModel.FromPointer); // 0x58 Model                       ( ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer )

            return value;
        }
    }
}
