using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultCasualCostumeSetting              0001866360B0 ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer
    // 018 MstIdolId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 InStoryCostumeSetting                    000186635B90 ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer
    // 028 InOtherCostumeSetting                    000186635B90 ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer
    public partial class IdolBaseDetailCasualCostumeViewModel
    {
        public CostumeSetting?                          DefaultCasualCostumeSetting             { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public CostumeSetting?                          InStoryCostumeSetting                   { get; set; }
        public CostumeSetting?                          InOtherCostumeSetting                   { get; set; }

        public static IdolBaseDetailCasualCostumeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailCasualCostumeViewModel();

            value.DefaultCasualCostumeSetting               = GetObject<CostumeSetting>(new IntPtr(p + 0x010), ReversePrism.DataModels.CostumeSetting.FromPointer); // 0270D3172240 0x10 DefaultCasualCostumeSetting ( 0001866360B0 ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D3172260 0x18 MstIdolId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InStoryCostumeSetting                     = GetObject<CostumeSetting>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeSetting.FromPointer); // 0270D3172280 0x20 InStoryCostumeSetting       ( 000186635B90 ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer )
            value.InOtherCostumeSetting                     = GetObject<CostumeSetting>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeSetting.FromPointer); // 0270D31722A0 0x28 InOtherCostumeSetting       ( 000186635B90 ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer )

            return value;
        }
    }
}
