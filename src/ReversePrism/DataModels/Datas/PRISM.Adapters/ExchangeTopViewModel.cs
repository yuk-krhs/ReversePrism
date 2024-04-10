using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SaveData                                 000186516CF0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer
    // 018 TabDatas                                 000185D235F8 ModelClassListType List`1<TabData> List`1<TabData> List<TabData> Pointer
    // 020 CurSelectTabData                         00018665D310 ModelClassType TabData TabData TabData Pointer
    // 028 SelectionTicketViewModels                000185CDA9E8 ModelClassListType List`1<ExchangeLargeSpaceGoodsGridViewModel> List`1<ExchangeLargeSpaceGoodsGridViewModel> List<ExchangeLargeSpaceGoodsGridViewModel> Pointer
    // 030 EventGridViewModels                      000185CDA308 ModelClassListType List`1<ExchangeEventGridViewModel> List`1<ExchangeEventGridViewModel> List<ExchangeEventGridViewModel> Pointer
    // 038 ExchangeSelectionListPopupViewModel      00018651A2F0 ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer
    // 040 CharacterEffectViewModel                 000186774140 ModelClassType ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel Pointer
    // 048 HorizontalTabIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C IsGoToOtherView                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 CurrentTab                               000186640E10 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
    public partial class ExchangeTopViewModel : DataModel
    {
        public ExchangeSaveData?                        SaveData                                { get; set; }
        public List<TabData>?                           TabDatas                                { get; set; }
        public TabData?                                 CurSelectTabData                        { get; set; }
        public List<ExchangeLargeSpaceGoodsGridViewModel>? SelectionTicketViewModels               { get; set; }
        public List<ExchangeEventGridViewModel>?        EventGridViewModels                     { get; set; }
        public ExchangeSelectionListPopupViewModel?     ExchangeSelectionListPopupViewModel     { get; set; }
        public ExchangeCharacterEffectViewModel?        CharacterEffectViewModel                { get; set; }
        public int                                      HorizontalTabIndex                      { get; set; }
        public bool                                     IsGoToOtherView                         { get; set; }
        public ExchangeTabType                          CurrentTab                              { get; set; }

        public static ExchangeTopViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeTopViewModel() { Pointer= p0 };

            value.SaveData                                  = GetObject<ExchangeSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeSaveData.FromPointer); // 02466624E490 0x10 SaveData                    ( 000186516CF0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer )
            value.TabDatas                                  = GetObjectList<TabData>(new IntPtr(p + 0x018), ReversePrism.DataModels.TabData.FromPointer); // 02466624E4B0 0x18 TabDatas                    ( 000185D235F8 ModelClassListType List`1<TabData> List`1<TabData> List<TabData> Pointer )
            value.CurSelectTabData                          = GetObject<TabData>(new IntPtr(p + 0x020), ReversePrism.DataModels.TabData.FromPointer); // 02466624E4D0 0x20 CurSelectTabData            ( 00018665D310 ModelClassType TabData TabData TabData Pointer )
            value.SelectionTicketViewModels                 = GetObjectList<ExchangeLargeSpaceGoodsGridViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeLargeSpaceGoodsGridViewModel.FromPointer); // 02466624E4F0 0x28 SelectionTicketViewModels   ( 000185CDA9E8 ModelClassListType List`1<ExchangeLargeSpaceGoodsGridViewModel> List`1<ExchangeLargeSpaceGoodsGridViewModel> List<ExchangeLargeSpaceGoodsGridViewModel> Pointer )
            value.EventGridViewModels                       = GetObjectList<ExchangeEventGridViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExchangeEventGridViewModel.FromPointer); // 02466624E510 0x30 EventGridViewModels         ( 000185CDA308 ModelClassListType List`1<ExchangeEventGridViewModel> List`1<ExchangeEventGridViewModel> List<ExchangeEventGridViewModel> Pointer )
            value.ExchangeSelectionListPopupViewModel       = GetObject<ExchangeSelectionListPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExchangeSelectionListPopupViewModel.FromPointer); // 02466624E530 0x38 ExchangeSelectionListPopupViewModel ( 00018651A2F0 ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer )
            value.CharacterEffectViewModel                  = GetObject<ExchangeCharacterEffectViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeCharacterEffectViewModel.FromPointer); // 02466624E550 0x40 CharacterEffectViewModel    ( 000186774140 ModelClassType ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel Pointer )
            value.HorizontalTabIndex                        = GetInt32(new IntPtr(p + 0x048)); // 02466624E570 0x48 HorizontalTabIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsGoToOtherView                           = GetBool(new IntPtr(p + 0x04C)); // 02466624E590 0x4C IsGoToOtherView             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentTab                                = (ExchangeTabType)GetInt32(new IntPtr(p + 0x050)); // 02466624E5B0 0x50 CurrentTab                  ( 000186640E10 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
