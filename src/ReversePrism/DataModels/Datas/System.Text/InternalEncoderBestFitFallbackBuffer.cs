using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 _cBestFit                                char IL2CPP_TYPE_CHAR
    // 038 OFallback                                ModelClassType InternalEncoderBestFitFallback InternalEncoderBestFitFallback InternalEncoderBestFitFallback Pointer
    // 040 ICount                                   ModelPrimitiveType int int int Int32
    // 044 ISize                                    ModelPrimitiveType int int int Int32
    // 000 s_InternalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    public partial class InternalEncoderBestFitFallbackBuffer : DataModel
    {
        public InternalEncoderBestFitFallback?          OFallback                               { get; set; }
        public int                                      ICount                                  { get; set; }
        public int                                      ISize                                   { get; set; }

        public static InternalEncoderBestFitFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalEncoderBestFitFallbackBuffer() { Pointer= p0 };

            value.OFallback                                 = GetObject<InternalEncoderBestFitFallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.InternalEncoderBestFitFallback.FromPointer); // 0x38 OFallback                   ( ModelClassType InternalEncoderBestFitFallback InternalEncoderBestFitFallback InternalEncoderBestFitFallback Pointer )
            value.ICount                                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 ICount                      ( ModelPrimitiveType int int int Int32 )
            value.ISize                                     = GetInt32(new IntPtr(p + 0x044)); // 0x44 ISize                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
