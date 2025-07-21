using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _cBestFit                                char IL2CPP_TYPE_CHAR
    // 024 ICount                                   ModelPrimitiveType int int int Int32
    // 028 ISize                                    ModelPrimitiveType int int int Int32
    // 030 OFallback                                ModelClassType InternalDecoderBestFitFallback InternalDecoderBestFitFallback InternalDecoderBestFitFallback Pointer
    // 000 s_InternalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    public partial class InternalDecoderBestFitFallbackBuffer : DataModel
    {
        public int                                      ICount                                  { get; set; }
        public int                                      ISize                                   { get; set; }
        public InternalDecoderBestFitFallback?          OFallback                               { get; set; }

        public static InternalDecoderBestFitFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalDecoderBestFitFallbackBuffer() { Pointer= p0 };

            value.ICount                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 ICount                      ( ModelPrimitiveType int int int Int32 )
            value.ISize                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 ISize                       ( ModelPrimitiveType int int int Int32 )
            value.OFallback                                 = GetObject<InternalDecoderBestFitFallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.InternalDecoderBestFitFallback.FromPointer); // 0x30 OFallback                   ( ModelClassType InternalDecoderBestFitFallback InternalDecoderBestFitFallback InternalDecoderBestFitFallback Pointer )

            return value;
        }
    }
}
