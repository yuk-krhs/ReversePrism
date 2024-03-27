using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Algorithm                                000186671910 ModelPrimitiveType string string string String
    // 018 Salt                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Iterations                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Data                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class EncryptedPrivateKeyInfo
    {
        public string                                   Algorithm                               { get; set; }
        public List<sbyte>?                             Salt                                    { get; set; }
        public int                                      Iterations                              { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static EncryptedPrivateKeyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncryptedPrivateKeyInfo();

            value.Algorithm                                 = GetString(new IntPtr(p + 0x010)); // 0270DB3814A8 0x10 Algorithm                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Salt                                      = GetSByteList(new IntPtr(p + 0x018)); // 0270DB3814C8 0x18 Salt                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x020)); // 0270DB3814E8 0x20 Iterations                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x028)); // 0270DB381508 0x28 Data                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
