using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlgorithmId                              ModelPrimitiveType string string string String
    // 018 Parameters                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class AlgorithmIdentifier : DataModel
    {
        public string                                   AlgorithmId                             { get; set; }
        public List<sbyte>?                             Parameters                              { get; set; }

        public static AlgorithmIdentifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AlgorithmIdentifier() { Pointer= p0 };

            value.AlgorithmId                               = GetString(new IntPtr(p + 0x010)); // 0x10 AlgorithmId                 ( ModelPrimitiveType string string string String )
            value.Parameters                                = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Parameters                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
