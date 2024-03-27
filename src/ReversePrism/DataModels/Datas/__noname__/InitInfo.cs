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
    public partial class InitInfo
    {
        public Vector3Int                               PendingMinCellPosition                  { get; set; }
        public Vector3Int                               PendingMaxCellPosition                  { get; set; }

        public static InitInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitInfo();

            value.PendingMinCellPosition                    = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0270D91BAEE0 0x10 PendingMinCellPosition      ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.PendingMaxCellPosition                    = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 0270D91BAF00 0x1C PendingMaxCellPosition      ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )

            return value;
        }
    }
}
