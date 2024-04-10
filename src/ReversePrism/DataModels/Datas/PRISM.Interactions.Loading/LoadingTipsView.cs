using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TipsTitleText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TipsDescriptionText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TipsCategoryTitleText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TipsCategoryObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TipsCategoryColorImage                   0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 TipsCharaImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 ViewModel                                0001865A0160 ModelClassType LoadingTipsViewModel LoadingTipsViewModel LoadingTipsViewModel Pointer
    // 058 IsInitializationSuccess                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LoadingTipsView : DataModel
    {
        public UITextMeshProUGUI?                       TipsTitleText                           { get; set; }
        public UITextMeshProUGUI?                       TipsDescriptionText                     { get; set; }
        public UITextMeshProUGUI?                       TipsCategoryTitleText                   { get; set; }
        public GameObject?                              TipsCategoryObject                      { get; set; }
        public UIImage?                                 TipsCategoryColorImage                  { get; set; }
        public UIImage?                                 TipsCharaImage                          { get; set; }
        public LoadingTipsViewModel?                    ViewModel                               { get; set; }
        public bool                                     IsInitializationSuccess                 { get; set; }

        public static LoadingTipsView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingTipsView() { Pointer= p0 };

            value.TipsTitleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A1EA00D0 0x20 TipsTitleText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TipsDescriptionText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A1EA00F0 0x28 TipsDescriptionText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TipsCategoryTitleText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A1EA0110 0x30 TipsCategoryTitleText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TipsCategoryObject                        = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0245A1EA0130 0x38 TipsCategoryObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TipsCategoryColorImage                    = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0245A1EA0150 0x40 TipsCategoryColorImage      ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TipsCharaImage                            = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0245A1EA0170 0x48 TipsCharaImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ViewModel                                 = GetObject<LoadingTipsViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.LoadingTipsViewModel.FromPointer); // 0245A1EA0190 0x50 ViewModel                   ( 0001865A0160 ModelClassType LoadingTipsViewModel LoadingTipsViewModel LoadingTipsViewModel Pointer )
            value.IsInitializationSuccess                   = GetBool(new IntPtr(p + 0x058)); // 0245A1EA01B0 0x58 IsInitializationSuccess     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
