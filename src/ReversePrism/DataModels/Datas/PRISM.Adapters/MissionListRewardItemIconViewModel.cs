using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 018 GaugePoint                               ModelPrimitiveType int int int Int32
    // 01C Index                                    ModelPrimitiveType int int int Int32
    // 020 ProductKey                               ModelEnumType ProductKey ProductKey ProductKey Int32
    public partial class MissionListRewardItemIconViewModel : DataModel
    {
        public IProductWithAmountStatus?                Status                                  { get; set; }
        public int                                      GaugePoint                              { get; set; }
        public int                                      Index                                   { get; set; }
        public ProductKey                               ProductKey                              { get; set; }

        public static MissionListRewardItemIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListRewardItemIconViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x10 Status                      ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.GaugePoint                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 GaugePoint                  ( ModelPrimitiveType int int int Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Index                       ( ModelPrimitiveType int int int Int32 )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 ProductKey                  ( ModelEnumType ProductKey ProductKey ProductKey Int32 )

            return value;
        }
    }
}
