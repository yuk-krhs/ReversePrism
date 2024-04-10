using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 State                                    0001865DF880 ModelEnumType PurchaseState PurchaseState PurchaseState Int32
    // 028 Error                                    000186747D20 ModelClassType ErrorObject ErrorObject ErrorObject Pointer
    // 030 Store                                    0001866E38E0 ModelClassType DmmGamesIapStore DmmGamesIapStore DmmGamesIapStore Pointer
    // 038 Product                                  0001865A0170 ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer
    // 000 _locale                                  string IL2CPP_TYPE_STRING
    // 000 _quantity                                int IL2CPP_TYPE_I4
    // 040 DeveloperPayload                         000186671910 ModelPrimitiveType string string string String
    // 048 _successAction                           Action`1<Nullable`1<ReceiptModel>> IL2CPP_TYPE_GENERICINST
    // 050 _errorAction                             Action`1<ErrorObject> IL2CPP_TYPE_GENERICINST
    // 058 IsRetry                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C RetryState                               0001865DF880 ModelEnumType PurchaseState PurchaseState PurchaseState Int32
    // 060 _pointBalance                            Nullable`1<PointBalanceModel> IL2CPP_TYPE_GENERICINST
    // 070 _order                                   Nullable`1<OrderModel> IL2CPP_TYPE_GENERICINST
    // 0E0 _receipt                                 Nullable`1<ReceiptModel> IL2CPP_TYPE_GENERICINST
    // 148 IsUpdatePoint                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PurchaseProcess : DataModel
    {
        public PurchaseState                            State                                   { get; set; }
        public ErrorObject?                             Error                                   { get; set; }
        public DmmGamesIapStore?                        Store                                   { get; set; }
        public ProductDefinition?                       Product                                 { get; set; }
        public string                                   DeveloperPayload                        { get; set; }
        public bool                                     IsRetry                                 { get; set; }
        public PurchaseState                            RetryState                              { get; set; }
        public bool                                     IsUpdatePoint                           { get; set; }

        public static PurchaseProcess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseProcess() { Pointer= p0 };

            value.State                                     = (PurchaseState)GetInt32(new IntPtr(p + 0x020)); // 02466B4E7CD8 0x20 State                       ( 0001865DF880 ModelEnumType PurchaseState PurchaseState PurchaseState Int32 )
            value.Error                                     = GetObject<ErrorObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.ErrorObject.FromPointer); // 02466B4E7CF8 0x28 Error                       ( 000186747D20 ModelClassType ErrorObject ErrorObject ErrorObject Pointer )
            value.Store                                     = GetObject<DmmGamesIapStore>(new IntPtr(p + 0x030), ReversePrism.DataModels.DmmGamesIapStore.FromPointer); // 02466B4E7D18 0x30 Store                       ( 0001866E38E0 ModelClassType DmmGamesIapStore DmmGamesIapStore DmmGamesIapStore Pointer )
            value.Product                                   = GetObject<ProductDefinition>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductDefinition.FromPointer); // 02466B4E7D38 0x38 Product                     ( 0001865A0170 ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x040)); // 02466B4E7D98 0x40 DeveloperPayload            ( 000186671910 ModelPrimitiveType string string string String )
            value.IsRetry                                   = GetBool(new IntPtr(p + 0x058)); // 02466B4E7DF8 0x58 IsRetry                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RetryState                                = (PurchaseState)GetInt32(new IntPtr(p + 0x05C)); // 02466B4E7E18 0x5C RetryState                  ( 0001865DF880 ModelEnumType PurchaseState PurchaseState PurchaseState Int32 )
            value.IsUpdatePoint                             = GetBool(new IntPtr(p + 0x148)); // 02466B4E7E98 0x148 IsUpdatePoint               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
