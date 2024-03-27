using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceIdol                              000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstIdolSkillIdFieldNumber                int IL2CPP_TYPE_I4
    // 020 MstIdolSkillId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceUnitIdolStatus
    {
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }
        public int                                      MstIdolSkillId                          { get; set; }

        public static ProduceUnitIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitIdolStatus();

            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D112F1E0 0x18 ProduceIdol                 ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x020)); // 0270D112F220 0x20 MstIdolSkillId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
