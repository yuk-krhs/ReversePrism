using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Algorithm                                ModelPrimitiveType string string string String
    // 018 Salt                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Iterations                               ModelPrimitiveType int int int Int32
    // 028 Data                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class EncryptedPrivateKeyInfo : DataModel
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
            var value   = new EncryptedPrivateKeyInfo() { Pointer= p0 };

            value.Algorithm                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Algorithm                   ( ModelPrimitiveType string string string String )
            value.Salt                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Salt                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 Iterations                  ( ModelPrimitiveType int int int Int32 )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Data                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
