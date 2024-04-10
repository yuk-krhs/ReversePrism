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
    public partial class PurchaseUnityDmmGames : DataModel
    {
        public DmmGamesIapStoreExtension?               DmmGamesIapStoreExtension               { get; set; }
        public bool                                     IsSandbox                               { get; set; }
        public string                                   ApiToken                                { get; set; }

        public static PurchaseUnityDmmGames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityDmmGames() { Pointer= p0 };

            value.DmmGamesIapStoreExtension                 = GetObject<DmmGamesIapStoreExtension>(new IntPtr(p + 0x058), ReversePrism.DataModels.DmmGamesIapStoreExtension.FromPointer); // 0245A4BD4630 0x58 DmmGamesIapStoreExtension   ( 0001866E50E0 ModelClassType DmmGamesIapStoreExtension DmmGamesIapStoreExtension DmmGamesIapStoreExtension Pointer )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x060)); // 0245A4BD4650 0x60 IsSandbox                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ApiToken                                  = GetString(new IntPtr(p + 0x068)); // 0245A4BD4670 0x68 ApiToken                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
