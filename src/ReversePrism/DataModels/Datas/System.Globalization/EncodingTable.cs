using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 encodingDataPtr                          InternalEncodingDataItem[] IL2CPP_TYPE_SZARRAY
    // 008 codePageDataPtr                          InternalCodePageDataItem[] IL2CPP_TYPE_SZARRAY
    // 010 LastEncodingItem                         ModelPrimitiveType int int int Int32
    // 018 hashByName                               Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 020 hashByCodePage                           Dictionary`2<int, CodePageDataItem> IL2CPP_TYPE_GENERICINST
    public partial class EncodingTable : DataModel
    {
        public int                                      LastEncodingItem                        { get; set; }

        public static EncodingTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncodingTable() { Pointer= p0 };

            value.LastEncodingItem                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 LastEncodingItem            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
