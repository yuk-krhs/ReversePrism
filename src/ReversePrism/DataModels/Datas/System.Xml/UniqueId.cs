using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdLow                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 018 IdHigh                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 020 S                                        000186671910 ModelPrimitiveType string string string String
    // 000 guidLength                               int IL2CPP_TYPE_I4
    // 000 uuidLength                               int IL2CPP_TYPE_I4
    // 000 char2val                                 short[] IL2CPP_TYPE_SZARRAY
    // 000 val2char                                 string IL2CPP_TYPE_STRING
    public partial class UniqueId : DataModel
    {
        public long                                     IdLow                                   { get; set; }
        public long                                     IdHigh                                  { get; set; }
        public string                                   S                                       { get; set; }

        public static UniqueId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniqueId() { Pointer= p0 };

            value.IdLow                                     = GetInt64(new IntPtr(p + 0x010)); // 024667C63BC0 0x10 IdLow                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IdHigh                                    = GetInt64(new IntPtr(p + 0x018)); // 024667C63BE0 0x18 IdHigh                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.S                                         = GetString(new IntPtr(p + 0x020)); // 024667C63C00 0x20 S                           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
