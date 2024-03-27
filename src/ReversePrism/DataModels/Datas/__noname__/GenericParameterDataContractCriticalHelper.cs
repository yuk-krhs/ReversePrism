using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ParameterPosition                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GenericParameterDataContractCriticalHelper
    {
        public int                                      ParameterPosition                       { get; set; }

        public static GenericParameterDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenericParameterDataContractCriticalHelper();

            value.ParameterPosition                         = GetInt32(new IntPtr(p + 0x060)); // 0270D7D3DDA0 0x60 ParameterPosition           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
