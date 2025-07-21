using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Result                                   ModelEnumType ResultCode ResultCode ResultCode Int32
    // 018 TrianglePairArray                        ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 020 RestAngleOrVolumeArray                   ModelPrimitiveListType float[] float[] List<float> Pointer
    // 028 SignOrVolumeArray                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 WriteBufferCount                         ModelPrimitiveType int int int Int32
    // 038 WriteDataArray                           ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 WriteIndexArray                          ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class ConstraintData : DataModel
    {
        public ResultCode                               Result                                  { get; set; }
        public List<ulong>?                             TrianglePairArray                       { get; set; }
        public List<float>?                             RestAngleOrVolumeArray                  { get; set; }
        public List<sbyte>?                             SignOrVolumeArray                       { get; set; }
        public int                                      WriteBufferCount                        { get; set; }
        public List<uint>?                              WriteDataArray                          { get; set; }
        public List<uint>?                              WriteIndexArray                         { get; set; }

        public static ConstraintData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstraintData() { Pointer= p0 };

            value.Result                                    = (ResultCode)GetInt32(new IntPtr(p + 0x010)); // 0x10 Result                      ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.TrianglePairArray                         = GetUInt64List(new IntPtr(p + 0x018)); // 0x18 TrianglePairArray           ( ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.RestAngleOrVolumeArray                    = GetSingleList(new IntPtr(p + 0x020)); // 0x20 RestAngleOrVolumeArray      ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.SignOrVolumeArray                         = GetSByteList(new IntPtr(p + 0x028)); // 0x28 SignOrVolumeArray           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.WriteBufferCount                          = GetInt32(new IntPtr(p + 0x030)); // 0x30 WriteBufferCount            ( ModelPrimitiveType int int int Int32 )
            value.WriteDataArray                            = GetUInt32List(new IntPtr(p + 0x038)); // 0x38 WriteDataArray              ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.WriteIndexArray                           = GetUInt32List(new IntPtr(p + 0x040)); // 0x40 WriteIndexArray             ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
