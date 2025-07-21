using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType LiveUnitEditView LiveUnitEditView LiveUnitEditView Pointer
    // 028 UnitListWindowView                       ModelClassType UnitListWindowView UnitListWindowView UnitListWindowView Pointer
    // 030 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    public partial class LiveUnitEditBuilder : DataModel
    {
        public LiveUnitEditView?                        View                                    { get; set; }
        public UnitListWindowView?                      UnitListWindowView                      { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }

        public static LiveUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditBuilder() { Pointer= p0 };

            value.View                                      = GetObject<LiveUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitEditView.FromPointer); // 0x20 View                        ( ModelClassType LiveUnitEditView LiveUnitEditView LiveUnitEditView Pointer )
            value.UnitListWindowView                        = GetObject<UnitListWindowView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitListWindowView.FromPointer); // 0x28 UnitListWindowView          ( ModelClassType UnitListWindowView UnitListWindowView UnitListWindowView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x30 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )

            return value;
        }
    }
}
