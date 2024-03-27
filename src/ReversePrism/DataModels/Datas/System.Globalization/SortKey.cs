using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   000186672F10 ModelPrimitiveType string string string String
    // 018 Key                                      000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Options                                  0001865EC260 ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    // 024 Lcid                                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class SortKey
    {
        public string                                   Source                                  { get; set; }
        public List<sbyte>?                             Key                                     { get; set; }
        public CompareOptions                           Options                                 { get; set; }
        public int                                      Lcid                                    { get; set; }

        public static SortKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortKey();

            value.Source                                    = GetString(new IntPtr(p + 0x010)); // 0270D6933900 0x10 Source                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Key                                       = GetSByteList(new IntPtr(p + 0x018)); // 0270D6933920 0x18 Key                         ( 000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Options                                   = (CompareOptions)GetInt32(new IntPtr(p + 0x020)); // 0270D6933940 0x20 Options                     ( 0001865EC260 ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )
            value.Lcid                                      = GetInt32(new IntPtr(p + 0x024)); // 0270D6933960 0x24 Lcid                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
