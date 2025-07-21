using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 018 NormalRate                               ModelPrimitiveType float float float Single
    // 01C PromiseRate                              ModelPrimitiveType float float float Single
    // 020 IsPickUp                                 ModelPrimitiveType bool bool bool Bool
    // 021 IsLimited                                ModelPrimitiveType bool bool bool Bool
    // 024 RowIndex                                 ModelPrimitiveType int int int Int32
    public partial class GashaRatesRateProductCellViewModel : DataModel
    {
        public IProductWithAmountStatus?                Product                                 { get; set; }
        public float                                    NormalRate                              { get; set; }
        public float                                    PromiseRate                             { get; set; }
        public bool                                     IsPickUp                                { get; set; }
        public bool                                     IsLimited                               { get; set; }
        public int                                      RowIndex                                { get; set; }

        public static GashaRatesRateProductCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRateProductCellViewModel() { Pointer= p0 };

            value.Product                                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x10 Product                     ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.NormalRate                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 NormalRate                  ( ModelPrimitiveType float float float Single )
            value.PromiseRate                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C PromiseRate                 ( ModelPrimitiveType float float float Single )
            value.IsPickUp                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsPickUp                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsLimited                                 = GetBool(new IntPtr(p + 0x021)); // 0x21 IsLimited                   ( ModelPrimitiveType bool bool bool Bool )
            value.RowIndex                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 RowIndex                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
