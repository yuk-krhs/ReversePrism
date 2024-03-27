using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 src                                      <int> IL2CPP_TYPE_I
    // 018 dst                                      <int> IL2CPP_TYPE_I
    // 020 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 closingSrc                               <int> IL2CPP_TYPE_I
    // 030 closingDst                               <int> IL2CPP_TYPE_I
    // 038 ClosingCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C Transform                                00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 07C VertsBeforeUVDisplacement                0001865F36C0 ModelPrimitiveType int int int Int32
    // 080 VertsAfterUVDisplacement                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class NudgeJobData
    {
        public int                                      Count                                   { get; set; }
        public int                                      ClosingCount                            { get; set; }
        public Matrix4x4                                Transform                               { get; set; }
        public int                                      VertsBeforeUVDisplacement               { get; set; }
        public int                                      VertsAfterUVDisplacement                { get; set; }

        public static NudgeJobData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NudgeJobData();

            value.Count                                     = GetInt32(new IntPtr(p + 0x020)); // 027006864310 0x20 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ClosingCount                              = GetInt32(new IntPtr(p + 0x038)); // 027006864370 0x38 ClosingCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Transform                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x03C)); // 027006864390 0x3C Transform                   ( 00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.VertsBeforeUVDisplacement                 = GetInt32(new IntPtr(p + 0x07C)); // 0270068643B0 0x7C VertsBeforeUVDisplacement   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertsAfterUVDisplacement                  = GetInt32(new IntPtr(p + 0x080)); // 0270068643D0 0x80 VertsAfterUVDisplacement    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
