using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 <MstCostume>k__BackingField              ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    public partial class UnitIdolWithMstCostume : DataModel
    {

        public static UnitIdolWithMstCostume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIdolWithMstCostume() { Pointer= p0 };


            return value;
        }
    }
}
