using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cell                                     ModelClassType Cell Cell Cell Pointer
    // 018 BlendingCell                             ModelClassType BlendingCellInfo BlendingCellInfo BlendingCellInfo Pointer
    // 020 ChunkList                                ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer
    // 028 FlatIdxInCellIndices                     ModelPrimitiveType int int int Int32
    // 02C Loaded                                   ModelPrimitiveType bool bool bool Bool
    // 030 UpdateInfo                               ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32
    // 060 IndexUpdated                             ModelPrimitiveType bool bool bool Bool
    // 064 TempUpdateInfo                           ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32
    // 094 SourceAssetInstanceID                    ModelPrimitiveType int int int Int32
    // 098 StreamingScore                           ModelPrimitiveType float float float Single
    // 09C ReferenceCount                           ModelPrimitiveType int int int Int32
    // 0A0 DebugProbes                              ModelClassType CellInstancedDebugProbes CellInstancedDebugProbes CellInstancedDebugProbes Pointer
    public partial class CellInfo : DataModel
    {
        public Cell?                                    Cell                                    { get; set; }
        public BlendingCellInfo?                        BlendingCell                            { get; set; }
        public List<BrickChunkAlloc>?                   ChunkList                               { get; set; }
        public int                                      FlatIdxInCellIndices                    { get; set; }
        public bool                                     Loaded                                  { get; set; }
        public CellIndexUpdateInfo                      UpdateInfo                              { get; set; }
        public bool                                     IndexUpdated                            { get; set; }
        public CellIndexUpdateInfo                      TempUpdateInfo                          { get; set; }
        public int                                      SourceAssetInstanceID                   { get; set; }
        public float                                    StreamingScore                          { get; set; }
        public int                                      ReferenceCount                          { get; set; }
        public CellInstancedDebugProbes?                DebugProbes                             { get; set; }

        public static CellInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CellInfo() { Pointer= p0 };

            value.Cell                                      = GetObject<Cell>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cell.FromPointer); // 0x10 Cell                        ( ModelClassType Cell Cell Cell Pointer )
            value.BlendingCell                              = GetObject<BlendingCellInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.BlendingCellInfo.FromPointer); // 0x18 BlendingCell                ( ModelClassType BlendingCellInfo BlendingCellInfo BlendingCellInfo Pointer )
            value.ChunkList                                 = GetEnumList<BrickChunkAlloc>(new IntPtr(p + 0x020)); // 0x20 ChunkList                   ( ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer )
            value.FlatIdxInCellIndices                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 FlatIdxInCellIndices        ( ModelPrimitiveType int int int Int32 )
            value.Loaded                                    = GetBool(new IntPtr(p + 0x02C)); // 0x2C Loaded                      ( ModelPrimitiveType bool bool bool Bool )
            value.UpdateInfo                                = (CellIndexUpdateInfo)GetInt32(new IntPtr(p + 0x030)); // 0x30 UpdateInfo                  ( ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32 )
            value.IndexUpdated                              = GetBool(new IntPtr(p + 0x060)); // 0x60 IndexUpdated                ( ModelPrimitiveType bool bool bool Bool )
            value.TempUpdateInfo                            = (CellIndexUpdateInfo)GetInt32(new IntPtr(p + 0x064)); // 0x64 TempUpdateInfo              ( ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32 )
            value.SourceAssetInstanceID                     = GetInt32(new IntPtr(p + 0x094)); // 0x94 SourceAssetInstanceID       ( ModelPrimitiveType int int int Int32 )
            value.StreamingScore                            = GetSingle(new IntPtr(p + 0x098)); // 0x98 StreamingScore              ( ModelPrimitiveType float float float Single )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x09C)); // 0x9C ReferenceCount              ( ModelPrimitiveType int int int Int32 )
            value.DebugProbes                               = GetObject<CellInstancedDebugProbes>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CellInstancedDebugProbes.FromPointer); // 0xA0 DebugProbes                 ( ModelClassType CellInstancedDebugProbes CellInstancedDebugProbes CellInstancedDebugProbes Pointer )

            return value;
        }
    }
}
