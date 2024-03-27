using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtNickname                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 BtnDetails                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PFIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 050 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class GashaMemberCell
    {
        public UITextMeshProUGUI?                       TxtNickname                             { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public ButtonBase?                              BtnDetails                              { get; set; }
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }

        public static GashaMemberCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMemberCell();

            value.TxtNickname                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53081B8 0x20 TxtNickname                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53081D8 0x28 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnDetails                                = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D53081F8 0x30 BtnDetails                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D5308218 0x38 PFIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5308238 0x40 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D5308258 0x48 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270D5308278 0x50 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
