using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 EpisodeMessage                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 DifficultyObjectArray                    ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 UnitIdolButtonArray                      ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer
    // 078 SupportButtonArray                       ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 080 FriendButton                             ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 088 FUnitIconEmptyText                       ModelClassType GameObject GameObject GameObject Pointer
    // 090 FUnitObjectRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 098 FUnitIcon                                ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 0A0 InheritanceCount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 CancelButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 EndButton                                ModelClassType UIButton UIButton UIButton Pointer
    // 0B8 ResumeButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 EndTutorialCaller                        ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer
    public partial class ProduceResumeConfirmPopupContent : DataModel
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
        public EndTutorialConfirmPopupViewCaller?       EndTutorialCaller                       { get; set; }

        public static ProduceResumeConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResumeConfirmPopupContent() { Pointer= p0 };

            value.EpisodeMessage                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 EpisodeMessage              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyObjectArray                     = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 DifficultyObjectArray       ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UnitIdolButtonArray                       = GetObjectList<PFIdolIconRectView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x70 UnitIdolButtonArray         ( ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x078), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x78 SupportButtonArray          ( ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x80 FriendButton                ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FUnitIconEmptyText                        = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 FUnitIconEmptyText          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitObjectRoot                           = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 FUnitObjectRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x098), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x98 FUnitIcon                   ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 InheritanceCount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0xA8 CancelButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EndButton                                 = GetObject<UIButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIButton.FromPointer); // 0xB0 EndButton                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResumeButton                              = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 0xB8 ResumeButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EndTutorialCaller                         = GetObject<EndTutorialConfirmPopupViewCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.EndTutorialConfirmPopupViewCaller.FromPointer); // 0xC0 EndTutorialCaller           ( ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer )

            return value;
        }
    }
}
