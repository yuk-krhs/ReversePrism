using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF seedWorkBuffer                           sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 EncWorkBuf                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Crypt                                    00018666AD90 ModelClassType AESCTRCrypt AESCTRCrypt AESCTRCrypt Pointer
    // 020 Sha1                                     0001866AD5C0 ModelClassType SHA1 SHA1 SHA1 Pointer
    public partial class RawAssetCoder : DataModel
    {
        public List<sbyte>?                             EncWorkBuf                              { get; set; }
        public AESCTRCrypt?                             Crypt                                   { get; set; }
        public SHA1?                                    Sha1                                    { get; set; }

        public static RawAssetCoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawAssetCoder() { Pointer= p0 };

            value.EncWorkBuf                                = GetSByteList(new IntPtr(p + 0x010)); // 0245A3E16B50 0x10 EncWorkBuf                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Crypt                                     = GetObject<AESCTRCrypt>(new IntPtr(p + 0x018), ReversePrism.DataModels.AESCTRCrypt.FromPointer); // 0245A3E16B70 0x18 Crypt                       ( 00018666AD90 ModelClassType AESCTRCrypt AESCTRCrypt AESCTRCrypt Pointer )
            value.Sha1                                      = GetObject<SHA1>(new IntPtr(p + 0x020), ReversePrism.DataModels.SHA1.FromPointer); // 0245A3E16B90 0x20 Sha1                        ( 0001866AD5C0 ModelClassType SHA1 SHA1 SHA1 Pointer )

            return value;
        }
    }
}
