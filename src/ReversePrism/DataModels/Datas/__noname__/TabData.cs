using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseProduct                          ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 018 ExchangeGroupGroupId                     ModelPrimitiveType int int int Int32
    // 020 NewBdgObj                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoodsClientModels                        ModelClassListType List`1<ExchangeGoodsClientModel> List`1<ExchangeGoodsClientModel> List<ExchangeGoodsClientModel> Pointer
    public partial class TabData : DataModel
    {
        public IProductStatus?                          PurchaseProduct                         { get; set; }
        public int                                      ExchangeGroupGroupId                    { get; set; }
        public GameObject?                              NewBdgObj                               { get; set; }
        public List<ExchangeGoodsClientModel>?          GoodsClientModels                       { get; set; }

        public static TabData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TabData() { Pointer= p0 };

            value.PurchaseProduct                           = GetObject<IProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x10 PurchaseProduct             ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ExchangeGroupGroupId                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 ExchangeGroupGroupId        ( ModelPrimitiveType int int int Int32 )
            value.NewBdgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 NewBdgObj                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoodsClientModels                         = GetObjectList<ExchangeGoodsClientModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeGoodsClientModel.FromPointer); // 0x28 GoodsClientModels           ( ModelClassListType List`1<ExchangeGoodsClientModel> List`1<ExchangeGoodsClientModel> List<ExchangeGoodsClientModel> Pointer )

            return value;
        }
    }
}
