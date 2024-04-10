using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxDrawMeshInstanceCount                int IL2CPP_TYPE_I4
    // 008 s_RenderInstancedDataLayouts             Dictionary`2<int, RenderInstancedDataLayout> IL2CPP_TYPE_GENERICINST
    public partial class Graphics : DataModel
    {

        public static Graphics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Graphics() { Pointer= p0 };


            return value;
        }
    }
}
