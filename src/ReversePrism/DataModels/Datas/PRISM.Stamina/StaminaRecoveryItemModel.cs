using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  ModelClassType ProductModel ProductModel ProductModel Pointer
    // 018 ItemId                                   ModelPrimitiveType int int int Int32
    // 020 Amount                                   ModelPrimitiveType long long long Int64
    // 028 ExpireDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 HasExpire                                ModelPrimitiveType bool bool bool Bool
    // 038 Master                                   ModelClassType StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel Pointer
    public partial class StaminaRecoveryItemModel : DataModel
    {
        public ProductModel?                            Product                                 { get; set; }
        public int                                      ItemId                                  { get; set; }
        public long                                     Amount                                  { get; set; }
        public DateTime                                 ExpireDate                              { get; set; }
        public bool                                     HasExpire                               { get; set; }
        public StaminaRecoveryItemMasterModel?          Master                                  { get; set; }

        public static StaminaRecoveryItemModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryItemModel() { Pointer= p0 };

            value.Product                                   = GetObject<ProductModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProductModel.FromPointer); // 0x10 Product                     ( ModelClassType ProductModel ProductModel ProductModel Pointer )
            value.ItemId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 ItemId                      ( ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x020)); // 0x20 Amount                      ( ModelPrimitiveType long long long Int64 )
            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x028)); // 0x28 ExpireDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.HasExpire                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 HasExpire                   ( ModelPrimitiveType bool bool bool Bool )
            value.Master                                    = GetObject<StaminaRecoveryItemMasterModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StaminaRecoveryItemMasterModel.FromPointer); // 0x38 Master                      ( ModelClassType StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel StaminaRecoveryItemMasterModel Pointer )

            return value;
        }
    }
}
