using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtCharaLv                               0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DiamondDisplay                           0001866CFB10 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 CgBlank                                  000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 ImgFavoriteMark                          000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 040 CgFavoriteMark                           000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 RarityEffect                             0001866B8FF0 ModelClassType Animator Animator Animator Pointer
    // 050 Ct                                       00018653D040 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 058 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SCharaIconViewBase : DataModel
    {
        public UITextMeshProUGUI?                       TxtCharaLv                              { get; set; }
        public DiamondDisplay?                          DiamondDisplay                          { get; set; }
        public CanvasGroup?                             CgBlank                                 { get; set; }
        public RawImage?                                ImgFavoriteMark                         { get; set; }
        public CanvasGroup?                             CgFavoriteMark                          { get; set; }
        public Animator?                                RarityEffect                            { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static SCharaIconViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaIconViewBase() { Pointer= p0 };

            value.TxtCharaLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5B235B8 0x20 TxtCharaLv                  ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DiamondDisplay                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0245A5B235D8 0x28 DiamondDisplay              ( 0001866CFB10 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.CgBlank                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B235F8 0x30 CgBlank                     ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5B23618 0x38 ImgFavoriteMark             ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.CgFavoriteMark                            = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B23638 0x40 CgFavoriteMark              ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RarityEffect                              = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0245A5B23658 0x48 RarityEffect                ( 0001866B8FF0 ModelClassType Animator Animator Animator Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0245A5B23678 0x50 Ct                          ( 00018653D040 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x058)); // 0245A5B23698 0x58 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
