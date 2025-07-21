using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSortView                               ModelPrimitiveType bool bool bool Bool
    // 014 InitialSelectedDisplayOrderIndex         ModelPrimitiveType int int int Int32
    // 018 SortDirection                            ModelEnumType SortDirection SortDirection SortDirection Int32
    // 020 <FilterOnIndices>k__BackingField         HashSet`1<int>[] IL2CPP_TYPE_SZARRAY
    public partial class FesIdolSearchPopupViewModel : DataModel
    {
        public bool                                     IsSortView                              { get; set; }
        public int                                      InitialSelectedDisplayOrderIndex        { get; set; }
        public SortDirection                            SortDirection                           { get; set; }

        public static FesIdolSearchPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolSearchPopupViewModel() { Pointer= p0 };

            value.IsSortView                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsSortView                  ( ModelPrimitiveType bool bool bool Bool )
            value.InitialSelectedDisplayOrderIndex          = GetInt32(new IntPtr(p + 0x014)); // 0x14 InitialSelectedDisplayOrderIndex ( ModelPrimitiveType int int int Int32 )
            value.SortDirection                             = (SortDirection)GetInt32(new IntPtr(p + 0x018)); // 0x18 SortDirection               ( ModelEnumType SortDirection SortDirection SortDirection Int32 )

            return value;
        }
    }
}
