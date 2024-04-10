using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Costume                                  000186743A10 ModelClassType ICostumeStatus ICostumeStatus ICostumeStatus Pointer
    // 018 Hairstyle                                000186564600 ModelClassType IHairstyleStatus IHairstyleStatus IHairstyleStatus Pointer
    // 020 Accessories                              IList`1<IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    public partial class CostumeSetData : DataModel
    {
        public ICostumeStatus?                          Costume                                 { get; set; }
        public IHairstyleStatus?                        Hairstyle                               { get; set; }

        public static CostumeSetData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetData() { Pointer= p0 };

            value.Costume                                   = GetObject<ICostumeStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICostumeStatus.FromPointer); // 0246631702D0 0x10 Costume                     ( 000186743A10 ModelClassType ICostumeStatus ICostumeStatus ICostumeStatus Pointer )
            value.Hairstyle                                 = GetObject<IHairstyleStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHairstyleStatus.FromPointer); // 0246631702F0 0x18 Hairstyle                   ( 000186564600 ModelClassType IHairstyleStatus IHairstyleStatus IHairstyleStatus Pointer )

            return value;
        }
    }
}
