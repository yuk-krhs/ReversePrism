using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BinaryTypeName                           string IL2CPP_TYPE_STRING
    // 000 BinaryToArrayName                        string IL2CPP_TYPE_STRING
    // 000 _reflectionObject                        ReflectionObject IL2CPP_TYPE_CLASS
    public partial class BinaryConverter : DataModel
    {

        public static BinaryConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryConverter() { Pointer= p0 };


            return value;
        }
    }
}
