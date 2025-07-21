using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_API_RETRY_COUNT                      int IL2CPP_TYPE_I4
    // 010 Callback                                 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 _initModel                               Nullable`1<SdkInitModel> IL2CPP_TYPE_GENERICINST
    // 050 ApiToken                                 ModelPrimitiveType string string string String
    // 058 IsSandbox                                ModelPrimitiveType bool bool bool Bool
    // 060 UserKey                                  ModelEnumType UserKey UserKey UserKey Int32
    // 070 Inventory                                ModelClassType DmmGamesIapStoreInventory DmmGamesIapStoreInventory DmmGamesIapStoreInventory Pointer
    // 008 _dmmGamesIapError                        DmmGamesIapStoreError IL2CPP_TYPE_CLASS
    // 078 ProductIcon                              ModelClassType Texture2D Texture2D Texture2D Pointer
    // 080 _productIcons                            Dictionary`2<string, Texture2D> IL2CPP_TYPE_GENERICINST
    public partial class DmmGamesIapStore : DataModel
    {
        public IStoreCallback?                          Callback                                { get; set; }
        public string                                   ApiToken                                { get; set; }
        public bool                                     IsSandbox                               { get; set; }
        public UserKey                                  UserKey                                 { get; set; }
        public DmmGamesIapStoreInventory?               Inventory                               { get; set; }
        public Texture2D?                               ProductIcon                             { get; set; }

        public static DmmGamesIapStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStore() { Pointer= p0 };

            value.Callback                                  = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0x10 Callback                    ( ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.ApiToken                                  = GetString(new IntPtr(p + 0x050)); // 0x50 ApiToken                    ( ModelPrimitiveType string string string String )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsSandbox                   ( ModelPrimitiveType bool bool bool Bool )
            value.UserKey                                   = (UserKey)GetInt32(new IntPtr(p + 0x060)); // 0x60 UserKey                     ( ModelEnumType UserKey UserKey UserKey Int32 )
            value.Inventory                                 = GetObject<DmmGamesIapStoreInventory>(new IntPtr(p + 0x070), ReversePrism.DataModels.DmmGamesIapStoreInventory.FromPointer); // 0x70 Inventory                   ( ModelClassType DmmGamesIapStoreInventory DmmGamesIapStoreInventory DmmGamesIapStoreInventory Pointer )
            value.ProductIcon                               = GetObject<Texture2D>(new IntPtr(p + 0x078), ReversePrism.DataModels.Texture2D.FromPointer); // 0x78 ProductIcon                 ( ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
