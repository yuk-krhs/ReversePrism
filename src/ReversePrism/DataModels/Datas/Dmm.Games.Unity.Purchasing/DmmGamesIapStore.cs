using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_API_RETRY_COUNT                      int IL2CPP_TYPE_I4
    // 010 Callback                                 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 _initModel                               Nullable`1<SdkInitModel> IL2CPP_TYPE_GENERICINST
    // 050 ApiToken                                 000186672F10 ModelPrimitiveType string string string String
    // 058 IsSandbox                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 UserKey                                  00018674CC50 ModelEnumType UserKey UserKey UserKey Int32
    // 070 Inventory                                0001866E55A0 ModelClassType DmmGamesIapStoreInventory DmmGamesIapStoreInventory DmmGamesIapStoreInventory Pointer
    // 008 _dmmGamesIapError                        DmmGamesIapStoreError IL2CPP_TYPE_CLASS
    // 078 ProductIcon                              000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 080 _productIcons                            Dictionary`2<string, Texture2D> IL2CPP_TYPE_GENERICINST
    public partial class DmmGamesIapStore
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
            var value   = new DmmGamesIapStore();

            value.Callback                                  = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 027004BB5B40 0x10 Callback                    ( 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.ApiToken                                  = GetString(new IntPtr(p + 0x050)); // 027004BB5B80 0x50 ApiToken                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x058)); // 027004BB5BA0 0x58 IsSandbox                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UserKey                                   = (UserKey)GetInt32(new IntPtr(p + 0x060)); // 027004BB5BC0 0x60 UserKey                     ( 00018674CC50 ModelEnumType UserKey UserKey UserKey Int32 )
            value.Inventory                                 = GetObject<DmmGamesIapStoreInventory>(new IntPtr(p + 0x070), ReversePrism.DataModels.DmmGamesIapStoreInventory.FromPointer); // 027004BB5BE0 0x70 Inventory                   ( 0001866E55A0 ModelClassType DmmGamesIapStoreInventory DmmGamesIapStoreInventory DmmGamesIapStoreInventory Pointer )
            value.ProductIcon                               = GetObject<Texture2D>(new IntPtr(p + 0x078), ReversePrism.DataModels.Texture2D.FromPointer); // 027004BB5C20 0x78 ProductIcon                 ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
