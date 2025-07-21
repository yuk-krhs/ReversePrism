using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxPreviewObjects                        ModelPrimitiveType int int int Int32
    // 014 CommunicationBufferSize                  ModelPrimitiveType int int int Int32
    // 018 PlaybackPositionUpdateInterval           ModelPrimitiveType int int int Int32
    public partial class InGamePreviewConfig : DataModel
    {
        public int                                      MaxPreviewObjects                       { get; set; }
        public int                                      CommunicationBufferSize                 { get; set; }
        public int                                      PlaybackPositionUpdateInterval          { get; set; }

        public static InGamePreviewConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePreviewConfig() { Pointer= p0 };

            value.MaxPreviewObjects                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxPreviewObjects           ( ModelPrimitiveType int int int Int32 )
            value.CommunicationBufferSize                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 CommunicationBufferSize     ( ModelPrimitiveType int int int Int32 )
            value.PlaybackPositionUpdateInterval            = GetInt32(new IntPtr(p + 0x018)); // 0x18 PlaybackPositionUpdateInterval ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
