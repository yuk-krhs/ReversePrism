using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TraItemRoot                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 GoTemplateIco                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OkButton                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 SkipAnimationButton                      0001865140C0 ModelClassType Button Button Button Pointer
    // 040 MedalGashaSequenceAnimator               0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 048 MedalGashaRibbonAnimator                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 050 UiCanvas                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 060 CellList                                 000185CF26C8 ModelClassListType List`1<MedalGashaResultViewCell> List`1<MedalGashaResultViewCell> List<MedalGashaResultViewCell> Pointer
    public partial class MedalGashaResultView
    {
        public Transform?                               TraItemRoot                             { get; set; }
        public GameObject?                              GoTemplateIco                           { get; set; }
        public UIButton?                                OkButton                                { get; set; }
        public Button?                                  SkipAnimationButton                     { get; set; }
        public Animator?                                MedalGashaSequenceAnimator              { get; set; }
        public Animator?                                MedalGashaRibbonAnimator                { get; set; }
        public CanvasGroup?                             UiCanvas                                { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public List<MedalGashaResultViewCell>?          CellList                                { get; set; }

        public static MedalGashaResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaResultView();

            value.TraItemRoot                               = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DB916DD0 0x20 TraItemRoot                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoTemplateIco                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB916DF0 0x28 GoTemplateIco               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OkButton                                  = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB916E10 0x30 OkButton                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x038), ReversePrism.DataModels.Button.FromPointer); // 0270DB916E30 0x38 SkipAnimationButton         ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.MedalGashaSequenceAnimator                = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0270DB916E50 0x40 MedalGashaSequenceAnimator  ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.MedalGashaRibbonAnimator                  = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0270DB916E70 0x48 MedalGashaRibbonAnimator    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.UiCanvas                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB916E90 0x50 UiCanvas                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB916EB0 0x58 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CellList                                  = GetObjectList<MedalGashaResultViewCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.MedalGashaResultViewCell.FromPointer); // 0270DB916ED0 0x60 CellList                    ( 000185CF26C8 ModelClassListType List`1<MedalGashaResultViewCell> List`1<MedalGashaResultViewCell> List<MedalGashaResultViewCell> Pointer )

            return value;
        }
    }
}
