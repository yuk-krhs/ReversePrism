using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Listener                                 ModelClassType INativeDownloadRequestListener INativeDownloadRequestListener INativeDownloadRequestListener Pointer
    // 018 Row                                      ModelClassType AssetInfoRow AssetInfoRow AssetInfoRow Pointer
    // 020 UrlBase                                  ModelPrimitiveType string string string String
    // 028 LocalBase                                ModelPrimitiveType string string string String
    // 030 Postfix                                  ModelPrimitiveType string string string String
    // 038 DownloadedSize                           ModelPrimitiveType long long long Int64
    // 040 BeforeDownloadedSize                     ModelPrimitiveType long long long Int64
    // 048 RetryCount                               ModelPrimitiveType int int int Int32
    // 04C Strategy                                 ModelPrimitiveType int int int Int32
    // 050 ErrorFlag                                ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32
    // 054 ErrorCode                                ModelPrimitiveType int int int Int32
    public partial class NativeDownloadJob : DataModel
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
            var value   = new NativeDownloadJob() { Pointer= p0 };

            value.Listener                                  = GetObject<INativeDownloadRequestListener>(new IntPtr(p + 0x010), ReversePrism.DataModels.INativeDownloadRequestListener.FromPointer); // 0x10 Listener                    ( ModelClassType INativeDownloadRequestListener INativeDownloadRequestListener INativeDownloadRequestListener Pointer )
            value.Row                                       = GetObject<AssetInfoRow>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetInfoRow.FromPointer); // 0x18 Row                         ( ModelClassType AssetInfoRow AssetInfoRow AssetInfoRow Pointer )
            value.UrlBase                                   = GetString(new IntPtr(p + 0x020)); // 0x20 UrlBase                     ( ModelPrimitiveType string string string String )
            value.LocalBase                                 = GetString(new IntPtr(p + 0x028)); // 0x28 LocalBase                   ( ModelPrimitiveType string string string String )
            value.Postfix                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Postfix                     ( ModelPrimitiveType string string string String )
            value.DownloadedSize                            = GetInt64(new IntPtr(p + 0x038)); // 0x38 DownloadedSize              ( ModelPrimitiveType long long long Int64 )
            value.BeforeDownloadedSize                      = GetInt64(new IntPtr(p + 0x040)); // 0x40 BeforeDownloadedSize        ( ModelPrimitiveType long long long Int64 )
            value.RetryCount                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 RetryCount                  ( ModelPrimitiveType int int int Int32 )
            value.Strategy                                  = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Strategy                    ( ModelPrimitiveType int int int Int32 )
            value.ErrorFlag                                 = (SonicboomDownloadErrorFlag)GetInt32(new IntPtr(p + 0x050)); // 0x50 ErrorFlag                   ( ModelEnumType SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag SonicboomDownloadErrorFlag Int32 )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x054)); // 0x54 ErrorCode                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
