using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Label                                    ModelPrimitiveType long long long Int64
    // 018 Deps                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 GroupChecksum                            ModelPrimitiveType uint uint uint UInt32
    // 024 FileStatus                               ModelPrimitiveType int int int Int32
    // 028 ResourceType                             ModelPrimitiveType int int int Int32
    // 030 Checksum                                 ModelPrimitiveType long long long Int64
    // 038 Seed                                     ModelPrimitiveType long long long Int64
    // 040 Size                                     ModelPrimitiveType long long long Int64
    // 048 Priority                                 ModelPrimitiveType int int int Int32
    public partial class AssetInfoRow : DataModel
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
            var value   = new AssetInfoRow() { Pointer= p0 };

            value.Label                                     = GetInt64(new IntPtr(p + 0x010)); // 0x10 Label                       ( ModelPrimitiveType long long long Int64 )
            value.Deps                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Deps                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GroupChecksum                             = GetUInt32(new IntPtr(p + 0x020)); // 0x20 GroupChecksum               ( ModelPrimitiveType uint uint uint UInt32 )
            value.FileStatus                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 FileStatus                  ( ModelPrimitiveType int int int Int32 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 ResourceType                ( ModelPrimitiveType int int int Int32 )
            value.Checksum                                  = GetInt64(new IntPtr(p + 0x030)); // 0x30 Checksum                    ( ModelPrimitiveType long long long Int64 )
            value.Seed                                      = GetInt64(new IntPtr(p + 0x038)); // 0x38 Seed                        ( ModelPrimitiveType long long long Int64 )
            value.Size                                      = GetInt64(new IntPtr(p + 0x040)); // 0x40 Size                        ( ModelPrimitiveType long long long Int64 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x048)); // 0x48 Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
