using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Rect                                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 PfIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 048 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 050 ProducItem                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 058 TxtCharaNameAlias                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtCharaName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtNormalRate                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtPromisedRate                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 BgBlue                                   ModelClassType GameObject GameObject GameObject Pointer
    // 080 BgWhite                                  ModelClassType GameObject GameObject GameObject Pointer
    // 088 PromisedRateColmObjects                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 090 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaRatesRateProductCellView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public RewardItem?                              ProducItem                              { get; set; }
        public UITextMeshProUGUI?                       TxtCharaNameAlias                       { get; set; }
        public UITextMeshProUGUI?                       TxtCharaName                            { get; set; }
        public UITextMeshProUGUI?                       TxtNormalRate                           { get; set; }
        public UITextMeshProUGUI?                       TxtPromisedRate                         { get; set; }
        public GameObject?                              BgBlue                                  { get; set; }
        public GameObject?                              BgWhite                                 { get; set; }
        public List<GameObject>?                        PromisedRateColmObjects                 { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static GashaRatesRateProductCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRateProductCellView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 Rect                        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x40 PfIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x48 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.ProducItem                                = GetObject<RewardItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItem.FromPointer); // 0x50 ProducItem                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TxtCharaNameAlias                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtCharaNameAlias           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCharaName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtCharaName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNormalRate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtNormalRate               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPromisedRate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtPromisedRate             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BgBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 BgBlue                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BgWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 BgWhite                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PromisedRateColmObjects                   = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 PromisedRateColmObjects     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 0x90 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
