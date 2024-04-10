using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CoreML                                   string IL2CPP_TYPE_STRING
    // 000 ONNX                                     string IL2CPP_TYPE_STRING
    // 000 TensorFlowLite                           string IL2CPP_TYPE_STRING
    public partial class GraphFormat : DataModel
    {

        public static GraphFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphFormat() { Pointer= p0 };


            return value;
        }
    }
}
