using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  0001865A39D0 ModelClassType ProductModel ProductModel ProductModel Pointer
    // 018 ItemId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Amount                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 028 ExpireDate                               0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 IsExpire                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Master                                   000186565CD0 ModelClassType StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel Pointer
    public partial class StaminaRecoveryItemModel
    {
        public ProductModel?                            Product                                 { get; set; }
        public int                                      ItemId                                  { get; set; }
        public long                                     Amount                                  { get; set; }
        public DateTime                                 ExpireDate                              { get; set; }
        public bool                                     IsExpire                                { get; set; }
        public StaminaRecoveryItemMasterModel?          Master                                  { get; set; }

        public static StaminaRecoveryItemModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryItemModel();

            value.Product                                   = GetObject<ProductModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProductModel.FromPointer); // 0270D560E020 0x10 Product                     ( 0001865A39D0 ModelClassType ProductModel ProductModel ProductModel Pointer )
            value.ItemId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D560E040 0x18 ItemId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x020)); // 0270D560E060 0x20 Amount                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x028)); // 0270D560E080 0x28 ExpireDate                  ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IsExpire                                  = GetBool(new IntPtr(p + 0x030)); // 0270D560E0A0 0x30 IsExpire                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Master                                    = GetObject<StaminaRecoveryItemMasterModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StaminaRecoveryItemMasterModel.FromPointer); // 0270D560E0C0 0x38 Master                      ( 000186565CD0 ModelClassType StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel Pointer )

            return value;
        }
    }
}
