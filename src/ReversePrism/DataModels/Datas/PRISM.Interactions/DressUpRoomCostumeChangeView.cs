using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgIdolRenderer                           000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 IdolIconView                             000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 030 IdolName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ClosedState                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 OpenState                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 NameArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 MvIdolNameOpenSize                       0001866656B0 ModelPrimitiveType float float float Single
    // 058 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 OpenButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 CostumeIcons                             000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 070 TryOnModeToggle                          0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 078 ShowUnlockedCostumeOnlyToggle            000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 080 CostumeTabGroup                          0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 088 CostumeCategoryText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 CostumeName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 OkButton                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A0 OpenPresetButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A8 OkButtonGrayOut                          0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0B0 PresetButtonGrayOut                      0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0B8 TryOnModeBackground                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 SetListView                              0001866FFB50 ModelClassType DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView Pointer
    // 0C8 PartsListView                            0001866FF150 ModelClassType DressUpRoomCostumeListView DressUpRoomCostumeListView DressUpRoomCostumeListView Pointer
    // 0D0 UiCharacterViewer                        0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 0D8 BtnCostumeType                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 ImgInDress                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 ImgInCasual                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0F0 BtnBack                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0F8 PresetView                               000186631210 ModelClassType CostumePresetWindow CostumePresetWindow CostumePresetWindow Pointer
    // 100 costumeTabSubject                        Subject`1<CostumeCategory> IL2CPP_TYPE_GENERICINST
    // 108 ClosedStateSize                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 110 OpenStateSize                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 118 CurrentCostumeType                       0001865EEA20 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 120 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class DressUpRoomCostumeChangeView : DataModel
    {
        public CanvasGroup?                             CgIdolRenderer                          { get; set; }
        public PFIdolIconView?                          IdolIconView                            { get; set; }
        public UITextMeshProUGUI?                       IdolName                                { get; set; }
        public RectTransform?                           ClosedState                             { get; set; }
        public RectTransform?                           OpenState                               { get; set; }
        public RectTransform?                           NameArea                                { get; set; }
        public float                                    MvIdolNameOpenSize                      { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public ButtonBase?                              OpenButton                              { get; set; }
        public List<CostumeIcon>?                       CostumeIcons                            { get; set; }
        public ToggleSwitch?                            TryOnModeToggle                         { get; set; }
        public Toggle?                                  ShowUnlockedCostumeOnlyToggle           { get; set; }
        public UITabGroupEx?                            CostumeTabGroup                         { get; set; }
        public UITextMeshProUGUI?                       CostumeCategoryText                     { get; set; }
        public UITextMeshProUGUI?                       CostumeName                             { get; set; }
        public ButtonBase?                              OkButton                                { get; set; }
        public ButtonBase?                              OpenPresetButton                        { get; set; }
        public UIGrayOutController?                     OkButtonGrayOut                         { get; set; }
        public UIGrayOutController?                     PresetButtonGrayOut                     { get; set; }
        public GameObject?                              TryOnModeBackground                     { get; set; }
        public DressUpRoomCostumeSetListView?           SetListView                             { get; set; }
        public DressUpRoomCostumeListView?              PartsListView                           { get; set; }
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public UIButton?                                BtnCostumeType                          { get; set; }
        public GameObject?                              ImgInDress                              { get; set; }
        public GameObject?                              ImgInCasual                             { get; set; }
        public UIButton?                                BtnBack                                 { get; set; }
        public CostumePresetWindow?                     PresetView                              { get; set; }
        public Vector2                                  ClosedStateSize                         { get; set; }
        public Vector2                                  OpenStateSize                           { get; set; }
        public CostumeType                              CurrentCostumeType                      { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static DressUpRoomCostumeChangeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeChangeView() { Pointer= p0 };

            value.CgIdolRenderer                            = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B6D1EC0 0x20 CgIdolRenderer              ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IdolIconView                              = GetObject<PFIdolIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 02466B6D1EE0 0x28 IdolIconView                ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6D1F00 0x30 IdolName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClosedState                               = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B6D1F20 0x38 ClosedState                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OpenState                                 = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B6D1F40 0x40 OpenState                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NameArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B6D1F60 0x48 NameArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.MvIdolNameOpenSize                        = GetSingle(new IntPtr(p + 0x050)); // 02466B6D1F80 0x50 MvIdolNameOpenSize          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B6D1FA0 0x58 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B6D1FC0 0x60 OpenButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeIcon.FromPointer); // 02466B6D1FE0 0x68 CostumeIcons                ( 000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.TryOnModeToggle                           = GetObject<ToggleSwitch>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B6D2000 0x70 TryOnModeToggle             ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowUnlockedCostumeOnlyToggle             = GetObject<Toggle>(new IntPtr(p + 0x078), ReversePrism.DataModels.Toggle.FromPointer); // 02466B6D2020 0x78 ShowUnlockedCostumeOnlyToggle ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.CostumeTabGroup                           = GetObject<UITabGroupEx>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 02466B6D2040 0x80 CostumeTabGroup             ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.CostumeCategoryText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6D2060 0x88 CostumeCategoryText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6D2080 0x90 CostumeName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OkButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B6D20A0 0x98 OkButton                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenPresetButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B6D20C0 0xA0 OpenPresetButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OkButtonGrayOut                           = GetObject<UIGrayOutController>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466B6D20E0 0xA8 OkButtonGrayOut             ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.PresetButtonGrayOut                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466B6D2100 0xB0 PresetButtonGrayOut         ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.TryOnModeBackground                       = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 02466B6D2120 0xB8 TryOnModeBackground         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SetListView                               = GetObject<DressUpRoomCostumeSetListView>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.DressUpRoomCostumeSetListView.FromPointer); // 02466B6D2140 0xC0 SetListView                 ( 0001866FFB50 ModelClassType DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView Pointer )
            value.PartsListView                             = GetObject<DressUpRoomCostumeListView>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.DressUpRoomCostumeListView.FromPointer); // 02466B6D2160 0xC8 PartsListView               ( 0001866FF150 ModelClassType DressUpRoomCostumeListView DressUpRoomCostumeListView DressUpRoomCostumeListView Pointer )
            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 02466B6D2180 0xD0 UiCharacterViewer           ( 0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.BtnCostumeType                            = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6D21A0 0xD8 BtnCostumeType              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgInDress                                = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 02466B6D21C0 0xE0 ImgInDress                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgInCasual                               = GetObject<GameObject>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GameObject.FromPointer); // 02466B6D21E0 0xE8 ImgInCasual                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnBack                                   = GetObject<UIButton>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6D2200 0xF0 BtnBack                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PresetView                                = GetObject<CostumePresetWindow>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CostumePresetWindow.FromPointer); // 02466B6D2220 0xF8 PresetView                  ( 000186631210 ModelClassType CostumePresetWindow CostumePresetWindow CostumePresetWindow Pointer )
            value.ClosedStateSize                           = (Vector2)GetInt32(new IntPtr(p + 0x108)); // 02466B6D2260 0x108 ClosedStateSize             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OpenStateSize                             = (Vector2)GetInt32(new IntPtr(p + 0x110)); // 02466B6D2280 0x110 OpenStateSize               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CurrentCostumeType                        = (CostumeType)GetInt32(new IntPtr(p + 0x118)); // 02466B6D22A0 0x118 CurrentCostumeType          ( 0001865EEA20 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x120), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B6D22C0 0x120 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
