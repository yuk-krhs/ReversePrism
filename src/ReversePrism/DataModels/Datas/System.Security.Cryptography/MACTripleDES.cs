using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_encryptor                              ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer
    // 038 Cs                                       ModelClassType CryptoStream CryptoStream CryptoStream Pointer
    // 040 Ts                                       ModelClassType TailStream TailStream TailStream Pointer
    // 048 M_bytesPerBlock                          ModelPrimitiveType int int int Int32
    // 050 Des                                      ModelClassType TripleDES TripleDES TripleDES Pointer
    public partial class MACTripleDES : DataModel
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
            var value   = new MACTripleDES() { Pointer= p0 };

            value.M_encryptor                               = GetObject<ICryptoTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICryptoTransform.FromPointer); // 0x30 M_encryptor                 ( ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer )
            value.Cs                                        = GetObject<CryptoStream>(new IntPtr(p + 0x038), ReversePrism.DataModels.CryptoStream.FromPointer); // 0x38 Cs                          ( ModelClassType CryptoStream CryptoStream CryptoStream Pointer )
            value.Ts                                        = GetObject<TailStream>(new IntPtr(p + 0x040), ReversePrism.DataModels.TailStream.FromPointer); // 0x40 Ts                          ( ModelClassType TailStream TailStream TailStream Pointer )
            value.M_bytesPerBlock                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_bytesPerBlock             ( ModelPrimitiveType int int int Int32 )
            value.Des                                       = GetObject<TripleDES>(new IntPtr(p + 0x050), ReversePrism.DataModels.TripleDES.FromPointer); // 0x50 Des                         ( ModelClassType TripleDES TripleDES TripleDES Pointer )

            return value;
        }
    }
}
