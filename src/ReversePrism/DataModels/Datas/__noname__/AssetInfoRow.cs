using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Label                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Deps                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 GroupChecksum                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 024 FileStatus                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ResourceType                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Checksum                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 038 Seed                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 040 Size                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 048 Priority                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AssetInfoRow
    {
        public long                                     Label                                   { get; set; }
        public List<sbyte>?                             Deps                                    { get; set; }
        public uint                                     GroupChecksum                           { get; set; }
        public int                                      FileStatus                              { get; set; }
        public int                                      ResourceType                            { get; set; }
        public long                                     Checksum                                { get; set; }
        public long                                     Seed                                    { get; set; }
        public long                                     Size                                    { get; set; }
        public int                                      Priority                                { get; set; }

        public static AssetInfoRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetInfoRow();

            value.Label                                     = GetInt64(new IntPtr(p + 0x010)); // 027003E02758 0x10 Label                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Deps                                      = GetSByteList(new IntPtr(p + 0x018)); // 027003E02778 0x18 Deps                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GroupChecksum                             = GetUInt32(new IntPtr(p + 0x020)); // 027003E02798 0x20 GroupChecksum               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.FileStatus                                = GetInt32(new IntPtr(p + 0x024)); // 027003E027B8 0x24 FileStatus                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x028)); // 027003E027D8 0x28 ResourceType                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Checksum                                  = GetInt64(new IntPtr(p + 0x030)); // 027003E027F8 0x30 Checksum                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Seed                                      = GetInt64(new IntPtr(p + 0x038)); // 027003E02818 0x38 Seed                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Size                                      = GetInt64(new IntPtr(p + 0x040)); // 027003E02838 0x40 Size                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x048)); // 027003E02858 0x48 Priority                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
