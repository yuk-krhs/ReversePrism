using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ColumnDesc                               ModelClassType SortColumnDescription SortColumnDescription SortColumnDescription Pointer
    // 018 Direction                                ModelEnumType SortDirection SortDirection SortDirection Int32
    public partial class SortedColumnState : DataModel
    {
        public SortColumnDescription?                   ColumnDesc                              { get; set; }
        public SortDirection                            Direction                               { get; set; }

        public static SortedColumnState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortedColumnState() { Pointer= p0 };

            value.ColumnDesc                                = GetObject<SortColumnDescription>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 0x10 ColumnDesc                  ( ModelClassType SortColumnDescription SortColumnDescription SortColumnDescription Pointer )
            value.Direction                                 = (SortDirection)GetInt32(new IntPtr(p + 0x018)); // 0x18 Direction                   ( ModelEnumType SortDirection SortDirection SortDirection Int32 )

            return value;
        }
    }
}
