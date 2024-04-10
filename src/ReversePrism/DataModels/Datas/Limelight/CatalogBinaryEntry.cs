using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Priority                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 ResourceType                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 NumDeps                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C NumContents                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 NumGroups                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Size                                     00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 <Label>k__BackingField                   ArraySegment`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 040 TypeIdx                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 GroupsChecksum                           000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 048 LabelCrc                                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 050 ContentAddressCrcs                       000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 DepCrcs                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 RecDepCrcs                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 NumRecDepCrcs                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 Checksum                                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 078 Seed                                     00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
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

            value.Priority                                  = GetInt32(new IntPtr(p + 0x010)); // 02466B55BB40 0x10 Priority                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x014)); // 02466B55BB60 0x14 ResourceType                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumDeps                                   = GetInt32(new IntPtr(p + 0x018)); // 02466B55BB80 0x18 NumDeps                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumContents                               = GetInt32(new IntPtr(p + 0x01C)); // 02466B55BBA0 0x1C NumContents                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumGroups                                 = GetInt32(new IntPtr(p + 0x020)); // 02466B55BBC0 0x20 NumGroups                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x028)); // 02466B55BBE0 0x28 Size                        ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.TypeIdx                                   = GetInt32(new IntPtr(p + 0x040)); // 02466B55BC20 0x40 TypeIdx                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GroupsChecksum                            = GetUInt32(new IntPtr(p + 0x044)); // 02466B55BC40 0x44 GroupsChecksum              ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.LabelCrc                                  = GetUInt64(new IntPtr(p + 0x048)); // 02466B55BC60 0x48 LabelCrc                    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ContentAddressCrcs                        = GetSByteList(new IntPtr(p + 0x050)); // 02466B55BC80 0x50 ContentAddressCrcs          ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DepCrcs                                   = GetSByteList(new IntPtr(p + 0x058)); // 02466B55BCA0 0x58 DepCrcs                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.RecDepCrcs                                = GetSByteList(new IntPtr(p + 0x060)); // 02466B55BCC0 0x60 RecDepCrcs                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.NumRecDepCrcs                             = GetInt32(new IntPtr(p + 0x068)); // 02466B55BCE0 0x68 NumRecDepCrcs               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x070)); // 02466B55BD00 0x70 Checksum                    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x078)); // 02466B55BD20 0x78 Seed                        ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
