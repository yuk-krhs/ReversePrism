using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_UpdateStepCount                        uint IL2CPP_TYPE_U4
    // 004 s_LatestUpdateType                       InputUpdateType IL2CPP_TYPE_VALUETYPE
    // 008 s_PlayerUpdateStepCount                  UpdateStepCount IL2CPP_TYPE_VALUETYPE
    public partial class InputUpdate : DataModel
    {

        public static InputUpdate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputUpdate() { Pointer= p0 };


            return value;
        }
    }
}
