using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitIdolData                             ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class ChangeUnitData : DataModel
    {
        public List<UnitIdol>?                          UnitIdolData                            { get; set; }

        public static ChangeUnitData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChangeUnitData() { Pointer= p0 };

            value.UnitIdolData                              = GetObjectList<UnitIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x10 UnitIdolData                ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
