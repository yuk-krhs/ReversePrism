using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Rarity2Columns                           ModelClassType TableContent TableContent TableContent Pointer
    // 028 Rarity3Columns                           ModelClassType TableContent TableContent TableContent Pointer
    // 030 TxtPickupTitle                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtRateAttention                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtRateAttentionLast                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TraPickupTitleRoot                       ModelClassType Transform Transform Transform Pointer
    // 050 GoProducePickUpTemplate                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoScharaPickUpTemplate                   ModelClassType GameObject GameObject GameObject Pointer
    // 060 TraPickUpRoot                            ModelClassType Transform Transform Transform Pointer
    // 068 GoOfferListTemplate                      ModelClassType GameObject GameObject GameObject Pointer
    // 070 GoOfferListTitleTemplate                 ModelClassType GameObject GameObject GameObject Pointer
    // 078 TraOfferListRoot                         ModelClassType Transform Transform Transform Pointer
    // 080 CmnTableTemplate                         ModelClassType CmnTable CmnTable CmnTable Pointer
    // 088 ListGameObjects                          ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 090 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class GashaRateView : DataModel
    {
        public TableContent?                            Rarity2Columns                          { get; set; }
        public TableContent?                            Rarity3Columns                          { get; set; }
        public UITextMeshProUGUI?                       TxtPickupTitle                          { get; set; }
        public UITextMeshProUGUI?                       TxtRateAttention                        { get; set; }
        public UITextMeshProUGUI?                       TxtRateAttentionLast                    { get; set; }
        public Transform?                               TraPickupTitleRoot                      { get; set; }
        public GameObject?                              GoProducePickUpTemplate                 { get; set; }
        public GameObject?                              GoScharaPickUpTemplate                  { get; set; }
        public Transform?                               TraPickUpRoot                           { get; set; }
        public GameObject?                              GoOfferListTemplate                     { get; set; }
        public GameObject?                              GoOfferListTitleTemplate                { get; set; }
        public Transform?                               TraOfferListRoot                        { get; set; }
        public CmnTable?                                CmnTableTemplate                        { get; set; }
        public List<GameObject>?                        ListGameObjects                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static GashaRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRateView() { Pointer= p0 };

            value.Rarity2Columns                            = GetObject<TableContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.TableContent.FromPointer); // 0x20 Rarity2Columns              ( ModelClassType TableContent TableContent TableContent Pointer )
            value.Rarity3Columns                            = GetObject<TableContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.TableContent.FromPointer); // 0x28 Rarity3Columns              ( ModelClassType TableContent TableContent TableContent Pointer )
            value.TxtPickupTitle                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtPickupTitle              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRateAttention                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtRateAttention            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRateAttentionLast                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtRateAttentionLast        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TraPickupTitleRoot                        = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 TraPickupTitleRoot          ( ModelClassType Transform Transform Transform Pointer )
            value.GoProducePickUpTemplate                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoProducePickUpTemplate     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoScharaPickUpTemplate                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoScharaPickUpTemplate      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TraPickUpRoot                             = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0x60 TraPickUpRoot               ( ModelClassType Transform Transform Transform Pointer )
            value.GoOfferListTemplate                       = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 GoOfferListTemplate         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoOfferListTitleTemplate                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 GoOfferListTitleTemplate    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TraOfferListRoot                          = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 0x78 TraOfferListRoot            ( ModelClassType Transform Transform Transform Pointer )
            value.CmnTableTemplate                          = GetObject<CmnTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CmnTable.FromPointer); // 0x80 CmnTableTemplate            ( ModelClassType CmnTable CmnTable CmnTable Pointer )
            value.ListGameObjects                           = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 ListGameObjects             ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x90 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
