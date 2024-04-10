using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186671910 ModelPrimitiveType string string string String
    // 018 StoreSpecificId                          000186671910 ModelPrimitiveType string string string String
    // 020 Type                                     0001865A6330 ModelEnumType ProductType ProductType ProductType Int32
    // 024 Enabled                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 M_Payouts                                000185CF8958 ModelClassListType List`1<PayoutDefinition> List`1<PayoutDefinition> List<PayoutDefinition> Pointer
    public partial class ProductDefinition : DataModel
    {
        public string                                   Id                                      { get; set; }
        public string                                   StoreSpecificId                         { get; set; }
        public ProductType                              Type                                    { get; set; }
        public bool                                     Enabled                                 { get; set; }
        public List<PayoutDefinition>?                  M_Payouts                               { get; set; }

        public static ProductDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductDefinition() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0245A4C05F38 0x10 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.StoreSpecificId                           = GetString(new IntPtr(p + 0x018)); // 0245A4C05F58 0x18 StoreSpecificId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = (ProductType)GetInt32(new IntPtr(p + 0x020)); // 0245A4C05F78 0x20 Type                        ( 0001865A6330 ModelEnumType ProductType ProductType ProductType Int32 )
            value.Enabled                                   = GetBool(new IntPtr(p + 0x024)); // 0245A4C05F98 0x24 Enabled                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Payouts                                 = GetObjectList<PayoutDefinition>(new IntPtr(p + 0x028), ReversePrism.DataModels.PayoutDefinition.FromPointer); // 0245A4C05FB8 0x28 M_Payouts                   ( 000185CF8958 ModelClassListType List`1<PayoutDefinition> List`1<PayoutDefinition> List<PayoutDefinition> Pointer )

            return value;
        }
    }
}
