using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 SoftNormalGen IL2CPP_TYPE_CLASS
    // 010 Margin                                   0001866656B0 ModelPrimitiveType float float float Single
    // 014 MinJoin                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MaxJoin                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Tangents                                 000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    public partial class SoftNormalGen : DataModel
    {
        public float                                    Margin                                  { get; set; }
        public int                                      MinJoin                                 { get; set; }
        public int                                      MaxJoin                                 { get; set; }
        public List<Vector4>?                           Tangents                                { get; set; }

        public static SoftNormalGen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftNormalGen() { Pointer= p0 };

            value.Margin                                    = GetSingle(new IntPtr(p + 0x010)); // 024664B81C40 0x10 Margin                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinJoin                                   = GetInt32(new IntPtr(p + 0x014)); // 024664B81C60 0x14 MinJoin                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxJoin                                   = GetInt32(new IntPtr(p + 0x018)); // 024664B81C80 0x18 MaxJoin                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Tangents                                  = GetEnumList<Vector4>(new IntPtr(p + 0x020)); // 024664B81CA0 0x20 Tangents                    ( 000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )

            return value;
        }
    }
}
