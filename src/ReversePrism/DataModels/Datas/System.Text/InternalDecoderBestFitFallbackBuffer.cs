using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _cBestFit                                char IL2CPP_TYPE_CHAR
    // 024 ICount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ISize                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 OFallback                                00018671A640 ModelClassType InternalDecoderBestFitFallback InternalDecoderBestFitFallback InternalDecoderBestFitFallback Pointer
    // 000 s_InternalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    public partial class InternalDecoderBestFitFallbackBuffer
    {
        public int                                      ICount                                  { get; set; }
        public int                                      ISize                                   { get; set; }
        public InternalDecoderBestFitFallback?          OFallback                               { get; set; }

        public static InternalDecoderBestFitFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalDecoderBestFitFallbackBuffer();

            value.ICount                                    = GetInt32(new IntPtr(p + 0x024)); // 0270D6B61DE8 0x24 ICount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ISize                                     = GetInt32(new IntPtr(p + 0x028)); // 0270D6B61E08 0x28 ISize                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OFallback                                 = GetObject<InternalDecoderBestFitFallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.InternalDecoderBestFitFallback.FromPointer); // 0270D6B61E28 0x30 OFallback                   ( 00018671A640 ModelClassType InternalDecoderBestFitFallback InternalDecoderBestFitFallback InternalDecoderBestFitFallback Pointer )

            return value;
        }
    }
}
