using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtNickname                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 BtnDetails                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PFIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    public partial class GashaMemberCell : DataModel
    {
        public UITextMeshProUGUI?                       TxtNickname                             { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public ButtonBase?                              BtnDetails                              { get; set; }
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }

        public static GashaMemberCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMemberCell() { Pointer= p0 };

            value.TxtNickname                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtNickname                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnDetails                                = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 BtnDetails                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x38 PFIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x40 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )

            return value;
        }
    }
}
