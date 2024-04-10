using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSortView                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 InitialSelectedDisplayOrderIndex         0001865F4260 ModelPrimitiveType int int int Int32
    // 018 SortDirection                            00018652E880 ModelEnumType SortDirection SortDirection SortDirection Int32
    // 020 <FilterOnIndices>k__BackingField         HashSet`1<int>[] IL2CPP_TYPE_SZARRAY
    public partial class FesUnitSearchPopupViewModel : DataModel
    {
        public bool                                     IsSortView                              { get; set; }
        public int                                      InitialSelectedDisplayOrderIndex        { get; set; }
        public SortDirection                            SortDirection                           { get; set; }

        public static FesUnitSearchPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitSearchPopupViewModel() { Pointer= p0 };

            value.IsSortView                                = GetBool(new IntPtr(p + 0x010)); // 024665F912F8 0x10 IsSortView                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.InitialSelectedDisplayOrderIndex          = GetInt32(new IntPtr(p + 0x014)); // 024665F91318 0x14 InitialSelectedDisplayOrderIndex ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = (SortDirection)GetInt32(new IntPtr(p + 0x018)); // 024665F91338 0x18 SortDirection               ( 00018652E880 ModelEnumType SortDirection SortDirection SortDirection Int32 )

            return value;
        }
    }
}
