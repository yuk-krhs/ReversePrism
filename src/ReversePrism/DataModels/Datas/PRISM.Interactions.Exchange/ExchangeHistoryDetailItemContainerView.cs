using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemPrefab                               00018650A850 ModelClassType ExchangeGoodsSetItem ExchangeGoodsSetItem ExchangeGoodsSetItem Pointer
    // 030 ItemParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 NoItemLabel                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ExchangeHistoryDetailItemContainerView : DataModel
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public ExchangeGoodsSetItem?                    ItemPrefab                              { get; set; }
        public Transform?                               ItemParent                              { get; set; }
        public GameObject?                              NoItemLabel                             { get; set; }

        public static ExchangeHistoryDetailItemContainerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryDetailItemContainerView() { Pointer= p0 };

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B972DC8 0x20 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemPrefab                                = GetObject<ExchangeGoodsSetItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeGoodsSetItem.FromPointer); // 02466B972DE8 0x28 ItemPrefab                  ( 00018650A850 ModelClassType ExchangeGoodsSetItem ExchangeGoodsSetItem ExchangeGoodsSetItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466B972E08 0x30 ItemParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.NoItemLabel                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466B972E28 0x38 NoItemLabel                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
