using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDone                                   ModelPrimitiveType bool bool bool Bool
    // 018 TotalDownloadBytes                       ModelPrimitiveType long long long Int64
    // 020 TotalDownloadFiles                       ModelPrimitiveType int int int Int32
    // 024 DownloadedFiles                          ModelPrimitiveType int int int Int32
    // 028 Error                                    ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer
    // 030 CurrentDownloadedBytes                   ModelPrimitiveType long long long Int64
    // 038 PeakDownloadedBytes                      ModelPrimitiveType long long long Int64
    // 040 Db                                       ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 048 sizeProvider                             Func`1<ValueTuple`2<long, int>> IL2CPP_TYPE_GENERICINST
    // 050 enumProvider                             Func`2<INativeDownloadRequestListener, IEnumerable`1<INativeDownloadJob>> IL2CPP_TYPE_GENERICINST
    // 058 iterator                                 IEnumerator`1<INativeDownloadJob> IL2CPP_TYPE_GENERICINST
    // 000 emptyContext                             AssetDownloadContext IL2CPP_TYPE_CLASS
    public partial class AssetDownloadContext : DataModel
    {
        public bool                                     IsDone                                  { get; set; }
        public long                                     TotalDownloadBytes                      { get; set; }
        public int                                      TotalDownloadFiles                      { get; set; }
        public int                                      DownloadedFiles                         { get; set; }
        public AssetDownloadError?                      Error                                   { get; set; }
        public long                                     CurrentDownloadedBytes                  { get; set; }
        public long                                     PeakDownloadedBytes                     { get; set; }
        public CatalogDB?                               Db                                      { get; set; }

        public static AssetDownloadContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetDownloadContext() { Pointer= p0 };

            value.IsDone                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 IsDone                      ( ModelPrimitiveType bool bool bool Bool )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x018)); // 0x18 TotalDownloadBytes          ( ModelPrimitiveType long long long Int64 )
            value.TotalDownloadFiles                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalDownloadFiles          ( ModelPrimitiveType int int int Int32 )
            value.DownloadedFiles                           = GetInt32(new IntPtr(p + 0x024)); // 0x24 DownloadedFiles             ( ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<AssetDownloadError>(new IntPtr(p + 0x028), ReversePrism.DataModels.AssetDownloadError.FromPointer); // 0x28 Error                       ( ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer )
            value.CurrentDownloadedBytes                    = GetInt64(new IntPtr(p + 0x030)); // 0x30 CurrentDownloadedBytes      ( ModelPrimitiveType long long long Int64 )
            value.PeakDownloadedBytes                       = GetInt64(new IntPtr(p + 0x038)); // 0x38 PeakDownloadedBytes         ( ModelPrimitiveType long long long Int64 )
            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x040), ReversePrism.DataModels.CatalogDB.FromPointer); // 0x40 Db                          ( ModelClassType CatalogDB CatalogDB CatalogDB Pointer )

            return value;
        }
    }
}
