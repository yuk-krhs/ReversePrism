using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PendingMinCellPosition                   0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C PendingMaxCellPosition                   0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    public partial class InitInfo : DataModel
    {
        public Vector3Int                               PendingMinCellPosition                  { get; set; }
        public Vector3Int                               PendingMaxCellPosition                  { get; set; }

        public static InitInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitInfo() { Pointer= p0 };

            value.PendingMinCellPosition                    = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 02466920D638 0x10 PendingMinCellPosition      ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.PendingMaxCellPosition                    = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 02466920D658 0x1C PendingMaxCellPosition      ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )

            return value;
        }
    }
}
