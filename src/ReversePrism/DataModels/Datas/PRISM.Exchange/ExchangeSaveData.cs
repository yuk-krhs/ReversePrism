using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PieceFilterData                          ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer
    // 028 ItemFilterData                           ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer
    // 030 StarFragmentFilterData                   ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer
    // 038 SeasonMedalFilterData                    ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer
    // 040 NoneFilterData                           ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer
    // 048 SerializeGoodsListDatas                  ModelClassListType List`1<GoodsListData> List`1<GoodsListData> List<GoodsListData> Pointer
    // 050 goodsListDatas                           Dictionary`2<int, List`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeSaveData : DataModel
    {
        public ExchangeFilterSaveData?                  PieceFilterData                         { get; set; }
        public ExchangeFilterSaveData?                  ItemFilterData                          { get; set; }
        public ExchangeFilterSaveData?                  StarFragmentFilterData                  { get; set; }
        public ExchangeFilterSaveData?                  SeasonMedalFilterData                   { get; set; }
        public ExchangeFilterSaveData?                  NoneFilterData                          { get; set; }
        public List<GoodsListData>?                     SerializeGoodsListDatas                 { get; set; }

        public static ExchangeSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSaveData() { Pointer= p0 };

            value.PieceFilterData                           = GetObject<ExchangeFilterSaveData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeFilterSaveData.FromPointer); // 0x20 PieceFilterData             ( ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer )
            value.ItemFilterData                            = GetObject<ExchangeFilterSaveData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeFilterSaveData.FromPointer); // 0x28 ItemFilterData              ( ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer )
            value.StarFragmentFilterData                    = GetObject<ExchangeFilterSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExchangeFilterSaveData.FromPointer); // 0x30 StarFragmentFilterData      ( ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer )
            value.SeasonMedalFilterData                     = GetObject<ExchangeFilterSaveData>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExchangeFilterSaveData.FromPointer); // 0x38 SeasonMedalFilterData       ( ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer )
            value.NoneFilterData                            = GetObject<ExchangeFilterSaveData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeFilterSaveData.FromPointer); // 0x40 NoneFilterData              ( ModelClassType ExchangeFilterSaveData ExchangeFilterSaveData ExchangeFilterSaveData Pointer )
            value.SerializeGoodsListDatas                   = GetObjectList<GoodsListData>(new IntPtr(p + 0x048), ReversePrism.DataModels.GoodsListData.FromPointer); // 0x48 SerializeGoodsListDatas     ( ModelClassListType List`1<GoodsListData> List`1<GoodsListData> List<GoodsListData> Pointer )

            return value;
        }
    }
}
