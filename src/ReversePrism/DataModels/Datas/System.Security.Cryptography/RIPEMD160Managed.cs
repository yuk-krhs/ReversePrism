using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Count                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 038 StateMD160                               000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 BlockDWords                              000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class RIPEMD160Managed
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public long                                     Count                                   { get; set; }
        public List<uint>?                              StateMD160                              { get; set; }
        public List<uint>?                              BlockDWords                             { get; set; }

        public static RIPEMD160Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RIPEMD160Managed();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 027004230C68 0x28 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Count                                     = GetInt64(new IntPtr(p + 0x030)); // 027004230C88 0x30 Count                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.StateMD160                                = GetUInt32List(new IntPtr(p + 0x038)); // 027004230CA8 0x38 StateMD160                  ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.BlockDWords                               = GetUInt32List(new IntPtr(p + 0x040)); // 027004230CC8 0x40 BlockDWords                 ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
