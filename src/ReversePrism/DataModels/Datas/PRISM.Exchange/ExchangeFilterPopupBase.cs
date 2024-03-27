using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FilterPrefab                             0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 068 FilterViewArea                           0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ResetButton                              0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 078 idToggleButtons                          Dictionary`2<int, ToggleButton> IL2CPP_TYPE_GENERICINST
    // 080 FilterItemIDs                            000185CED038 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 088 sortFilterModel                          SortFilterModel`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 090 onAppliedSortFilter                      Action`1<IEnumerable`1<ExchangeGoodsClientModel>> IL2CPP_TYPE_GENERICINST
    // 098 ExchangeSaveData                         000186516FD0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer
    public partial class ExchangeFilterPopupBase
    {
        public GameObject?                              FilterPrefab                            { get; set; }
        public GameObject?                              FilterViewArea                          { get; set; }
        public UIButton?                                ResetButton                             { get; set; }
        public List<int>?                               FilterItemIDs                           { get; set; }
        public ExchangeSaveData?                        ExchangeSaveData                        { get; set; }

        public static ExchangeFilterPopupBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeFilterPopupBase();

            value.FilterPrefab                              = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54D1FA0 0x60 FilterPrefab                ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.FilterViewArea                            = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54D1FC0 0x68 FilterViewArea              ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResetButton                               = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270D54D1FE0 0x70 ResetButton                 ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.FilterItemIDs                             = GetInt32List(new IntPtr(p + 0x080)); // 0270D54D2020 0x80 FilterItemIDs               ( 000185CED038 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ExchangeSaveData                          = GetObject<ExchangeSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ExchangeSaveData.FromPointer); // 0270D54D2080 0x98 ExchangeSaveData            ( 000186516FD0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer )

            return value;
        }
    }
}
