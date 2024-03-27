using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoWhite                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoBlue                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TxtVolues1                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtVolues2                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtNameAlias                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PfIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 058 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 060 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 068 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 070 ProducItem                               0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 078 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaOfferListCell
    {
        public GameObject?                              GoWhite                                 { get; set; }
        public GameObject?                              GoBlue                                  { get; set; }
        public UITextMeshProUGUI?                       TxtVolues1                              { get; set; }
        public UITextMeshProUGUI?                       TxtVolues2                              { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UITextMeshProUGUI?                       TxtNameAlias                            { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public CmnItem?                                 ProducItem                              { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static GashaOfferListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaOfferListCell();

            value.GoWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5369920 0x20 GoWhite                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5369940 0x28 GoBlue                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtVolues1                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5369960 0x30 TxtVolues1                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtVolues2                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5369980 0x38 TxtVolues2                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53699A0 0x40 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNameAlias                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53699C0 0x48 TxtNameAlias                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x050), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D53699E0 0x50 PfIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5369A00 0x58 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D5369A20 0x60 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270D5369A40 0x68 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.ProducItem                                = GetObject<CmnItem>(new IntPtr(p + 0x070), ReversePrism.DataModels.CmnItem.FromPointer); // 0270D5369A60 0x70 ProducItem                  ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5369A80 0x78 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
