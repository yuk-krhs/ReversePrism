using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReceiveTimeoutMs                         int IL2CPP_TYPE_I4
    // 010 ThreadPause                              00018660F520 ModelClassType IReadOnlyPauseController IReadOnlyPauseController IReadOnlyPauseController Pointer
    // 018 Db                                       00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 020 Api                                      000186685CD0 ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer
    // 028 ConcurrencyController                    000186681F00 ModelClassType AdaptiveConcurrencyController AdaptiveConcurrencyController AdaptiveConcurrencyController Pointer
    // 030 SharedCommand                            0001867523A0 ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer
    // 038 ProviderQueue                            0001866E8E00 ModelClassType HybridDownloadHandlerQueue HybridDownloadHandlerQueue HybridDownloadHandlerQueue Pointer
    // 040 SonicboomContext                         0001866861B0 ModelClassType NativeDownloadContext NativeDownloadContext NativeDownloadContext Pointer
    // 048 InTransaction                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 HasUpdate                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 TotalDownloadBytes                       0001865F7700 ModelPrimitiveType long long long Int64
    // 058 DownloadedBytes                          0001865F7700 ModelPrimitiveType long long long Int64
    // 060 FatalError                               0001866E5710 ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer
    public partial class NativeDownloadWorkerState
    {
        public IReadOnlyPauseController?                ThreadPause                             { get; set; }
        public CatalogDB?                               Db                                      { get; set; }
        public NativeDownloadApi?                       Api                                     { get; set; }
        public AdaptiveConcurrencyController?           ConcurrencyController                   { get; set; }
        public SharedDownloadStateCommand?              SharedCommand                           { get; set; }
        public HybridDownloadHandlerQueue?              ProviderQueue                           { get; set; }
        public NativeDownloadContext?                   SonicboomContext                        { get; set; }
        public bool                                     InTransaction                           { get; set; }
        public bool                                     HasUpdate                               { get; set; }
        public long                                     TotalDownloadBytes                      { get; set; }
        public long                                     DownloadedBytes                         { get; set; }
        public AssetDownloadError?                      FatalError                              { get; set; }

        public static NativeDownloadWorkerState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadWorkerState();

            value.ThreadPause                               = GetObject<IReadOnlyPauseController>(new IntPtr(p + 0x010), ReversePrism.DataModels.IReadOnlyPauseController.FromPointer); // 027003E2D610 0x10 ThreadPause                 ( 00018660F520 ModelClassType IReadOnlyPauseController IReadOnlyPauseController IReadOnlyPauseController Pointer )
            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x018), ReversePrism.DataModels.CatalogDB.FromPointer); // 027003E2D630 0x18 Db                          ( 00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.Api                                       = GetObject<NativeDownloadApi>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeDownloadApi.FromPointer); // 027003E2D650 0x20 Api                         ( 000186685CD0 ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer )
            value.ConcurrencyController                     = GetObject<AdaptiveConcurrencyController>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdaptiveConcurrencyController.FromPointer); // 027003E2D670 0x28 ConcurrencyController       ( 000186681F00 ModelClassType AdaptiveConcurrencyController AdaptiveConcurrencyController AdaptiveConcurrencyController Pointer )
            value.SharedCommand                             = GetObject<SharedDownloadStateCommand>(new IntPtr(p + 0x030), ReversePrism.DataModels.SharedDownloadStateCommand.FromPointer); // 027003E2D690 0x30 SharedCommand               ( 0001867523A0 ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer )
            value.ProviderQueue                             = GetObject<HybridDownloadHandlerQueue>(new IntPtr(p + 0x038), ReversePrism.DataModels.HybridDownloadHandlerQueue.FromPointer); // 027003E2D6B0 0x38 ProviderQueue               ( 0001866E8E00 ModelClassType HybridDownloadHandlerQueue HybridDownloadHandlerQueue HybridDownloadHandlerQueue Pointer )
            value.SonicboomContext                          = GetObject<NativeDownloadContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.NativeDownloadContext.FromPointer); // 027003E2D6D0 0x40 SonicboomContext            ( 0001866861B0 ModelClassType NativeDownloadContext NativeDownloadContext NativeDownloadContext Pointer )
            value.InTransaction                             = GetBool(new IntPtr(p + 0x048)); // 027003E2D6F0 0x48 InTransaction               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasUpdate                                 = GetBool(new IntPtr(p + 0x049)); // 027003E2D710 0x49 HasUpdate                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x050)); // 027003E2D730 0x50 TotalDownloadBytes          ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DownloadedBytes                           = GetInt64(new IntPtr(p + 0x058)); // 027003E2D750 0x58 DownloadedBytes             ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.FatalError                                = GetObject<AssetDownloadError>(new IntPtr(p + 0x060), ReversePrism.DataModels.AssetDownloadError.FromPointer); // 027003E2D770 0x60 FatalError                  ( 0001866E5710 ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer )

            return value;
        }
    }
}
