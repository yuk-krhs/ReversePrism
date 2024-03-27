using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 LvBaseImage                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 RecommendObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 SupportCharacterAreaObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 SupportCharacterSDIconContentList        000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 048 SelectedLabelText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SelectedScheduleLevelParentObject        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 SelectedScheduleLevelObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectedScheduleSupportLevelObject       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 SelectedScheduleLevelText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 SelectedScheduleSupportLevelText         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ActivateTabObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 SupportBonusObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleDetailTabButtonContent
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
            var value   = new ScheduleDetailTabButtonContent();

            value.BaseImage                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0C28C0 0x20 BaseImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.LvBaseImage                               = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0C28E0 0x28 LvBaseImage                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.RecommendObject                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2900 0x30 RecommendObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2920 0x38 SupportCharacterAreaObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 0270DA0C2940 0x40 SupportCharacterSDIconContentList ( 000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.SelectedLabelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0C2960 0x48 SelectedLabelText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedScheduleLevelParentObject         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2980 0x50 SelectedScheduleLevelParentObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedScheduleLevelObject               = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C29A0 0x58 SelectedScheduleLevelObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedScheduleSupportLevelObject        = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C29C0 0x60 SelectedScheduleSupportLevelObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedScheduleLevelText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0C29E0 0x68 SelectedScheduleLevelText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedScheduleSupportLevelText          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0C2A00 0x70 SelectedScheduleSupportLevelText ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActivateTabObject                         = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2A20 0x78 ActivateTabObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportBonusObject                        = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2A40 0x80 SupportBonusObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
