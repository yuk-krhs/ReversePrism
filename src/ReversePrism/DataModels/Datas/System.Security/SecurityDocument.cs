using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_data                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class SecurityDocument : DataModel
    {
        public List<sbyte>?                             M_data                                  { get; set; }

        public static SecurityDocument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecurityDocument() { Pointer= p0 };

            value.M_data                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 M_data                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
