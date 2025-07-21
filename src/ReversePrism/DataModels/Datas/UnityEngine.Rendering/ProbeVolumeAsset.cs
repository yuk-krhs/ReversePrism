using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Version                                ModelPrimitiveType int int int Int32
    // 020 Cells                                    ModelClassListType Cell[] Cell[] List<Cell> Pointer
    // 028 CellCounts                               ModelEnumListType CellCounts[] CellCounts[] List<CellCounts> Pointer
    // 030 TotalCellCounts                          ModelEnumType CellCounts CellCounts CellCounts Int32
    // 040 MaxCellPosition                          ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 04C MinCellPosition                          ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 058 GlobalBounds                             ModelEnumType Bounds Bounds Bounds Int32
    // 070 Bands                                    ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 074 ChunkSizeInBricks                        ModelPrimitiveType int int int Int32
    // 078 M_AssetFullPath                          ModelPrimitiveType string string string String
    // 080 CellSizeInBricks                         ModelPrimitiveType int int int Int32
    // 084 SimplificationLevels                     ModelPrimitiveType int int int Int32
    // 088 MinDistanceBetweenProbes                 ModelPrimitiveType float float float Single
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

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Version                   ( ModelPrimitiveType int int int Int32 )
            value.Cells                                     = GetObjectList<Cell>(new IntPtr(p + 0x020), ReversePrism.DataModels.Cell.FromPointer); // 0x20 Cells                       ( ModelClassListType Cell[] Cell[] List<Cell> Pointer )
            value.CellCounts                                = GetEnumList<CellCounts>(new IntPtr(p + 0x028)); // 0x28 CellCounts                  ( ModelEnumListType CellCounts[] CellCounts[] List<CellCounts> Pointer )
            value.TotalCellCounts                           = (CellCounts)GetInt32(new IntPtr(p + 0x030)); // 0x30 TotalCellCounts             ( ModelEnumType CellCounts CellCounts CellCounts Int32 )
            value.MaxCellPosition                           = (Vector3Int)GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxCellPosition             ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MinCellPosition                           = (Vector3Int)GetInt32(new IntPtr(p + 0x04C)); // 0x4C MinCellPosition             ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.GlobalBounds                              = (Bounds)GetInt32(new IntPtr(p + 0x058)); // 0x58 GlobalBounds                ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.Bands                                     = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x070)); // 0x70 Bands                       ( ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.ChunkSizeInBricks                         = GetInt32(new IntPtr(p + 0x074)); // 0x74 ChunkSizeInBricks           ( ModelPrimitiveType int int int Int32 )
            value.M_AssetFullPath                           = GetString(new IntPtr(p + 0x078)); // 0x78 M_AssetFullPath             ( ModelPrimitiveType string string string String )
            value.CellSizeInBricks                          = GetInt32(new IntPtr(p + 0x080)); // 0x80 CellSizeInBricks            ( ModelPrimitiveType int int int Int32 )
            value.SimplificationLevels                      = GetInt32(new IntPtr(p + 0x084)); // 0x84 SimplificationLevels        ( ModelPrimitiveType int int int Int32 )
            value.MinDistanceBetweenProbes                  = GetSingle(new IntPtr(p + 0x088)); // 0x88 MinDistanceBetweenProbes    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
