using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtCharaLv                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DiamondDisplay                           ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 CgBlank                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 ImgFavoriteMark                          ModelClassType RawImage RawImage RawImage Pointer
    // 040 CgFavoriteMark                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 RarityEffect                             ModelClassType Animator Animator Animator Pointer
    // 050 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 058 IsInitialized                            ModelPrimitiveType bool bool bool Bool
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

            value.TxtCharaLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtCharaLv                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DiamondDisplay                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0x28 DiamondDisplay              ( ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.CgBlank                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CgBlank                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ImgFavoriteMark             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CgFavoriteMark                            = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CgFavoriteMark              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RarityEffect                              = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 RarityEffect                ( ModelClassType Animator Animator Animator Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0x50 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x058)); // 0x58 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
