using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186591C00 ModelClassType LiveUnitEditView LiveUnitEditView LiveUnitEditView Pointer
    // 028 UnitListWindowView                       00018670DFA0 ModelClassType UnitListWindowView UnitListWindowView UnitListWindowView Pointer
    // 030 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 038 UseRecommendedPopupViewFactory           0001865916E0 ModelClassType LiveUnitEditUseRecommendedPopupViewFactory LiveUnitEditUseRecommendedPopupViewFactory LiveUnitEditUseRecommendedPopupViewFactory Pointer
    public partial class LiveUnitEditBuilder : DataModel
    {
        public LiveUnitEditView?                        View                                    { get; set; }
        public UnitListWindowView?                      UnitListWindowView                      { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public LiveUnitEditUseRecommendedPopupViewFactory? UseRecommendedPopupViewFactory          { get; set; }

        public static LiveUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditBuilder() { Pointer= p0 };

            value.View                                      = GetObject<LiveUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitEditView.FromPointer); // 02466B679D90 0x20 View                        ( 000186591C00 ModelClassType LiveUnitEditView LiveUnitEditView LiveUnitEditView Pointer )
            value.UnitListWindowView                        = GetObject<UnitListWindowView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitListWindowView.FromPointer); // 02466B679DB0 0x28 UnitListWindowView          ( 00018670DFA0 ModelClassType UnitListWindowView UnitListWindowView UnitListWindowView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B679DD0 0x30 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UseRecommendedPopupViewFactory            = GetObject<LiveUnitEditUseRecommendedPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveUnitEditUseRecommendedPopupViewFactory.FromPointer); // 02466B679DF0 0x38 UseRecommendedPopupViewFactory ( 0001865916E0 ModelClassType LiveUnitEditUseRecommendedPopupViewFactory LiveUnitEditUseRecommendedPopupViewFactory LiveUnitEditUseRecommendedPopupViewFactory Pointer )

            return value;
        }
    }
}
