using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RequiredRP                               0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 018 HaveRP                                   0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 020 ShortageRP                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 028 ProductKey                               0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32
    public partial class RequiredItemIconViewModel : DataModel
    {
        public LongReactiveProperty?                    RequiredRP                              { get; set; }
        public LongReactiveProperty?                    HaveRP                                  { get; set; }
        public BoolReactiveProperty?                    ShortageRP                              { get; set; }
        public ProductKey                               ProductKey                              { get; set; }

        public static RequiredItemIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredItemIconViewModel() { Pointer= p0 };

            value.RequiredRP                                = GetObject<LongReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 02466604D418 0x10 RequiredRP                  ( 0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.HaveRP                                    = GetObject<LongReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 02466604D438 0x18 HaveRP                      ( 0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.ShortageRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 02466604D458 0x20 ShortageRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x028)); // 02466604D478 0x28 ProductKey                  ( 0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32 )

            return value;
        }
    }
}
