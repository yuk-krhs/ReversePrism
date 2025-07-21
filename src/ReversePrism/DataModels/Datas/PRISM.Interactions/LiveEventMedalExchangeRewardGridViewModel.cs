using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 018 Count                                    ModelPrimitiveType int int int Int32
    public partial class LiveEventMedalExchangeRewardGridViewModel : DataModel
    {
        public IProductWithAmountStatus?                Product                                 { get; set; }
        public int                                      Count                                   { get; set; }

        public static LiveEventMedalExchangeRewardGridViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventMedalExchangeRewardGridViewModel() { Pointer= p0 };

            value.Product                                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x10 Product                     ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
