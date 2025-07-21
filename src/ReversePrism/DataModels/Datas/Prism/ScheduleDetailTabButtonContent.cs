using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 028 LvBaseImage                              ModelClassType UIImage UIImage UIImage Pointer
    // 030 RecommendObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 038 SupportCharacterAreaObject               ModelClassType GameObject GameObject GameObject Pointer
    // 040 SupportCharacterSDIconContentList        ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 048 SelectedLabelText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SelectedScheduleLevelParentObject        ModelClassType GameObject GameObject GameObject Pointer
    // 058 SelectedScheduleLevelObject              ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectedScheduleSupportLevelObject       ModelClassType GameObject GameObject GameObject Pointer
    // 068 SelectedScheduleLevelText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 SelectedScheduleSupportLevelText         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ActivateTabObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 080 SupportBonusObject                       ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleDetailTabButtonContent : DataModel
    {
        public UIImage?                                 BaseImage                               { get; set; }
        public UIImage?                                 LvBaseImage                             { get; set; }
        public GameObject?                              RecommendObject                         { get; set; }
        public GameObject?                              SupportCharacterAreaObject              { get; set; }
        public List<SupportCharacterSDIconContent>?     SupportCharacterSDIconContentList       { get; set; }
        public UITextMeshProUGUI?                       SelectedLabelText                       { get; set; }
        public GameObject?                              SelectedScheduleLevelParentObject       { get; set; }
        public GameObject?                              SelectedScheduleLevelObject             { get; set; }
        public GameObject?                              SelectedScheduleSupportLevelObject      { get; set; }
        public UITextMeshProUGUI?                       SelectedScheduleLevelText               { get; set; }
        public UITextMeshProUGUI?                       SelectedScheduleSupportLevelText        { get; set; }
        public GameObject?                              ActivateTabObject                       { get; set; }
        public GameObject?                              SupportBonusObject                      { get; set; }

        public static ScheduleDetailTabButtonContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailTabButtonContent() { Pointer= p0 };

            value.BaseImage                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BaseImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.LvBaseImage                               = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 LvBaseImage                 ( ModelClassType UIImage UIImage UIImage Pointer )
            value.RecommendObject                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 RecommendObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SupportCharacterAreaObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 0x40 SupportCharacterSDIconContentList ( ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.SelectedLabelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 SelectedLabelText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedScheduleLevelParentObject         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SelectedScheduleLevelParentObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedScheduleLevelObject               = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 SelectedScheduleLevelObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedScheduleSupportLevelObject        = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 SelectedScheduleSupportLevelObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedScheduleLevelText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 SelectedScheduleLevelText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedScheduleSupportLevelText          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 SelectedScheduleSupportLevelText ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActivateTabObject                         = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 ActivateTabObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportBonusObject                        = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 SupportBonusObject          ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
