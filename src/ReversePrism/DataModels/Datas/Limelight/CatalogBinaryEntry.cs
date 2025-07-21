using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Priority                                 ModelPrimitiveType int int int Int32
    // 014 ResourceType                             ModelPrimitiveType int int int Int32
    // 018 NumDeps                                  ModelPrimitiveType int int int Int32
    // 01C NumContents                              ModelPrimitiveType int int int Int32
    // 020 NumGroups                                ModelPrimitiveType int int int Int32
    // 028 Size                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 030 <Label>k__BackingField                   ArraySegment`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 040 TypeIdx                                  ModelPrimitiveType int int int Int32
    // 044 GroupsChecksum                           ModelPrimitiveType uint uint uint UInt32
    // 048 LabelCrc                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 050 ContentAddressCrcs                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 DepCrcs                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 RecDepCrcs                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 NumRecDepCrcs                            ModelPrimitiveType int int int Int32
    // 070 Checksum                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 078 Seed                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 080 <ContentTypes>k__BackingField            ArraySegment`1<sbyte>[] IL2CPP_TYPE_SZARRAY
    public partial class CatalogBinaryEntry : DataModel
    {
        public int                                      Priority                                { get; set; }
        public int                                      ResourceType                            { get; set; }
        public int                                      NumDeps                                 { get; set; }
        public int                                      NumContents                             { get; set; }
        public int                                      NumGroups                               { get; set; }
        public ulong                                    Size                                    { get; set; }
        public int                                      TypeIdx                                 { get; set; }
        public uint                                     GroupsChecksum                          { get; set; }
        public ulong                                    LabelCrc                                { get; set; }
        public List<sbyte>?                             ContentAddressCrcs                      { get; set; }
        public List<sbyte>?                             DepCrcs                                 { get; set; }
        public List<sbyte>?                             RecDepCrcs                              { get; set; }
        public int                                      NumRecDepCrcs                           { get; set; }
        public ulong                                    Checksum                                { get; set; }
        public ulong                                    Seed                                    { get; set; }

        public static CatalogBinaryEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogBinaryEntry() { Pointer= p0 };

            value.Priority                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Priority                    ( ModelPrimitiveType int int int Int32 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 ResourceType                ( ModelPrimitiveType int int int Int32 )
            value.NumDeps                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 NumDeps                     ( ModelPrimitiveType int int int Int32 )
            value.NumContents                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NumContents                 ( ModelPrimitiveType int int int Int32 )
            value.NumGroups                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 NumGroups                   ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x028)); // 0x28 Size                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.TypeIdx                                   = GetInt32(new IntPtr(p + 0x040)); // 0x40 TypeIdx                     ( ModelPrimitiveType int int int Int32 )
            value.GroupsChecksum                            = GetUInt32(new IntPtr(p + 0x044)); // 0x44 GroupsChecksum              ( ModelPrimitiveType uint uint uint UInt32 )
            value.LabelCrc                                  = GetUInt64(new IntPtr(p + 0x048)); // 0x48 LabelCrc                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ContentAddressCrcs                        = GetSByteList(new IntPtr(p + 0x050)); // 0x50 ContentAddressCrcs          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DepCrcs                                   = GetSByteList(new IntPtr(p + 0x058)); // 0x58 DepCrcs                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.RecDepCrcs                                = GetSByteList(new IntPtr(p + 0x060)); // 0x60 RecDepCrcs                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.NumRecDepCrcs                             = GetInt32(new IntPtr(p + 0x068)); // 0x68 NumRecDepCrcs               ( ModelPrimitiveType int int int Int32 )
            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x070)); // 0x70 Checksum                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x078)); // 0x78 Seed                        ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
