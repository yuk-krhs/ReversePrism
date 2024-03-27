using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onSelectCell                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 018 resetOnIndices                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 020 IsSortView                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 024 InitialSelectedDisplayOrderIndex         0001865F4260 ModelPrimitiveType int int int Int32
    // 028 SortDirection                            00018652E880 ModelEnumType SortDirection SortDirection SortDirection Int32
    // 030 <FilterOnIndices>k__BackingField         HashSet`1<int>[] IL2CPP_TYPE_SZARRAY
    public partial class SupportCharaSearchPopupViewModel
    {
        public bool                                     IsSortView                              { get; set; }
        public int                                      InitialSelectedDisplayOrderIndex        { get; set; }
        public SortDirection                            SortDirection                           { get; set; }

        public static SupportCharaSearchPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSearchPopupViewModel();

            value.IsSortView                                = GetBool(new IntPtr(p + 0x020)); // 0270D5F97338 0x20 IsSortView                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.InitialSelectedDisplayOrderIndex          = GetInt32(new IntPtr(p + 0x024)); // 0270D5F97358 0x24 InitialSelectedDisplayOrderIndex ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = (SortDirection)GetInt32(new IntPtr(p + 0x028)); // 0270D5F97378 0x28 SortDirection               ( 00018652E880 ModelEnumType SortDirection SortDirection SortDirection Int32 )

            return value;
        }
    }
}
