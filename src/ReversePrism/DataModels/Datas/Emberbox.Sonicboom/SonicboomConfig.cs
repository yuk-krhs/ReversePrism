using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxStreamsLimit                          int IL2CPP_TYPE_I4
    // 000 MaxTotalConnectionsLimit                 int IL2CPP_TYPE_I4
    // 000 DefaultMaxDownloaders                    int IL2CPP_TYPE_I4
    // 000 DefaultNumDownloaders                    int IL2CPP_TYPE_I4
    // 000 DefaultNumWriters                        int IL2CPP_TYPE_I4
    // 000 DefaultMaxStreams                        int IL2CPP_TYPE_I4
    // 000 DefaultMaxTotalConnections               int IL2CPP_TYPE_I4
    // 000 DefaultConnectionTimeoutMs               int IL2CPP_TYPE_I4
    // 000 DefaultDownloadBufferBytes               int IL2CPP_TYPE_I4
    // 000 DefaultMaxDownloadBufferChunks           int IL2CPP_TYPE_I4
    // 000 MinDownloadBufferBytes                   int IL2CPP_TYPE_I4
    // 010 MaxDownloaders                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 DefaultNumDownloaders                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 NumWriters                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C MaxStreams                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 MaxTotalConnections                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 ConnectTimeoutMs                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 DownloadBufferBytes                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C MaxDownloadBufferChunks                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 DisableErrorBuffer                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 <nativePtr>k__BackingField               <int> IL2CPP_TYPE_I
    public partial class SonicboomConfig
    {
        public int                                      MaxDownloaders                          { get; set; }
        public int                                      DefaultNumDownloaders                   { get; set; }
        public int                                      NumWriters                              { get; set; }
        public int                                      MaxStreams                              { get; set; }
        public int                                      MaxTotalConnections                     { get; set; }
        public int                                      ConnectTimeoutMs                        { get; set; }
        public int                                      DownloadBufferBytes                     { get; set; }
        public int                                      MaxDownloadBufferChunks                 { get; set; }
        public bool                                     DisableErrorBuffer                      { get; set; }

        public static SonicboomConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SonicboomConfig();

            value.MaxDownloaders                            = GetInt32(new IntPtr(p + 0x010)); // 027003E2E6F8 0x10 MaxDownloaders              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DefaultNumDownloaders                     = GetInt32(new IntPtr(p + 0x014)); // 027003E2E718 0x14 DefaultNumDownloaders       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumWriters                                = GetInt32(new IntPtr(p + 0x018)); // 027003E2E738 0x18 NumWriters                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxStreams                                = GetInt32(new IntPtr(p + 0x01C)); // 027003E2E758 0x1C MaxStreams                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxTotalConnections                       = GetInt32(new IntPtr(p + 0x020)); // 027003E2E778 0x20 MaxTotalConnections         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConnectTimeoutMs                          = GetInt32(new IntPtr(p + 0x024)); // 027003E2E798 0x24 ConnectTimeoutMs            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DownloadBufferBytes                       = GetInt32(new IntPtr(p + 0x028)); // 027003E2E7B8 0x28 DownloadBufferBytes         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxDownloadBufferChunks                   = GetInt32(new IntPtr(p + 0x02C)); // 027003E2E7D8 0x2C MaxDownloadBufferChunks     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DisableErrorBuffer                        = GetBool(new IntPtr(p + 0x030)); // 027003E2E7F8 0x30 DisableErrorBuffer          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
