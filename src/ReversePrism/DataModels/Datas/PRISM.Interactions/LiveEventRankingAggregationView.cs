using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AggregationPanel                         ModelClassType GameObject GameObject GameObject Pointer
    // 028 AggregationDateText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveEventRankingAggregationView : DataModel
    {
        public GameObject?                              AggregationPanel                        { get; set; }
        public UITextMeshProUGUI?                       AggregationDateText                     { get; set; }

        public static LiveEventRankingAggregationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingAggregationView() { Pointer= p0 };

            value.AggregationPanel                          = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 AggregationPanel            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AggregationDateText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 AggregationDateText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
