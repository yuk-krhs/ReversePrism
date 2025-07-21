using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Step                                     ModelPrimitiveType int int int Int32
    // 014 Amount                                   ModelPrimitiveType int int int Int32
    // 018 ItemProduct                              ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    public partial class ShopPassContinuationRewardItemViewModel : DataModel
    {
        public int                                      Step                                    { get; set; }
        public int                                      Amount                                  { get; set; }
        public IProductStatus?                          ItemProduct                             { get; set; }

        public static ShopPassContinuationRewardItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassContinuationRewardItemViewModel() { Pointer= p0 };

            value.Step                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Step                        ( ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Amount                      ( ModelPrimitiveType int int int Int32 )
            value.ItemProduct                               = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x18 ItemProduct                 ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )

            return value;
        }
    }
}
