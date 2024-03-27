using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AttachingPotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstPotentialLiveSkillIdFieldNumber       int IL2CPP_TYPE_I4
    // 01C MstPotentialLiveSkillId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AttachingPotentialLiveSkillStatus
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public int                                      Level                                   { get; set; }

        public static AttachingPotentialLiveSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachingPotentialLiveSkillStatus();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D10AF960 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x01C)); // 0270D10AF9A0 0x1C MstPotentialLiveSkillId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D10AF9E0 0x20 Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
