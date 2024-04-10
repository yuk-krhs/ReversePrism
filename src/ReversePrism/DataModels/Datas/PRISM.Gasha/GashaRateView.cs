using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Tag                                      string IL2CPP_TYPE_STRING
    // 020 Rarity2Columns                           000186619100 ModelClassType TableContent TableContent TableContent Pointer
    // 028 Rarity3Columns                           000186619100 ModelClassType TableContent TableContent TableContent Pointer
    // 030 TxtPickupTitle                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtRateAttention                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtRateAttentionLast                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TraPickupTitleRoot                       0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 GoProducePickUpTemplate                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoScharaPickUpTemplate                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 TraPickUpRoot                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 068 GoOfferListTemplate                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 GoOfferListTitleTemplate                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 TraOfferListRoot                         0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 080 CmnTableTemplate                         0001865BC990 ModelClassType CmnTable CmnTable CmnTable Pointer
    // 088 ListGameObjects                          000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 090 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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

            value.Rarity2Columns                            = GetObject<TableContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.TableContent.FromPointer); // 0246653FC0D8 0x20 Rarity2Columns              ( 000186619100 ModelClassType TableContent TableContent TableContent Pointer )
            value.Rarity3Columns                            = GetObject<TableContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.TableContent.FromPointer); // 0246653FC0F8 0x28 Rarity3Columns              ( 000186619100 ModelClassType TableContent TableContent TableContent Pointer )
            value.TxtPickupTitle                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653FC118 0x30 TxtPickupTitle              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRateAttention                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653FC138 0x38 TxtRateAttention            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRateAttentionLast                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653FC158 0x40 TxtRateAttentionLast        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TraPickupTitleRoot                        = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0246653FC178 0x48 TraPickupTitleRoot          ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoProducePickUpTemplate                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246653FC198 0x50 GoProducePickUpTemplate     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoScharaPickUpTemplate                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0246653FC1B8 0x58 GoScharaPickUpTemplate      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TraPickUpRoot                             = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0246653FC1D8 0x60 TraPickUpRoot               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoOfferListTemplate                       = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0246653FC1F8 0x68 GoOfferListTemplate         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoOfferListTitleTemplate                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0246653FC218 0x70 GoOfferListTitleTemplate    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TraOfferListRoot                          = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 0246653FC238 0x78 TraOfferListRoot            ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CmnTableTemplate                          = GetObject<CmnTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CmnTable.FromPointer); // 0246653FC258 0x80 CmnTableTemplate            ( 0001865BC990 ModelClassType CmnTable CmnTable CmnTable Pointer )
            value.ListGameObjects                           = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0246653FC278 0x88 ListGameObjects             ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246653FC298 0x90 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
