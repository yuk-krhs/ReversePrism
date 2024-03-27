using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectIdolSkillArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolSkillIdFieldNumber                int IL2CPP_TYPE_I4
    // 01C MstIdolSkillId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SelectIdolSkillArgs
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstIdolSkillId                          { get; set; }

        public static SelectIdolSkillArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectIdolSkillArgs();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D25FFB68 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x01C)); // 0270D25FFBA8 0x1C MstIdolSkillId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
