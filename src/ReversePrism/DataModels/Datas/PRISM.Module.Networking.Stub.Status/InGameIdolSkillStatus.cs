using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InGameIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolSkillIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstIdolSkillId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 01C MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InGameIdolSkillStatus : DataModel
    {
        public int                                      MstIdolSkillId                          { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }

        public static InGameIdolSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameIdolSkillStatus() { Pointer= p0 };

            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x018)); // 02466105B180 0x18 MstIdolSkillId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x01C)); // 02466105B1C0 0x1C MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
