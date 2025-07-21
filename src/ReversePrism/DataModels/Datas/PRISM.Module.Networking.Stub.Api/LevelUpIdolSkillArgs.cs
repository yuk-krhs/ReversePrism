using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LevelUpIdolSkillArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 IdolSkillLevelFieldNumber                int IL2CPP_TYPE_I4
    // 01C IdolSkillLevel                           ModelPrimitiveType int int int Int32
    public partial class LevelUpIdolSkillArgs : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      IdolSkillLevel                          { get; set; }

        public static LevelUpIdolSkillArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LevelUpIdolSkillArgs() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillLevel                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C IdolSkillLevel              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
