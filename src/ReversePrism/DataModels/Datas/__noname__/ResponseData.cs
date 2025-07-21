using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RequestPrediction                        ModelClassType Prediction Prediction Prediction Pointer
    public partial class ResponseData : DataModel
    {
        public Prediction?                              RequestPrediction                       { get; set; }

        public static ResponseData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseData() { Pointer= p0 };

            value.RequestPrediction                         = GetObject<Prediction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Prediction.FromPointer); // 0x10 RequestPrediction           ( ModelClassType Prediction Prediction Prediction Pointer )

            return value;
        }
    }
}
