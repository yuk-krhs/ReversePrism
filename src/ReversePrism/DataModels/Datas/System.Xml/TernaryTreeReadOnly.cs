using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NodeBuffer                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class TernaryTreeReadOnly : DataModel
    {
        public List<sbyte>?                             NodeBuffer                              { get; set; }

        public static TernaryTreeReadOnly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TernaryTreeReadOnly() { Pointer= p0 };

            value.NodeBuffer                                = GetSByteList(new IntPtr(p + 0x010)); // 0x10 NodeBuffer                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
