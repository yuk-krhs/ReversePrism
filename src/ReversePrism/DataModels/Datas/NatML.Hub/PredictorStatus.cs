using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Draft                                    string IL2CPP_TYPE_STRING
    // 000 Pending                                  string IL2CPP_TYPE_STRING
    // 000 Review                                   string IL2CPP_TYPE_STRING
    // 000 Published                                string IL2CPP_TYPE_STRING
    // 000 Archived                                 string IL2CPP_TYPE_STRING
    public partial class PredictorStatus : DataModel
    {

        public static PredictorStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PredictorStatus() { Pointer= p0 };


            return value;
        }
    }
}
