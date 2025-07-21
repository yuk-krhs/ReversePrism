using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TraItemRoot                              ModelClassType Transform Transform Transform Pointer
    // 028 GoTemplateIco                            ModelClassType GameObject GameObject GameObject Pointer
    // 030 OkButton                                 ModelClassType UIButton UIButton UIButton Pointer
    // 038 SkipAnimationButton                      ModelClassType Button Button Button Pointer
    // 040 MedalGashaSequenceAnimator               ModelClassType Animator Animator Animator Pointer
    // 048 MedalGashaRibbonAnimator                 ModelClassType Animator Animator Animator Pointer
    // 050 UiCanvas                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 CellList                                 ModelClassListType List`1<MedalGashaResultViewCell> List`1<MedalGashaResultViewCell> List<MedalGashaResultViewCell> Pointer
    // 060 SkipToken                                ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class MedalGashaResultView : DataModel
    {
        public Transform?                               TraItemRoot                             { get; set; }
        public GameObject?                              GoTemplateIco                           { get; set; }
        public UIButton?                                OkButton                                { get; set; }
        public Button?                                  SkipAnimationButton                     { get; set; }
        public Animator?                                MedalGashaSequenceAnimator              { get; set; }
        public Animator?                                MedalGashaRibbonAnimator                { get; set; }
        public CanvasGroup?                             UiCanvas                                { get; set; }
        public List<MedalGashaResultViewCell>?          CellList                                { get; set; }
        public CancellationToken                        SkipToken                               { get; set; }

        public static MedalGashaResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaResultView() { Pointer= p0 };

            value.TraItemRoot                               = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 TraItemRoot                 ( ModelClassType Transform Transform Transform Pointer )
            value.GoTemplateIco                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoTemplateIco               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OkButton                                  = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 OkButton                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x038), ReversePrism.DataModels.Button.FromPointer); // 0x38 SkipAnimationButton         ( ModelClassType Button Button Button Pointer )
            value.MedalGashaSequenceAnimator                = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0x40 MedalGashaSequenceAnimator  ( ModelClassType Animator Animator Animator Pointer )
            value.MedalGashaRibbonAnimator                  = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 MedalGashaRibbonAnimator    ( ModelClassType Animator Animator Animator Pointer )
            value.UiCanvas                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x50 UiCanvas                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CellList                                  = GetObjectList<MedalGashaResultViewCell>(new IntPtr(p + 0x058), ReversePrism.DataModels.MedalGashaResultViewCell.FromPointer); // 0x58 CellList                    ( ModelClassListType List`1<MedalGashaResultViewCell> List`1<MedalGashaResultViewCell> List<MedalGashaResultViewCell> Pointer )
            value.SkipToken                                 = (CancellationToken)GetInt32(new IntPtr(p + 0x060)); // 0x60 SkipToken                   ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
