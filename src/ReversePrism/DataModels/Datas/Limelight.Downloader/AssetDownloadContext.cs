using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDone                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 TotalDownloadBytes                       0001865F8300 ModelPrimitiveType long long long Int64
    // 020 TotalDownloadFiles                       0001865F4260 ModelPrimitiveType int int int Int32
    // 024 DownloadedFiles                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Error                                    0001866E5710 ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer
    // 030 CurrentDownloadedBytes                   0001865F7700 ModelPrimitiveType long long long Int64
    // 038 PeakDownloadedBytes                      0001865F7700 ModelPrimitiveType long long long Int64
    // 040 Db                                       00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 048 sizeProvider                             Func`1<ValueTuple`2<long, int>> IL2CPP_TYPE_GENERICINST
    // 050 enumProvider                             Func`2<INativeDownloadRequestListener, IEnumerable`1<INativeDownloadJob>> IL2CPP_TYPE_GENERICINST
    // 058 iterator                                 IEnumerator`1<INativeDownloadJob> IL2CPP_TYPE_GENERICINST
    // 000 emptyContext                             AssetDownloadContext IL2CPP_TYPE_CLASS
    public partial class AssetDownloadContext
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
            var value   = new AssetDownloadContext();

            value.IsDone                                    = GetBool(new IntPtr(p + 0x010)); // 027004E05D00 0x10 IsDone                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x018)); // 027004E05D20 0x18 TotalDownloadBytes          ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.TotalDownloadFiles                        = GetInt32(new IntPtr(p + 0x020)); // 027004E05D40 0x20 TotalDownloadFiles          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DownloadedFiles                           = GetInt32(new IntPtr(p + 0x024)); // 027004E05D60 0x24 DownloadedFiles             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<AssetDownloadError>(new IntPtr(p + 0x028), ReversePrism.DataModels.AssetDownloadError.FromPointer); // 027004E05D80 0x28 Error                       ( 0001866E5710 ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer )
            value.CurrentDownloadedBytes                    = GetInt64(new IntPtr(p + 0x030)); // 027004E05DA0 0x30 CurrentDownloadedBytes      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PeakDownloadedBytes                       = GetInt64(new IntPtr(p + 0x038)); // 027004E05DC0 0x38 PeakDownloadedBytes         ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x040), ReversePrism.DataModels.CatalogDB.FromPointer); // 027004E05DE0 0x40 Db                          ( 00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer )

            return value;
        }
    }
}
