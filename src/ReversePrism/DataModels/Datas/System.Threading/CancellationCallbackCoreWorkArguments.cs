using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _currArrayFragment                       SparselyPopulatedArrayFragment`1<CancellationCallbackInfo> IL2CPP_TYPE_GENERICINST
    // 018 CurrArrayIndex                           0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class CancellationCallbackCoreWorkArguments : DataModel
    {
        public int                                      CurrArrayIndex                          { get; set; }

        public static CancellationCallbackCoreWorkArguments? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationCallbackCoreWorkArguments() { Pointer= p0 };

            value.CurrArrayIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0245A4AC9C40 0x18 CurrArrayIndex              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
