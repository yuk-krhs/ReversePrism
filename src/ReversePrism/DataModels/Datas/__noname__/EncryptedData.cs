using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Content                                  00018655A0C0 ModelClassType ContentInfo ContentInfo ContentInfo Pointer
    // 020 EncryptionAlgorithm                      00018655A0C0 ModelClassType ContentInfo ContentInfo ContentInfo Pointer
    // 028 Encrypted                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class EncryptedData : DataModel
    {
        public sbyte                                    Version                                 { get; set; }
        public ContentInfo?                             Content                                 { get; set; }
        public ContentInfo?                             EncryptionAlgorithm                     { get; set; }
        public List<sbyte>?                             Encrypted                               { get; set; }

        public static EncryptedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncryptedData() { Pointer= p0 };

            value.Version                                   = GetSByte(new IntPtr(p + 0x010)); // 02466B4069E0 0x10 Version                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Content                                   = GetObject<ContentInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ContentInfo.FromPointer); // 02466B406A00 0x18 Content                     ( 00018655A0C0 ModelClassType ContentInfo ContentInfo ContentInfo Pointer )
            value.EncryptionAlgorithm                       = GetObject<ContentInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.ContentInfo.FromPointer); // 02466B406A20 0x20 EncryptionAlgorithm         ( 00018655A0C0 ModelClassType ContentInfo ContentInfo ContentInfo Pointer )
            value.Encrypted                                 = GetSByteList(new IntPtr(p + 0x028)); // 02466B406A40 0x28 Encrypted                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
