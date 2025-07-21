using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtNameAlias                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtRarity                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Btn                                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 ImgIdol                                  ModelClassType RawImage RawImage RawImage Pointer
    // 048 SCharaDetailPopupCaller                  ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class GashaPickupScharaCell : DataModel
    {
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UITextMeshProUGUI?                       TxtNameAlias                            { get; set; }
        public UITextMeshProUGUI?                       TxtRarity                               { get; set; }
        public ButtonBase?                              Btn                                     { get; set; }
        public RawImage?                                ImgIdol                                 { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }

        public static GashaPickupScharaCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPickupScharaCell() { Pointer= p0 };

            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNameAlias                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtNameAlias                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRarity                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtRarity                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Btn                                       = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 Btn                         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgIdol                                   = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0x40 ImgIdol                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0x48 SCharaDetailPopupCaller     ( ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
