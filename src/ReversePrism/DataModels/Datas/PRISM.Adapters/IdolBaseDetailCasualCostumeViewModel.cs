using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultCasualCostumeSetting              ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 020 InStoryCostumeSetting                    ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer
    // 028 InOtherCostumeSetting                    ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer
    public partial class IdolBaseDetailCasualCostumeViewModel : DataModel
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
            var value   = new IdolBaseDetailCasualCostumeViewModel() { Pointer= p0 };

            value.DefaultCasualCostumeSetting               = GetObject<CostumeSetting>(new IntPtr(p + 0x010), ReversePrism.DataModels.CostumeSetting.FromPointer); // 0x10 DefaultCasualCostumeSetting ( ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.InStoryCostumeSetting                     = GetObject<CostumeSetting>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeSetting.FromPointer); // 0x20 InStoryCostumeSetting       ( ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer )
            value.InOtherCostumeSetting                     = GetObject<CostumeSetting>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeSetting.FromPointer); // 0x28 InOtherCostumeSetting       ( ModelClassType CostumeSetting CostumeSetting CostumeSetting Pointer )

            return value;
        }
    }
}
