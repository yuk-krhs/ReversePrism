using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 DmmGamesIapStoreExtension                ModelClassType DmmGamesIapStoreExtension DmmGamesIapStoreExtension DmmGamesIapStoreExtension Pointer
    // 060 IsSandbox                                ModelPrimitiveType bool bool bool Bool
    // 068 ApiToken                                 ModelPrimitiveType string string string String
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

            value.DmmGamesIapStoreExtension                 = GetObject<DmmGamesIapStoreExtension>(new IntPtr(p + 0x058), ReversePrism.DataModels.DmmGamesIapStoreExtension.FromPointer); // 0x58 DmmGamesIapStoreExtension   ( ModelClassType DmmGamesIapStoreExtension DmmGamesIapStoreExtension DmmGamesIapStoreExtension Pointer )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x060)); // 0x60 IsSandbox                   ( ModelPrimitiveType bool bool bool Bool )
            value.ApiToken                                  = GetString(new IntPtr(p + 0x068)); // 0x68 ApiToken                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
