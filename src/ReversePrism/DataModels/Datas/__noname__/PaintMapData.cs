using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReadFlag_Fixed                           sbyte IL2CPP_TYPE_U1
    // 000 ReadFlag_Move                            sbyte IL2CPP_TYPE_U1
    // 000 ReadFlag_Limit                           sbyte IL2CPP_TYPE_U1
    // 010 PaintData                                ModelEnumListType Color32[] Color32[] List<Color32> Pointer
    // 018 PaintMapWidth                            ModelPrimitiveType int int int Int32
    // 01C PaintMapHeight                           ModelPrimitiveType int int int Int32
    // 020 PaintReadFlag                            ModelEnumType ExBitFlag8 ExBitFlag8 ExBitFlag8 Int32
    public partial class PaintMapData : DataModel
    {
        public List<Color32>?                           PaintData                               { get; set; }
        public int                                      PaintMapWidth                           { get; set; }
        public int                                      PaintMapHeight                          { get; set; }
        public ExBitFlag8                               PaintReadFlag                           { get; set; }

        public static PaintMapData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PaintMapData() { Pointer= p0 };

            value.PaintData                                 = GetEnumList<Color32>(new IntPtr(p + 0x010)); // 0x10 PaintData                   ( ModelEnumListType Color32[] Color32[] List<Color32> Pointer )
            value.PaintMapWidth                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 PaintMapWidth               ( ModelPrimitiveType int int int Int32 )
            value.PaintMapHeight                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C PaintMapHeight              ( ModelPrimitiveType int int int Int32 )
            value.PaintReadFlag                             = (ExBitFlag8)GetInt32(new IntPtr(p + 0x020)); // 0x20 PaintReadFlag               ( ModelEnumType ExBitFlag8 ExBitFlag8 ExBitFlag8 Int32 )

            return value;
        }
    }
}
