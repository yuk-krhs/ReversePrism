using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReceiveTimeoutMs                         int IL2CPP_TYPE_I4
    // 010 ThreadPause                              ModelClassType IReadOnlyPauseController IReadOnlyPauseController IReadOnlyPauseController Pointer
    // 018 Db                                       ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 020 Api                                      ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer
    // 028 ConcurrencyController                    ModelClassType AdaptiveConcurrencyController AdaptiveConcurrencyController AdaptiveConcurrencyController Pointer
    // 030 SharedCommand                            ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer
    // 038 ProviderQueue                            ModelClassType HybridDownloadHandlerQueue HybridDownloadHandlerQueue HybridDownloadHandlerQueue Pointer
    // 040 SonicboomContext                         ModelClassType NativeDownloadContext NativeDownloadContext NativeDownloadContext Pointer
    // 048 InTransaction                            ModelPrimitiveType bool bool bool Bool
    // 049 HasUpdate                                ModelPrimitiveType bool bool bool Bool
    // 050 TotalDownloadBytes                       ModelPrimitiveType long long long Int64
    // 058 DownloadedBytes                          ModelPrimitiveType long long long Int64
    // 060 FatalError                               ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer
    public partial class NativeDownloadWorkerState : DataModel
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
            var value   = new NativeDownloadWorkerState() { Pointer= p0 };

            value.ThreadPause                               = GetObject<IReadOnlyPauseController>(new IntPtr(p + 0x010), ReversePrism.DataModels.IReadOnlyPauseController.FromPointer); // 0x10 ThreadPause                 ( ModelClassType IReadOnlyPauseController IReadOnlyPauseController IReadOnlyPauseController Pointer )
            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x018), ReversePrism.DataModels.CatalogDB.FromPointer); // 0x18 Db                          ( ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.Api                                       = GetObject<NativeDownloadApi>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeDownloadApi.FromPointer); // 0x20 Api                         ( ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer )
            value.ConcurrencyController                     = GetObject<AdaptiveConcurrencyController>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdaptiveConcurrencyController.FromPointer); // 0x28 ConcurrencyController       ( ModelClassType AdaptiveConcurrencyController AdaptiveConcurrencyController AdaptiveConcurrencyController Pointer )
            value.SharedCommand                             = GetObject<SharedDownloadStateCommand>(new IntPtr(p + 0x030), ReversePrism.DataModels.SharedDownloadStateCommand.FromPointer); // 0x30 SharedCommand               ( ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer )
            value.ProviderQueue                             = GetObject<HybridDownloadHandlerQueue>(new IntPtr(p + 0x038), ReversePrism.DataModels.HybridDownloadHandlerQueue.FromPointer); // 0x38 ProviderQueue               ( ModelClassType HybridDownloadHandlerQueue HybridDownloadHandlerQueue HybridDownloadHandlerQueue Pointer )
            value.SonicboomContext                          = GetObject<NativeDownloadContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.NativeDownloadContext.FromPointer); // 0x40 SonicboomContext            ( ModelClassType NativeDownloadContext NativeDownloadContext NativeDownloadContext Pointer )
            value.InTransaction                             = GetBool(new IntPtr(p + 0x048)); // 0x48 InTransaction               ( ModelPrimitiveType bool bool bool Bool )
            value.HasUpdate                                 = GetBool(new IntPtr(p + 0x049)); // 0x49 HasUpdate                   ( ModelPrimitiveType bool bool bool Bool )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x050)); // 0x50 TotalDownloadBytes          ( ModelPrimitiveType long long long Int64 )
            value.DownloadedBytes                           = GetInt64(new IntPtr(p + 0x058)); // 0x58 DownloadedBytes             ( ModelPrimitiveType long long long Int64 )
            value.FatalError                                = GetObject<AssetDownloadError>(new IntPtr(p + 0x060), ReversePrism.DataModels.AssetDownloadError.FromPointer); // 0x60 FatalError                  ( ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer )

            return value;
        }
    }
}
