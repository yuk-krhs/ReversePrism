using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FilterView                               000186621BE0 ModelClassType MissionFilterView MissionFilterView MissionFilterView Pointer
    public partial class MissionSortFilterContent : DataModel
    {
        public MissionFilterView?                       FilterView                              { get; set; }

        public static MissionSortFilterContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionSortFilterContent() { Pointer= p0 };

            value.FilterView                                = GetObject<MissionFilterView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MissionFilterView.FromPointer); // 0246655F6C30 0x60 FilterView                  ( 000186621BE0 ModelClassType MissionFilterView MissionFilterView MissionFilterView Pointer )

            return value;
        }
    }
}
