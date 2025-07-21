using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DressIcons                               ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    // 028 HairstyleIcons                           ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    public partial class LiveUnitEditCostumeView : DataModel
    {
        public List<LiveUnitEditCostumeIcon>?           DressIcons                              { get; set; }
        public List<LiveUnitEditCostumeIcon>?           HairstyleIcons                          { get; set; }

        public static LiveUnitEditCostumeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCostumeView() { Pointer= p0 };

            value.DressIcons                                = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 0x20 DressIcons                  ( ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )
            value.HairstyleIcons                            = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 0x28 HairstyleIcons              ( ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )

            return value;
        }
    }
}
