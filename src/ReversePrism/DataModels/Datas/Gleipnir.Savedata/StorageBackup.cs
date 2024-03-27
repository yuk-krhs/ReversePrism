using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceProvider                           0001866580B0 ModelClassType IStorageLocationProvider IStorageLocationProvider IStorageLocationProvider Pointer
    // 018 BackupProvider                           0001866580B0 ModelClassType IStorageLocationProvider IStorageLocationProvider IStorageLocationProvider Pointer
    public partial class StorageBackup
    {
        public IStorageLocationProvider?                SourceProvider                          { get; set; }
        public IStorageLocationProvider?                BackupProvider                          { get; set; }

        public static StorageBackup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorageBackup();

            value.SourceProvider                            = GetObject<IStorageLocationProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStorageLocationProvider.FromPointer); // 027003D033D8 0x10 SourceProvider              ( 0001866580B0 ModelClassType IStorageLocationProvider IStorageLocationProvider IStorageLocationProvider Pointer )
            value.BackupProvider                            = GetObject<IStorageLocationProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStorageLocationProvider.FromPointer); // 027003D033F8 0x18 BackupProvider              ( 0001866580B0 ModelClassType IStorageLocationProvider IStorageLocationProvider IStorageLocationProvider Pointer )

            return value;
        }
    }
}
