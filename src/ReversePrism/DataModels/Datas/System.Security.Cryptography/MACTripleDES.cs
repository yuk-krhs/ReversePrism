using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_encryptor                              000186746CA0 ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer
    // 038 Cs                                       00018665F5D0 ModelClassType CryptoStream CryptoStream CryptoStream Pointer
    // 040 Ts                                       00018661C500 ModelClassType TailStream TailStream TailStream Pointer
    // 048 M_bytesPerBlock                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 Des                                      0001866B3A00 ModelClassType TripleDES TripleDES TripleDES Pointer
    public partial class MACTripleDES
    {
        public ICryptoTransform?                        M_encryptor                             { get; set; }
        public CryptoStream?                            Cs                                      { get; set; }
        public TailStream?                              Ts                                      { get; set; }
        public int                                      M_bytesPerBlock                         { get; set; }
        public TripleDES?                               Des                                     { get; set; }

        public static MACTripleDES? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MACTripleDES();

            value.M_encryptor                               = GetObject<ICryptoTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICryptoTransform.FromPointer); // 02700422FEB8 0x30 M_encryptor                 ( 000186746CA0 ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer )
            value.Cs                                        = GetObject<CryptoStream>(new IntPtr(p + 0x038), ReversePrism.DataModels.CryptoStream.FromPointer); // 02700422FED8 0x38 Cs                          ( 00018665F5D0 ModelClassType CryptoStream CryptoStream CryptoStream Pointer )
            value.Ts                                        = GetObject<TailStream>(new IntPtr(p + 0x040), ReversePrism.DataModels.TailStream.FromPointer); // 02700422FEF8 0x40 Ts                          ( 00018661C500 ModelClassType TailStream TailStream TailStream Pointer )
            value.M_bytesPerBlock                           = GetInt32(new IntPtr(p + 0x048)); // 02700422FF18 0x48 M_bytesPerBlock             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Des                                       = GetObject<TripleDES>(new IntPtr(p + 0x050), ReversePrism.DataModels.TripleDES.FromPointer); // 02700422FF38 0x50 Des                         ( 0001866B3A00 ModelClassType TripleDES TripleDES TripleDES Pointer )

            return value;
        }
    }
}
