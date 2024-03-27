using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseProduct                          0001865F9710 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 018 ExchangeGroupGroupId                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 NewBdgObj                                0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoodsClientModels                        000185CDA538 ModelClassListType List`1<ExchangeGoodsClientModel> List`1<ExchangeGoodsClientModel> List<ExchangeGoodsClientModel> Pointer
    public partial class TabData
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
            var value   = new TabData();

            value.PurchaseProduct                           = GetObject<IProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductStatus.FromPointer); // 0270D6308C98 0x10 PurchaseProduct             ( 0001865F9710 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ExchangeGroupGroupId                      = GetInt32(new IntPtr(p + 0x018)); // 0270D6308CB8 0x18 ExchangeGroupGroupId        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NewBdgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D6308CD8 0x20 NewBdgObj                   ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoodsClientModels                         = GetObjectList<ExchangeGoodsClientModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeGoodsClientModel.FromPointer); // 0270D6308CF8 0x28 GoodsClientModels           ( 000185CDA538 ModelClassListType List`1<ExchangeGoodsClientModel> List`1<ExchangeGoodsClientModel> List<ExchangeGoodsClientModel> Pointer )

            return value;
        }
    }
}
