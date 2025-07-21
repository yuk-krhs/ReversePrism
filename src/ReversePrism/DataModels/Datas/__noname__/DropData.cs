using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExpandedIdsBeforeDrag                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 DraggedIds                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 LastItemId                               ModelPrimitiveType int int int Int32
    // 024 ExpandItemBeginTimerMs                   ModelPrimitiveType float float float Single
    // 028 ExpandItemBeginPosition                  ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class DropData : DataModel
    {
        public List<int>?                               ExpandedIdsBeforeDrag                   { get; set; }
        public List<int>?                               DraggedIds                              { get; set; }
        public int                                      LastItemId                              { get; set; }
        public float                                    ExpandItemBeginTimerMs                  { get; set; }
        public Vector2                                  ExpandItemBeginPosition                 { get; set; }

        public static DropData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropData() { Pointer= p0 };

            value.ExpandedIdsBeforeDrag                     = GetInt32List(new IntPtr(p + 0x010)); // 0x10 ExpandedIdsBeforeDrag       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.DraggedIds                                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 DraggedIds                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastItemId                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 LastItemId                  ( ModelPrimitiveType int int int Int32 )
            value.ExpandItemBeginTimerMs                    = GetSingle(new IntPtr(p + 0x024)); // 0x24 ExpandItemBeginTimerMs      ( ModelPrimitiveType float float float Single )
            value.ExpandItemBeginPosition                   = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 ExpandItemBeginPosition     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
