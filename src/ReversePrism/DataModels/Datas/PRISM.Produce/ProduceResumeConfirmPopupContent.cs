using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 EpisodeMessage                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 DifficultyObjectArray                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 UnitIdolButtonArray                      000185B99BC0 ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer
    // 078 SupportButtonArray                       000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 080 FriendButton                             0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 088 FUnitIconEmptyText                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 FUnitObjectRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 FUnitIcon                                00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 0A0 InheritanceCount                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 CancelButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 EndButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0B8 ResumeButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 ProduceTopMenuCaller                     00018658A730 ModelClassType ProduceTopMenuCaller ProduceTopMenuCaller ProduceTopMenuCaller Pointer
    // 0C8 EndTutorialCaller                        000186730E10 ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer
    public partial class ProduceResumeConfirmPopupContent
    {
        public UITextMeshProUGUI?                       EpisodeMessage                          { get; set; }
        public List<GameObject>?                        DifficultyObjectArray                   { get; set; }
        public List<PFIdolIconRectView>?                UnitIdolButtonArray                     { get; set; }
        public List<SCharaIconView>?                    SupportButtonArray                      { get; set; }
        public SCharaIconView?                          FriendButton                            { get; set; }
        public GameObject?                              FUnitIconEmptyText                      { get; set; }
        public GameObject?                              FUnitObjectRoot                         { get; set; }
        public FUnitIconView?                           FUnitIcon                               { get; set; }
        public UITextMeshProUGUI?                       InheritanceCount                        { get; set; }
        public UIButton?                                CancelButton                            { get; set; }
        public UIButton?                                EndButton                               { get; set; }
        public UIButton?                                ResumeButton                            { get; set; }
        public ProduceTopMenuCaller?                    ProduceTopMenuCaller                    { get; set; }
        public EndTutorialConfirmPopupViewCaller?       EndTutorialCaller                       { get; set; }

        public static ProduceResumeConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResumeConfirmPopupContent();

            value.EpisodeMessage                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027005ABEE28 0x60 EpisodeMessage              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyObjectArray                     = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 027005ABEE48 0x68 DifficultyObjectArray       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UnitIdolButtonArray                       = GetObjectList<PFIdolIconRectView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 027005ABEE68 0x70 UnitIdolButtonArray         ( 000185B99BC0 ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x078), ReversePrism.DataModels.SCharaIconView.FromPointer); // 027005ABEE88 0x78 SupportButtonArray          ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SCharaIconView.FromPointer); // 027005ABEEA8 0x80 FriendButton                ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FUnitIconEmptyText                        = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 027005ABEEC8 0x88 FUnitIconEmptyText          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitObjectRoot                           = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 027005ABEEE8 0x90 FUnitObjectRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x098), ReversePrism.DataModels.FUnitIconView.FromPointer); // 027005ABEF08 0x98 FUnitIcon                   ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027005ABEF28 0xA0 InheritanceCount            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 027005ABEF48 0xA8 CancelButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EndButton                                 = GetObject<UIButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIButton.FromPointer); // 027005ABEF68 0xB0 EndButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ResumeButton                              = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 027005ABEF88 0xB8 ResumeButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceTopMenuCaller                      = GetObject<ProduceTopMenuCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ProduceTopMenuCaller.FromPointer); // 027005ABEFA8 0xC0 ProduceTopMenuCaller        ( 00018658A730 ModelClassType ProduceTopMenuCaller ProduceTopMenuCaller ProduceTopMenuCaller Pointer )
            value.EndTutorialCaller                         = GetObject<EndTutorialConfirmPopupViewCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.EndTutorialConfirmPopupViewCaller.FromPointer); // 027005ABEFC8 0xC8 EndTutorialCaller           ( 000186730E10 ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer )

            return value;
        }
    }
}
