using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 count                                    int IL2CPP_TYPE_I4
    // 000 length                                   int IL2CPP_TYPE_I4
    // 000 arrayBytes                               sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class SerializationData : DataModel
    {

        public static SerializationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationData() { Pointer= p0 };


            return value;
        }
    }
}
