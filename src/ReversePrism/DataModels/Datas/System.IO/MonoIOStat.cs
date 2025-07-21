using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FileAttributes                           ModelEnumType FileAttributes FileAttributes FileAttributes Int32
    // 018 Length                                   ModelPrimitiveType long long long Int64
    // 020 CreationTime                             ModelPrimitiveType long long long Int64
    // 028 LastAccessTime                           ModelPrimitiveType long long long Int64
    // 030 LastWriteTime                            ModelPrimitiveType long long long Int64
    public partial class MonoIOStat : DataModel
    {
        public FileAttributes                           FileAttributes                          { get; set; }
        public long                                     Length                                  { get; set; }
        public long                                     CreationTime                            { get; set; }
        public long                                     LastAccessTime                          { get; set; }
        public long                                     LastWriteTime                           { get; set; }

        public static MonoIOStat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoIOStat() { Pointer= p0 };

            value.FileAttributes                            = (FileAttributes)GetInt32(new IntPtr(p + 0x010)); // 0x10 FileAttributes              ( ModelEnumType FileAttributes FileAttributes FileAttributes Int32 )
            value.Length                                    = GetInt64(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelPrimitiveType long long long Int64 )
            value.CreationTime                              = GetInt64(new IntPtr(p + 0x020)); // 0x20 CreationTime                ( ModelPrimitiveType long long long Int64 )
            value.LastAccessTime                            = GetInt64(new IntPtr(p + 0x028)); // 0x28 LastAccessTime              ( ModelPrimitiveType long long long Int64 )
            value.LastWriteTime                             = GetInt64(new IntPtr(p + 0x030)); // 0x30 LastWriteTime               ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
