using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ColumnDesc                               00018652D970 ModelClassType SortColumnDescription SortColumnDescription SortColumnDescription Pointer
    // 018 Direction                                00018652F480 ModelEnumType SortDirection SortDirection SortDirection Int32
    public partial class SortedColumnState
    {
        public SortColumnDescription?                   ColumnDesc                              { get; set; }
        public SortDirection                            Direction                               { get; set; }

        public static SortedColumnState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortedColumnState();

            value.ColumnDesc                                = GetObject<SortColumnDescription>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 0270068A0AB8 0x10 ColumnDesc                  ( 00018652D970 ModelClassType SortColumnDescription SortColumnDescription SortColumnDescription Pointer )
            value.Direction                                 = (SortDirection)GetInt32(new IntPtr(p + 0x018)); // 0270068A0AD8 0x18 Direction                   ( 00018652F480 ModelEnumType SortDirection SortDirection SortDirection Int32 )

            return value;
        }
    }
}
