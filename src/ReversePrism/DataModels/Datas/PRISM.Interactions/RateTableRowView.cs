using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Rect                                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 PfIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 030 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 038 TxtCharaNameAlias                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtCharaName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtNormalRate                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtPromisedRate                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BgBlue                                   ModelClassType GameObject GameObject GameObject Pointer
    // 060 BgWhite                                  ModelClassType GameObject GameObject GameObject Pointer
    // 068 PIdolDetailPopupCaller                   ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 070 SCharaDetailPopupCaller                  ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 078 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class RateTableRowView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public UITextMeshProUGUI?                       TxtCharaNameAlias                       { get; set; }
        public UITextMeshProUGUI?                       TxtCharaName                            { get; set; }
        public UITextMeshProUGUI?                       TxtNormalRate                           { get; set; }
        public UITextMeshProUGUI?                       TxtPromisedRate                         { get; set; }
        public GameObject?                              BgBlue                                  { get; set; }
        public GameObject?                              BgWhite                                 { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static RateTableRowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RateTableRowView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 Rect                        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x28 PfIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x30 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.TxtCharaNameAlias                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtCharaNameAlias           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCharaName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtCharaName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNormalRate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtNormalRate               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPromisedRate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtPromisedRate             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BgBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 BgBlue                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BgWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 BgWhite                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0x68 PIdolDetailPopupCaller      ( ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0x70 SCharaDetailPopupCaller     ( ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
