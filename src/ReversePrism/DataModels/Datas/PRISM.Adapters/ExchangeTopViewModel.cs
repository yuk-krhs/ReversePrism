using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SaveData                                 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer
    // 018 TabDatas                                 ModelClassListType List`1<TabData> List`1<TabData> List<TabData> Pointer
    // 020 CurSelectTabData                         ModelClassType TabData TabData TabData Pointer
    // 028 SelectionTicketViewModels                ModelClassListType List`1<ExchangeLargeSpaceGoodsGridViewModel> List`1<ExchangeLargeSpaceGoodsGridViewModel> List<ExchangeLargeSpaceGoodsGridViewModel> Pointer
    // 030 EventGridViewModels                      ModelClassListType List`1<ExchangeEventGridViewModel> List`1<ExchangeEventGridViewModel> List<ExchangeEventGridViewModel> Pointer
    // 038 ExchangeSelectionListPopupViewModel      ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer
    // 040 CharacterEffectViewModel                 ModelClassType ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel Pointer
    // 048 HorizontalTabIndex                       ModelPrimitiveType int int int Int32
    // 04C MstProductId                             ModelPrimitiveType int int int Int32
    // 050 IsGoToOtherView                          ModelPrimitiveType bool bool bool Bool
    // 054 CurrentTab                               ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
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
        public int                                      MstProductId                            { get; set; }
        public bool                                     IsGoToOtherView                         { get; set; }
        public ExchangeTabType                          CurrentTab                              { get; set; }

        public static ExchangeTopViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeTopViewModel() { Pointer= p0 };

            value.SaveData                                  = GetObject<ExchangeSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeSaveData.FromPointer); // 0x10 SaveData                    ( ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer )
            value.TabDatas                                  = GetObjectList<TabData>(new IntPtr(p + 0x018), ReversePrism.DataModels.TabData.FromPointer); // 0x18 TabDatas                    ( ModelClassListType List`1<TabData> List`1<TabData> List<TabData> Pointer )
            value.CurSelectTabData                          = GetObject<TabData>(new IntPtr(p + 0x020), ReversePrism.DataModels.TabData.FromPointer); // 0x20 CurSelectTabData            ( ModelClassType TabData TabData TabData Pointer )
            value.SelectionTicketViewModels                 = GetObjectList<ExchangeLargeSpaceGoodsGridViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeLargeSpaceGoodsGridViewModel.FromPointer); // 0x28 SelectionTicketViewModels   ( ModelClassListType List`1<ExchangeLargeSpaceGoodsGridViewModel> List`1<ExchangeLargeSpaceGoodsGridViewModel> List<ExchangeLargeSpaceGoodsGridViewModel> Pointer )
            value.EventGridViewModels                       = GetObjectList<ExchangeEventGridViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExchangeEventGridViewModel.FromPointer); // 0x30 EventGridViewModels         ( ModelClassListType List`1<ExchangeEventGridViewModel> List`1<ExchangeEventGridViewModel> List<ExchangeEventGridViewModel> Pointer )
            value.ExchangeSelectionListPopupViewModel       = GetObject<ExchangeSelectionListPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExchangeSelectionListPopupViewModel.FromPointer); // 0x38 ExchangeSelectionListPopupViewModel ( ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer )
            value.CharacterEffectViewModel                  = GetObject<ExchangeCharacterEffectViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeCharacterEffectViewModel.FromPointer); // 0x40 CharacterEffectViewModel    ( ModelClassType ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel ExchangeCharacterEffectViewModel Pointer )
            value.HorizontalTabIndex                        = GetInt32(new IntPtr(p + 0x048)); // 0x48 HorizontalTabIndex          ( ModelPrimitiveType int int int Int32 )
            value.MstProductId                              = GetInt32(new IntPtr(p + 0x04C)); // 0x4C MstProductId                ( ModelPrimitiveType int int int Int32 )
            value.IsGoToOtherView                           = GetBool(new IntPtr(p + 0x050)); // 0x50 IsGoToOtherView             ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentTab                                = (ExchangeTabType)GetInt32(new IntPtr(p + 0x054)); // 0x54 CurrentTab                  ( ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
