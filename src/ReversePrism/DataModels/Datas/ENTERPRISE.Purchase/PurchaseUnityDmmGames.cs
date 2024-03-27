using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 DmmGamesIapStoreExtension                0001866E50E0 ModelClassType DmmGamesIapStoreExtension DmmGamesIapStoreExtension DmmGamesIapStoreExtension Pointer
    // 060 IsSandbox                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 068 ApiToken                                 000186672F10 ModelPrimitiveType string string string String
    public partial class PurchaseUnityDmmGames
    {
        public DmmGamesIapStoreExtension?               DmmGamesIapStoreExtension               { get; set; }
        public bool                                     IsSandbox                               { get; set; }
        public string                                   ApiToken                                { get; set; }

        public static PurchaseUnityDmmGames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityDmmGames();

            value.DmmGamesIapStoreExtension                 = GetObject<DmmGamesIapStoreExtension>(new IntPtr(p + 0x058), ReversePrism.DataModels.DmmGamesIapStoreExtension.FromPointer); // 027004B7BE88 0x58 DmmGamesIapStoreExtension   ( 0001866E50E0 ModelClassType DmmGamesIapStoreExtension DmmGamesIapStoreExtension DmmGamesIapStoreExtension Pointer )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x060)); // 027004B7BEA8 0x60 IsSandbox                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ApiToken                                  = GetString(new IntPtr(p + 0x068)); // 027004B7BEC8 0x68 ApiToken                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
