using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 <onGridUpdate>k__BackingField            Func`3<int, GameObject, IEnumerator> IL2CPP_TYPE_GENERICINST
    // 0B0 IsOnGridUpdateParallel                   ModelPrimitiveType bool bool bool Bool
    // 000 UpdateDifference                         int IL2CPP_TYPE_I4
    // 0B8 GridItem                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 BufferSize                               ModelPrimitiveType int int int Int32
    // 0C8 GridItemReference                        ModelPrimitiveType string string string String
    // 0D0 gridLines                                Dictionary`2<int, GridLine> IL2CPP_TYPE_GENERICINST
    // 0D8 DrawHeaderIndex                          ModelPrimitiveType int int int Int32
    // 0DC RowColumnSize                            ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    public partial class UIRepeatedGridLayout : DataModel
    {
        public bool                                     IsOnGridUpdateParallel                  { get; set; }
        public GameObject?                              GridItem                                { get; set; }
        public int                                      BufferSize                              { get; set; }
        public string                                   GridItemReference                       { get; set; }
        public int                                      DrawHeaderIndex                         { get; set; }
        public Vector2Int                               RowColumnSize                           { get; set; }

        public static UIRepeatedGridLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRepeatedGridLayout() { Pointer= p0 };

            value.IsOnGridUpdateParallel                    = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsOnGridUpdateParallel      ( ModelPrimitiveType bool bool bool Bool )
            value.GridItem                                  = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 GridItem                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 BufferSize                  ( ModelPrimitiveType int int int Int32 )
            value.GridItemReference                         = GetString(new IntPtr(p + 0x0C8)); // 0xC8 GridItemReference           ( ModelPrimitiveType string string string String )
            value.DrawHeaderIndex                           = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 DrawHeaderIndex             ( ModelPrimitiveType int int int Int32 )
            value.RowColumnSize                             = (Vector2Int)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC RowColumnSize               ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )

            return value;
        }
    }
}
