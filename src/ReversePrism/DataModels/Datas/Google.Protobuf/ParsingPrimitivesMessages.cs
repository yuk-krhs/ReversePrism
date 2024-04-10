using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ZeroLengthMessageStreamData              sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class ParsingPrimitivesMessages : DataModel
    {

        public static ParsingPrimitivesMessages? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParsingPrimitivesMessages() { Pointer= p0 };


            return value;
        }
    }
}
