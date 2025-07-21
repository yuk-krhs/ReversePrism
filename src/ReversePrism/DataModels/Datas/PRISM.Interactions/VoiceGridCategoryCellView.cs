using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 BtnCell                                  ModelClassType UIButton UIButton UIButton Pointer
    // 038 PfIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 TxtVoiceTargetName1                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtVoiceTargetName2                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtCounter                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GoGrayOut                                ModelClassType GameObject GameObject GameObject Pointer
    // 068 OnDetailDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class VoiceGridCategoryCellView : DataModel
    {
        public UIButton?                                BtnCell                                 { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public UITextMeshProUGUI?                       TxtVoiceTargetName1                     { get; set; }
        public UITextMeshProUGUI?                       TxtVoiceTargetName2                     { get; set; }
        public UITextMeshProUGUI?                       TxtCounter                              { get; set; }
        public GameObject?                              GoGrayOut                               { get; set; }
        public IDisposable?                             OnDetailDisposable                      { get; set; }

        public static VoiceGridCategoryCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceGridCategoryCellView() { Pointer= p0 };

            value.BtnCell                                   = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnCell                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x38 PfIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x40 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.TxtVoiceTargetName1                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtVoiceTargetName1         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtVoiceTargetName2                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtVoiceTargetName2         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCounter                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtCounter                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoGrayOut                                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 GoGrayOut                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OnDetailDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 0x68 OnDetailDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
