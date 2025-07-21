using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NextEntryOffset                          ModelPrimitiveType uint uint uint UInt32
    // 014 FileIndex                                ModelPrimitiveType uint uint uint UInt32
    // 018 CreationTime                             ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 020 LastAccessTime                           ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 028 LastWriteTime                            ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 030 ChangeTime                               ModelEnumType LongFileTime LongFileTime LongFileTime Int32
    // 038 EndOfFile                                ModelPrimitiveType long long long Int64
    // 040 AllocationSize                           ModelPrimitiveType long long long Int64
    // 048 FileAttributes                           ModelEnumType FileAttributes FileAttributes FileAttributes Int32
    // 04C FileNameLength                           ModelPrimitiveType uint uint uint UInt32
    // 050 EaSize                                   ModelPrimitiveType uint uint uint UInt32
    // 054 _fileName                                char IL2CPP_TYPE_CHAR
    public partial class FILE_FULL_DIR_INFORMATION : DataModel
    {
        public uint                                     NextEntryOffset                         { get; set; }
        public uint                                     FileIndex                               { get; set; }
        public LongFileTime                             CreationTime                            { get; set; }
        public LongFileTime                             LastAccessTime                          { get; set; }
        public LongFileTime                             LastWriteTime                           { get; set; }
        public LongFileTime                             ChangeTime                              { get; set; }
        public long                                     EndOfFile                               { get; set; }
        public long                                     AllocationSize                          { get; set; }
        public FileAttributes                           FileAttributes                          { get; set; }
        public uint                                     FileNameLength                          { get; set; }
        public uint                                     EaSize                                  { get; set; }

        public static FILE_FULL_DIR_INFORMATION? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FILE_FULL_DIR_INFORMATION() { Pointer= p0 };

            value.NextEntryOffset                           = GetUInt32(new IntPtr(p + 0x010)); // 0x10 NextEntryOffset             ( ModelPrimitiveType uint uint uint UInt32 )
            value.FileIndex                                 = GetUInt32(new IntPtr(p + 0x014)); // 0x14 FileIndex                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.CreationTime                              = (LongFileTime)GetInt32(new IntPtr(p + 0x018)); // 0x18 CreationTime                ( ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.LastAccessTime                            = (LongFileTime)GetInt32(new IntPtr(p + 0x020)); // 0x20 LastAccessTime              ( ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.LastWriteTime                             = (LongFileTime)GetInt32(new IntPtr(p + 0x028)); // 0x28 LastWriteTime               ( ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.ChangeTime                                = (LongFileTime)GetInt32(new IntPtr(p + 0x030)); // 0x30 ChangeTime                  ( ModelEnumType LongFileTime LongFileTime LongFileTime Int32 )
            value.EndOfFile                                 = GetInt64(new IntPtr(p + 0x038)); // 0x38 EndOfFile                   ( ModelPrimitiveType long long long Int64 )
            value.AllocationSize                            = GetInt64(new IntPtr(p + 0x040)); // 0x40 AllocationSize              ( ModelPrimitiveType long long long Int64 )
            value.FileAttributes                            = (FileAttributes)GetInt32(new IntPtr(p + 0x048)); // 0x48 FileAttributes              ( ModelEnumType FileAttributes FileAttributes FileAttributes Int32 )
            value.FileNameLength                            = GetUInt32(new IntPtr(p + 0x04C)); // 0x4C FileNameLength              ( ModelPrimitiveType uint uint uint UInt32 )
            value.EaSize                                    = GetUInt32(new IntPtr(p + 0x050)); // 0x50 EaSize                      ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
