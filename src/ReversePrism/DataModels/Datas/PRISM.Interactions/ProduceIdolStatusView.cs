using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StarDisplay                              ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 028 AwakeningLvTxt                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IdolAlias                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IdolName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnPIDetail                              ModelClassType UIButton UIButton UIButton Pointer
    // 048 VoDaViMeView                             ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    // 050 onDetailSubject                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolStatusView : DataModel
    {
        public StarDisplay?                             StarDisplay                             { get; set; }
        public UITextMeshProUGUI?                       AwakeningLvTxt                          { get; set; }
        public UITextMeshProUGUI?                       IdolAlias                               { get; set; }
        public UITextMeshProUGUI?                       IdolName                                { get; set; }
        public UIButton?                                BtnPIDetail                             { get; set; }
        public VoDaViMeView?                            VoDaViMeView                            { get; set; }

        public static ProduceIdolStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolStatusView() { Pointer= p0 };

            value.StarDisplay                               = GetObject<StarDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.StarDisplay.FromPointer); // 0x20 StarDisplay                 ( ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.AwakeningLvTxt                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 AwakeningLvTxt              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolAlias                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 IdolAlias                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 IdolName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnPIDetail                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnPIDetail                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0x48 VoDaViMeView                ( ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
