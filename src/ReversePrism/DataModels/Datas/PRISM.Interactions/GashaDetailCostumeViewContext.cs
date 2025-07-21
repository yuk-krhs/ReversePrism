using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 018 OnCostumeDetail                          Subject`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 020 OnClickDressUpRoom                       Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    public partial class GashaDetailCostumeViewContext : DataModel
    {

        public static GashaDetailCostumeViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailCostumeViewContext() { Pointer= p0 };


            return value;
        }
    }
}
