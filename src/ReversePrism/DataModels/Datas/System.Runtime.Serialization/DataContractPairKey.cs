using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 object1                                  <object> IL2CPP_TYPE_OBJECT
    // 018 object2                                  <object> IL2CPP_TYPE_OBJECT
    public partial class DataContractPairKey : DataModel
    {

        public static DataContractPairKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractPairKey() { Pointer= p0 };


            return value;
        }
    }
}
