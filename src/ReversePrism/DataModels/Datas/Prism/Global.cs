using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 Global IL2CPP_TYPE_CLASS
    // 010 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 018 CancelSource                             ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 020 Subscribes                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 Core                                     ModelClassType LimelightCore LimelightCore LimelightCore Pointer
    // 030 SaveDataWasBroken                        ModelPrimitiveType bool bool bool Bool
    // 031 PermanentDataWasBroken                   ModelPrimitiveType bool bool bool Bool
    // 008 <FirstTimeBoot>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    // 038 Resources                                ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 040 Downloader                               ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer
    // 048 PermanentData                            ModelClassType SavedataDB SavedataDB SavedataDB Pointer
    // 050 UserSaveData                             ModelClassType SavedataDB SavedataDB SavedataDB Pointer
    public partial class Global : DataModel
    {
        public bool                                     Initialized                             { get; set; }
        public CancellationTokenSource?                 CancelSource                            { get; set; }
        public CompositeDisposable?                     Subscribes                              { get; set; }
        public LimelightCore?                           Core                                    { get; set; }
        public bool                                     SaveDataWasBroken                       { get; set; }
        public bool                                     PermanentDataWasBroken                  { get; set; }
        public ResourceLoader?                          Resources                               { get; set; }
        public ResourceDownloader?                      Downloader                              { get; set; }
        public SavedataDB?                              PermanentData                           { get; set; }
        public SavedataDB?                              UserSaveData                            { get; set; }

        public static Global? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Global() { Pointer= p0 };

            value.Initialized                               = GetBool(new IntPtr(p + 0x010)); // 0x10 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.CancelSource                              = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x18 CancelSource                ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Subscribes                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Subscribes                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Core                                      = GetObject<LimelightCore>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimelightCore.FromPointer); // 0x28 Core                        ( ModelClassType LimelightCore LimelightCore LimelightCore Pointer )
            value.SaveDataWasBroken                         = GetBool(new IntPtr(p + 0x030)); // 0x30 SaveDataWasBroken           ( ModelPrimitiveType bool bool bool Bool )
            value.PermanentDataWasBroken                    = GetBool(new IntPtr(p + 0x031)); // 0x31 PermanentDataWasBroken      ( ModelPrimitiveType bool bool bool Bool )
            value.Resources                                 = GetObject<ResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0x38 Resources                   ( ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.Downloader                                = GetObject<ResourceDownloader>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResourceDownloader.FromPointer); // 0x40 Downloader                  ( ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer )
            value.PermanentData                             = GetObject<SavedataDB>(new IntPtr(p + 0x048), ReversePrism.DataModels.SavedataDB.FromPointer); // 0x48 PermanentData               ( ModelClassType SavedataDB SavedataDB SavedataDB Pointer )
            value.UserSaveData                              = GetObject<SavedataDB>(new IntPtr(p + 0x050), ReversePrism.DataModels.SavedataDB.FromPointer); // 0x50 UserSaveData                ( ModelClassType SavedataDB SavedataDB SavedataDB Pointer )

            return value;
        }
    }
}
