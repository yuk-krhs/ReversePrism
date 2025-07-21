using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_FileHeaderString                       string IL2CPP_TYPE_STRING
    // 000 k_CacheFileVersionOne                    int IL2CPP_TYPE_I4
    // 010 K_CacheFilePath                          ModelPrimitiveType string string string String
    // 018 K_SystemCalls                            ModelClassType IFileSystemCalls IFileSystemCalls IFileSystemCalls Pointer
    // 020 K_CacheFileMaximumSize                   ModelPrimitiveType long long long Int64
    public partial class DiskCache : DataModel
    {
        public string                                   K_CacheFilePath                         { get; set; }
        public IFileSystemCalls?                        K_SystemCalls                           { get; set; }
        public long                                     K_CacheFileMaximumSize                  { get; set; }

        public static DiskCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiskCache() { Pointer= p0 };

            value.K_CacheFilePath                           = GetString(new IntPtr(p + 0x010)); // 0x10 K_CacheFilePath             ( ModelPrimitiveType string string string String )
            value.K_SystemCalls                             = GetObject<IFileSystemCalls>(new IntPtr(p + 0x018), ReversePrism.DataModels.IFileSystemCalls.FromPointer); // 0x18 K_SystemCalls               ( ModelClassType IFileSystemCalls IFileSystemCalls IFileSystemCalls Pointer )
            value.K_CacheFileMaximumSize                    = GetInt64(new IntPtr(p + 0x020)); // 0x20 K_CacheFileMaximumSize      ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
