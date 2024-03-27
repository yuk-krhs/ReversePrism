using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlgorithmId                              000186671BA0 ModelPrimitiveType string string string String
    // 018 Parameters                               000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class AlgorithmIdentifier
    {
        public string                                   AlgorithmId                             { get; set; }
        public List<sbyte>?                             Parameters                              { get; set; }

        public static AlgorithmIdentifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AlgorithmIdentifier();

            value.AlgorithmId                               = GetString(new IntPtr(p + 0x010)); // 0270D793FFB8 0x10 AlgorithmId                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Parameters                                = GetSByteList(new IntPtr(p + 0x018)); // 0270D793FFD8 0x18 Parameters                  ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
