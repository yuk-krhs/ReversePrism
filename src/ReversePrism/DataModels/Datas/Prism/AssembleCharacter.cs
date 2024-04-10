using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 paramDic                                 Dictionary`2<string, BodyParameter> IL2CPP_TYPE_GENERICINST
    // 008 flagSD                                   bool IL2CPP_TYPE_BOOLEAN
    public partial class AssembleCharacter : DataModel
    {

        public static AssembleCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssembleCharacter() { Pointer= p0 };


            return value;
        }
    }
}
