using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 Global IL2CPP_TYPE_CLASS
    // 010 Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 CancelSource                             0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 020 Subscribes                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 Core                                     00018652BD10 ModelClassType LimelightCore LimelightCore LimelightCore Pointer
    // 030 SaveDataWasBroken                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 PermanentDataWasBroken                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 <FirstTimeBoot>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    // 038 Resources                                00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 040 Downloader                               00018666DEB0 ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer
    // 048 PermanentData                            0001866BF960 ModelClassType SavedataDB SavedataDB SavedataDB Pointer
    // 050 UserSaveData                             0001866BF960 ModelClassType SavedataDB SavedataDB SavedataDB Pointer
    public partial class Global
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
            var value   = new Global();

            value.Initialized                               = GetBool(new IntPtr(p + 0x010)); // 027003C77870 0x10 Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CancelSource                              = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027003C77890 0x18 CancelSource                ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Subscribes                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027003C778B0 0x20 Subscribes                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Core                                      = GetObject<LimelightCore>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimelightCore.FromPointer); // 027003C778D0 0x28 Core                        ( 00018652BD10 ModelClassType LimelightCore LimelightCore LimelightCore Pointer )
            value.SaveDataWasBroken                         = GetBool(new IntPtr(p + 0x030)); // 027003C778F0 0x30 SaveDataWasBroken           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PermanentDataWasBroken                    = GetBool(new IntPtr(p + 0x031)); // 027003C77910 0x31 PermanentDataWasBroken      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Resources                                 = GetObject<ResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.ResourceLoader.FromPointer); // 027003C77950 0x38 Resources                   ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.Downloader                                = GetObject<ResourceDownloader>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResourceDownloader.FromPointer); // 027003C77970 0x40 Downloader                  ( 00018666DEB0 ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer )
            value.PermanentData                             = GetObject<SavedataDB>(new IntPtr(p + 0x048), ReversePrism.DataModels.SavedataDB.FromPointer); // 027003C77990 0x48 PermanentData               ( 0001866BF960 ModelClassType SavedataDB SavedataDB SavedataDB Pointer )
            value.UserSaveData                              = GetObject<SavedataDB>(new IntPtr(p + 0x050), ReversePrism.DataModels.SavedataDB.FromPointer); // 027003C779B0 0x50 UserSaveData                ( 0001866BF960 ModelClassType SavedataDB SavedataDB SavedataDB Pointer )

            return value;
        }
    }
}
