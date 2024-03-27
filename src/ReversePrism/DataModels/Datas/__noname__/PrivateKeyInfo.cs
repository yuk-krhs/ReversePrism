using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Algorithm                                000186671910 ModelPrimitiveType string string string String
    // 020 Key                                      000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 List                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class PrivateKeyInfo
    {
        public int                                      Version                                 { get; set; }
        public string                                   Algorithm                               { get; set; }
        public List<sbyte>?                             Key                                     { get; set; }
        public ArrayList?                               List                                    { get; set; }

        public static PrivateKeyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivateKeyInfo();

            value.Version                                   = GetInt32(new IntPtr(p + 0x010)); // 0270DB37BB38 0x10 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Algorithm                                 = GetString(new IntPtr(p + 0x018)); // 0270DB37BB58 0x18 Algorithm                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Key                                       = GetSByteList(new IntPtr(p + 0x020)); // 0270DB37BB78 0x20 Key                         ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0270DB37BB98 0x28 List                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
