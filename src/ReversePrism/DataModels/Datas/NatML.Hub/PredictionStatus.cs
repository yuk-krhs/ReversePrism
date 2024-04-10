using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Waiting                                  string IL2CPP_TYPE_STRING
    // 000 Processing                               string IL2CPP_TYPE_STRING
    // 000 Completed                                string IL2CPP_TYPE_STRING
    public partial class PredictionStatus : DataModel
    {

        public static PredictionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PredictionStatus() { Pointer= p0 };


            return value;
        }
    }
}
