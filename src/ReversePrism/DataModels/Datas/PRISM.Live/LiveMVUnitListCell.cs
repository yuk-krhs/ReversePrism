using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 DressIcons                               ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 080 HairstyleIcons                           ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    public partial class LiveMVUnitListCell : DataModel
    {
        public List<CostumeIcon>?                       DressIcons                              { get; set; }
        public List<CostumeIcon>?                       HairstyleIcons                          { get; set; }

        public static LiveMVUnitListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitListCell() { Pointer= p0 };

            value.DressIcons                                = GetObjectList<CostumeIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0x78 DressIcons                  ( ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.HairstyleIcons                            = GetObjectList<CostumeIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0x80 HairstyleIcons              ( ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )

            return value;
        }
    }
}
