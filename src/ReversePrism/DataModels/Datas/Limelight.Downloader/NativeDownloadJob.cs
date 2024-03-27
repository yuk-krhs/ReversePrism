using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Listener                                 0001865BDE70 ModelClassType INativeDownloadRequestListener INativeDownloadRequestListener INativeDownloadRequestListener Pointer
    // 018 Row                                      00018672E510 ModelClassType AssetInfoRow AssetInfoRow AssetInfoRow Pointer
    // 020 UrlBase                                  000186672F10 ModelPrimitiveType string string string String
    // 028 LocalBase                                000186672F10 ModelPrimitiveType string string string String
    // 030 Postfix                                  000186672F10 ModelPrimitiveType string string string String
    // 038 DownloadedSize                           0001865F7700 ModelPrimitiveType long long long Int64
    // 040 BeforeDownloadedSize                     0001865F7700 ModelPrimitiveType long long long Int64
    // 048 RetryCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C Strategy                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 ErrorFlag                                00018652C1F0 ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32
    // 054 ErrorCode                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class NativeDownloadJob
    {
        public INativeDownloadRequestListener?          Listener                                { get; set; }
        public AssetInfoRow?                            Row                                     { get; set; }
        public string                                   UrlBase                                 { get; set; }
        public string                                   LocalBase                               { get; set; }
        public string                                   Postfix                                 { get; set; }
        public long                                     DownloadedSize                          { get; set; }
        public long                                     BeforeDownloadedSize                    { get; set; }
        public int                                      RetryCount                              { get; set; }
        public int                                      Strategy                                { get; set; }
        public SonicboomDownloadErrorFlag               ErrorFlag                               { get; set; }
        public int                                      ErrorCode                               { get; set; }

        public static NativeDownloadJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadJob();

            value.Listener                                  = GetObject<INativeDownloadRequestListener>(new IntPtr(p + 0x010), ReversePrism.DataModels.INativeDownloadRequestListener.FromPointer); // 0270DB4E6930 0x10 Listener                    ( 0001865BDE70 ModelClassType INativeDownloadRequestListener INativeDownloadRequestListener INativeDownloadRequestListener Pointer )
            value.Row                                       = GetObject<AssetInfoRow>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetInfoRow.FromPointer); // 0270DB4E6950 0x18 Row                         ( 00018672E510 ModelClassType AssetInfoRow AssetInfoRow AssetInfoRow Pointer )
            value.UrlBase                                   = GetString(new IntPtr(p + 0x020)); // 0270DB4E6970 0x20 UrlBase                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.LocalBase                                 = GetString(new IntPtr(p + 0x028)); // 0270DB4E6990 0x28 LocalBase                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.Postfix                                   = GetString(new IntPtr(p + 0x030)); // 0270DB4E69B0 0x30 Postfix                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.DownloadedSize                            = GetInt64(new IntPtr(p + 0x038)); // 0270DB4E69D0 0x38 DownloadedSize              ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.BeforeDownloadedSize                      = GetInt64(new IntPtr(p + 0x040)); // 0270DB4E69F0 0x40 BeforeDownloadedSize        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.RetryCount                                = GetInt32(new IntPtr(p + 0x048)); // 0270DB4E6A10 0x48 RetryCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Strategy                                  = GetInt32(new IntPtr(p + 0x04C)); // 0270DB4E6A30 0x4C Strategy                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ErrorFlag                                 = (SonicboomDownloadErrorFlag)GetInt32(new IntPtr(p + 0x050)); // 0270DB4E6A50 0x50 ErrorFlag                   ( 00018652C1F0 ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32 )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x054)); // 0270DB4E6A70 0x54 ErrorCode                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
