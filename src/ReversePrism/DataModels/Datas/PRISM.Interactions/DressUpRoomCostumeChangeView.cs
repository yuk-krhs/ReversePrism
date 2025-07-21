using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgIdolRenderer                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 IdolIconView                             ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 030 IdolName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ClosedState                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 OpenState                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 NameArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 MvIdolNameOpenSize                       ModelPrimitiveType float float float Single
    // 058 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 OpenButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 CostumeIcons                             ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 070 TryOnModeToggle                          ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 078 ShowUnlockedCostumeOnlyToggle            ModelClassType Toggle Toggle Toggle Pointer
    // 080 CostumeTabGroup                          ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 088 CostumeCategoryText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 CostumeName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 OkButton                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A0 OpenPresetButton                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A8 OkButtonGrayOut                          ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0B0 PresetButtonGrayOut                      ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0B8 TryOnModeBackground                      ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 SetListView                              ModelClassType DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView Pointer
    // 0C8 PartsListView                            ModelClassType DressUpRoomCostumeListView DressUpRoomCostumeListView DressUpRoomCostumeListView Pointer
    // 0D0 UiCharacterViewer                        ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 0D8 BtnCostumeType                           ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 ImgInDress                               ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 ImgInCasual                              ModelClassType GameObject GameObject GameObject Pointer
    // 0F0 BtnBack                                  ModelClassType UIButton UIButton UIButton Pointer
    // 0F8 PresetView                               ModelClassType CostumePresetWindow CostumePresetWindow CostumePresetWindow Pointer
    // 100 costumeTabSubject                        Subject`1<CostumeCategory> IL2CPP_TYPE_GENERICINST
    // 108 ClosedStateSize                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 110 OpenStateSize                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 118 CurrentCostumeType                       ModelEnumType CostumeType CostumeType CostumeType Int32
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

        public static DressUpRoomCostumeChangeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeChangeView() { Pointer= p0 };

            value.CgIdolRenderer                            = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CgIdolRenderer              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IdolIconView                              = GetObject<PFIdolIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x28 IdolIconView                ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 IdolName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClosedState                               = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 ClosedState                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OpenState                                 = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 OpenState                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NameArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 NameArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.MvIdolNameOpenSize                        = GetSingle(new IntPtr(p + 0x050)); // 0x50 MvIdolNameOpenSize          ( ModelPrimitiveType float float float Single )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 OpenButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0x68 CostumeIcons                ( ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.TryOnModeToggle                           = GetObject<ToggleSwitch>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x70 TryOnModeToggle             ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowUnlockedCostumeOnlyToggle             = GetObject<Toggle>(new IntPtr(p + 0x078), ReversePrism.DataModels.Toggle.FromPointer); // 0x78 ShowUnlockedCostumeOnlyToggle ( ModelClassType Toggle Toggle Toggle Pointer )
            value.CostumeTabGroup                           = GetObject<UITabGroupEx>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x80 CostumeTabGroup             ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.CostumeCategoryText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 CostumeCategoryText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 CostumeName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OkButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x98 OkButton                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenPresetButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA0 OpenPresetButton            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OkButtonGrayOut                           = GetObject<UIGrayOutController>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0xA8 OkButtonGrayOut             ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.PresetButtonGrayOut                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0xB0 PresetButtonGrayOut         ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.TryOnModeBackground                       = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 TryOnModeBackground         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SetListView                               = GetObject<DressUpRoomCostumeSetListView>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.DressUpRoomCostumeSetListView.FromPointer); // 0xC0 SetListView                 ( ModelClassType DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView DressUpRoomCostumeSetListView Pointer )
            value.PartsListView                             = GetObject<DressUpRoomCostumeListView>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.DressUpRoomCostumeListView.FromPointer); // 0xC8 PartsListView               ( ModelClassType DressUpRoomCostumeListView DressUpRoomCostumeListView DressUpRoomCostumeListView Pointer )
            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0xD0 UiCharacterViewer           ( ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.BtnCostumeType                            = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0xD8 BtnCostumeType              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgInDress                                = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0xE0 ImgInDress                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgInCasual                               = GetObject<GameObject>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GameObject.FromPointer); // 0xE8 ImgInCasual                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnBack                                   = GetObject<UIButton>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UIButton.FromPointer); // 0xF0 BtnBack                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PresetView                                = GetObject<CostumePresetWindow>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CostumePresetWindow.FromPointer); // 0xF8 PresetView                  ( ModelClassType CostumePresetWindow CostumePresetWindow CostumePresetWindow Pointer )
            value.ClosedStateSize                           = (Vector2)GetInt32(new IntPtr(p + 0x108)); // 0x108 ClosedStateSize             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OpenStateSize                             = (Vector2)GetInt32(new IntPtr(p + 0x110)); // 0x110 OpenStateSize               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CurrentCostumeType                        = (CostumeType)GetInt32(new IntPtr(p + 0x118)); // 0x118 CurrentCostumeType          ( ModelEnumType CostumeType CostumeType CostumeType Int32 )

            return value;
        }
    }
}
