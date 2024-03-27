using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxPreviewObjects                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 CommunicationBufferSize                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 PlaybackPositionUpdateInterval           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class InGamePreviewConfig
    {
        public int                                      MaxPreviewObjects                       { get; set; }
        public int                                      CommunicationBufferSize                 { get; set; }
        public int                                      PlaybackPositionUpdateInterval          { get; set; }

        public static InGamePreviewConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePreviewConfig();

            value.MaxPreviewObjects                         = GetInt32(new IntPtr(p + 0x010)); // 0270D11777A0 0x10 MaxPreviewObjects           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CommunicationBufferSize                   = GetInt32(new IntPtr(p + 0x014)); // 0270D11777C0 0x14 CommunicationBufferSize     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PlaybackPositionUpdateInterval            = GetInt32(new IntPtr(p + 0x018)); // 0270D11777E0 0x18 PlaybackPositionUpdateInterval ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
