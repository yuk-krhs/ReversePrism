using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Version                                0001865F3400 ModelPrimitiveType int int int Int32
    // 020 Cells                                    000185CC05F8 ModelClassListType Cell[] Cell[] List<Cell> Pointer
    // 028 CellCounts                               000185CC06A8 ModelEnumListType CellCounts[] CellCounts[] List<CellCounts> Pointer
    // 030 TotalCellCounts                          0001865B9590 ModelEnumType CellCounts CellCounts CellCounts Int32
    // 040 MaxCellPosition                          0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 04C MinCellPosition                          0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 058 GlobalBounds                             0001865995F0 ModelEnumType Bounds Bounds Bounds Int32
    // 070 Bands                                    000186521E50 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 074 ChunkSizeInBricks                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 078 M_AssetFullPath                          000186671910 ModelPrimitiveType string string string String
    // 080 CellSizeInBricks                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 084 SimplificationLevels                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 088 MinDistanceBetweenProbes                 000186665900 ModelPrimitiveType float float float Single
    public partial class ProbeVolumeAsset : DataModel
    {
        public int                                      M_Version                               { get; set; }
        public List<Cell>?                              Cells                                   { get; set; }
        public List<CellCounts>?                        CellCounts                              { get; set; }
        public CellCounts                               TotalCellCounts                         { get; set; }
        public Vector3Int                               MaxCellPosition                         { get; set; }
        public Vector3Int                               MinCellPosition                         { get; set; }
        public Bounds                                   GlobalBounds                            { get; set; }
        public ProbeVolumeSHBands                       Bands                                   { get; set; }
        public int                                      ChunkSizeInBricks                       { get; set; }
        public string                                   M_AssetFullPath                         { get; set; }
        public int                                      CellSizeInBricks                        { get; set; }
        public int                                      SimplificationLevels                    { get; set; }
        public float                                    MinDistanceBetweenProbes                { get; set; }

        public static ProbeVolumeAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumeAsset() { Pointer= p0 };

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x018)); // 02466925A4F8 0x18 M_Version                   ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Cells                                     = GetObjectList<Cell>(new IntPtr(p + 0x020), ReversePrism.DataModels.Cell.FromPointer); // 02466925A518 0x20 Cells                       ( 000185CC05F8 ModelClassListType Cell[] Cell[] List<Cell> Pointer )
            value.CellCounts                                = GetEnumList<CellCounts>(new IntPtr(p + 0x028)); // 02466925A538 0x28 CellCounts                  ( 000185CC06A8 ModelEnumListType CellCounts[] CellCounts[] List<CellCounts> Pointer )
            value.TotalCellCounts                           = (CellCounts)GetInt32(new IntPtr(p + 0x030)); // 02466925A558 0x30 TotalCellCounts             ( 0001865B9590 ModelEnumType CellCounts CellCounts CellCounts Int32 )
            value.MaxCellPosition                           = (Vector3Int)GetInt32(new IntPtr(p + 0x040)); // 02466925A578 0x40 MaxCellPosition             ( 0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MinCellPosition                           = (Vector3Int)GetInt32(new IntPtr(p + 0x04C)); // 02466925A598 0x4C MinCellPosition             ( 0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.GlobalBounds                              = (Bounds)GetInt32(new IntPtr(p + 0x058)); // 02466925A5B8 0x58 GlobalBounds                ( 0001865995F0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.Bands                                     = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x070)); // 02466925A5D8 0x70 Bands                       ( 000186521E50 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.ChunkSizeInBricks                         = GetInt32(new IntPtr(p + 0x074)); // 02466925A5F8 0x74 ChunkSizeInBricks           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AssetFullPath                           = GetString(new IntPtr(p + 0x078)); // 02466925A618 0x78 M_AssetFullPath             ( 000186671910 ModelPrimitiveType string string string String )
            value.CellSizeInBricks                          = GetInt32(new IntPtr(p + 0x080)); // 02466925A638 0x80 CellSizeInBricks            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SimplificationLevels                      = GetInt32(new IntPtr(p + 0x084)); // 02466925A658 0x84 SimplificationLevels        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MinDistanceBetweenProbes                  = GetSingle(new IntPtr(p + 0x088)); // 02466925A678 0x88 MinDistanceBetweenProbes    ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
