using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSetting                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Costume                                  000186743530 ModelClassType ICostumeStatus ICostumeStatus ICostumeStatus Pointer
    // 020 HairStyle                                0001865640E0 ModelClassType IHairstyleStatus IHairstyleStatus IHairstyleStatus Pointer
    // 028 <AccessoryList>k__BackingField           IEnumerable`1<IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    public partial class CostumeSetting
    {
        public bool                                     IsSetting                               { get; set; }
        public ICostumeStatus?                          Costume                                 { get; set; }
        public IHairstyleStatus?                        HairStyle                               { get; set; }

        public static CostumeSetting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetting();

            value.IsSetting                                 = GetBool(new IntPtr(p + 0x010)); // 027005D2BCA0 0x10 IsSetting                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Costume                                   = GetObject<ICostumeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICostumeStatus.FromPointer); // 027005D2BCC0 0x18 Costume                     ( 000186743530 ModelClassType ICostumeStatus ICostumeStatus ICostumeStatus Pointer )
            value.HairStyle                                 = GetObject<IHairstyleStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHairstyleStatus.FromPointer); // 027005D2BCE0 0x20 HairStyle                   ( 0001865640E0 ModelClassType IHairstyleStatus IHairstyleStatus IHairstyleStatus Pointer )

            return value;
        }
    }
}
