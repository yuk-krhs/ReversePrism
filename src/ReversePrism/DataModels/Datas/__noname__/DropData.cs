using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExpandedIdsBeforeDrag                    000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 DraggedIds                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 LastItemId                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 ExpandItemBeginTimerMs                   000186666050 ModelPrimitiveType float float float Single
    // 028 ExpandItemBeginPosition                  0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class DropData
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
            var value   = new DropData();

            value.ExpandedIdsBeforeDrag                     = GetInt32List(new IntPtr(p + 0x010)); // 027006757648 0x10 ExpandedIdsBeforeDrag       ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.DraggedIds                                = GetInt32List(new IntPtr(p + 0x018)); // 027006757668 0x18 DraggedIds                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastItemId                                = GetInt32(new IntPtr(p + 0x020)); // 027006757688 0x20 LastItemId                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ExpandItemBeginTimerMs                    = GetSingle(new IntPtr(p + 0x024)); // 0270067576A8 0x24 ExpandItemBeginTimerMs      ( 000186666050 ModelPrimitiveType float float float Single )
            value.ExpandItemBeginPosition                   = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0270067576C8 0x28 ExpandItemBeginPosition     ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
