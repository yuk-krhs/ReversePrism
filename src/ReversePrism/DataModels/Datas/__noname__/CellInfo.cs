using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cell                                     0001865B5C00 ModelClassType Cell Cell Cell Pointer
    // 018 BlendingCell                             0001865B5860 ModelClassType BlendingCellInfo BlendingCellInfo BlendingCellInfo Pointer
    // 020 ChunkList                                000185D28AB8 ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer
    // 028 FlatIdxInCellIndices                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C Loaded                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 UpdateInfo                               00018670A380 ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32
    // 060 IndexUpdated                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 064 TempUpdateInfo                           00018670A380 ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32
    // 094 SourceAssetInstanceID                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 StreamingScore                           000186666050 ModelPrimitiveType float float float Single
    // 09C ReferenceCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A0 DebugProbes                              0001865B6870 ModelClassType CellInstancedDebugProbes CellInstancedDebugProbes CellInstancedDebugProbes Pointer
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

            value.Cell                                      = GetObject<Cell>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cell.FromPointer); // 024669235680 0x10 Cell                        ( 0001865B5C00 ModelClassType Cell Cell Cell Pointer )
            value.BlendingCell                              = GetObject<BlendingCellInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.BlendingCellInfo.FromPointer); // 0246692356A0 0x18 BlendingCell                ( 0001865B5860 ModelClassType BlendingCellInfo BlendingCellInfo BlendingCellInfo Pointer )
            value.ChunkList                                 = GetEnumList<BrickChunkAlloc>(new IntPtr(p + 0x020)); // 0246692356C0 0x20 ChunkList                   ( 000185D28AB8 ModelEnumListType List`1<BrickChunkAlloc> List`1<BrickChunkAlloc> List<BrickChunkAlloc> Pointer )
            value.FlatIdxInCellIndices                      = GetInt32(new IntPtr(p + 0x028)); // 0246692356E0 0x28 FlatIdxInCellIndices        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Loaded                                    = GetBool(new IntPtr(p + 0x02C)); // 024669235700 0x2C Loaded                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UpdateInfo                                = (CellIndexUpdateInfo)GetInt32(new IntPtr(p + 0x030)); // 024669235720 0x30 UpdateInfo                  ( 00018670A380 ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32 )
            value.IndexUpdated                              = GetBool(new IntPtr(p + 0x060)); // 024669235740 0x60 IndexUpdated                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.TempUpdateInfo                            = (CellIndexUpdateInfo)GetInt32(new IntPtr(p + 0x064)); // 024669235760 0x64 TempUpdateInfo              ( 00018670A380 ModelEnumType CellIndexUpdateInfo CellIndexUpdateInfo CellIndexUpdateInfo Int32 )
            value.SourceAssetInstanceID                     = GetInt32(new IntPtr(p + 0x094)); // 024669235780 0x94 SourceAssetInstanceID       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StreamingScore                            = GetSingle(new IntPtr(p + 0x098)); // 0246692357A0 0x98 StreamingScore              ( 000186666050 ModelPrimitiveType float float float Single )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x09C)); // 0246692357C0 0x9C ReferenceCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DebugProbes                               = GetObject<CellInstancedDebugProbes>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CellInstancedDebugProbes.FromPointer); // 0246692357E0 0xA0 DebugProbes                 ( 0001865B6870 ModelClassType CellInstancedDebugProbes CellInstancedDebugProbes CellInstancedDebugProbes Pointer )

            return value;
        }
    }
}
