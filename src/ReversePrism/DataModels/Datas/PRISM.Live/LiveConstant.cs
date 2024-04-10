using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnitMaxIdolCount                         int IL2CPP_TYPE_I4
    // 000 BaseLBMaxUsage                           int IL2CPP_TYPE_I4
    // 000 UseOtherCharacterCostumeUnitNumber       int IL2CPP_TYPE_I4
    public partial class LiveConstant : DataModel
    {

        public static LiveConstant? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveConstant() { Pointer= p0 };


            return value;
        }
    }
}
