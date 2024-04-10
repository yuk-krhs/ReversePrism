using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Position                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PredictiveParser : DataModel
    {
        public int                                      M_Position                              { get; set; }

        public static PredictiveParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PredictiveParser() { Pointer= p0 };

            value.M_Position                                = GetInt32(new IntPtr(p + 0x010)); // 02466793DB50 0x10 M_Position                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
