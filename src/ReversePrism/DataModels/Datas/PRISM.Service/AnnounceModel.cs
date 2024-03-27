using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PageLimit                                int IL2CPP_TYPE_I4
    // 010 categoryInfos                            Dictionary`2<AnnounceCategory, CategoryInfo> IL2CPP_TYPE_GENERICINST
    // 018 AnnounceService                          0001866F6F10 ModelClassType IAnnounceService IAnnounceService IAnnounceService Pointer
    // 020 VisibleCategories                        000185D17F58 ModelEnumListType IReadOnlyList`1<AnnounceCategory> IReadOnlyList`1<AnnounceCategory> List<AnnounceCategory> Pointer
    public partial class AnnounceModel
    {
        public IAnnounceService?                        AnnounceService                         { get; set; }
        public List<AnnounceCategory>?                  VisibleCategories                       { get; set; }

        public static AnnounceModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceModel();

            value.AnnounceService                           = GetObject<IAnnounceService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAnnounceService.FromPointer); // 027007324BE0 0x18 AnnounceService             ( 0001866F6F10 ModelClassType IAnnounceService IAnnounceService IAnnounceService Pointer )
            value.VisibleCategories                         = GetEnumList<AnnounceCategory>(new IntPtr(p + 0x020)); // 027007324C00 0x20 VisibleCategories           ( 000185D17F58 ModelEnumListType IReadOnlyList`1<AnnounceCategory> IReadOnlyList`1<AnnounceCategory> List<AnnounceCategory> Pointer )

            return value;
        }
    }
}
