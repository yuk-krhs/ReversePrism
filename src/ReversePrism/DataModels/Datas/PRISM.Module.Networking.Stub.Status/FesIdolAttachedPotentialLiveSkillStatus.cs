using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FesIdolAttachedPotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPotentialLiveSkillIdFieldNumber       int IL2CPP_TYPE_I4
    // 018 MstPotentialLiveSkillId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstPotentialLiveSkillLevelIdFieldNumber  int IL2CPP_TYPE_I4
    // 020 MstPotentialLiveSkillLevelId             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FesIdolAttachedPotentialLiveSkillStatus
    {
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      MstPotentialLiveSkillLevelId            { get; set; }

        public static FesIdolAttachedPotentialLiveSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolAttachedPotentialLiveSkillStatus();

            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x018)); // 0270D12ACE40 0x18 MstPotentialLiveSkillId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D12ACE80 0x1C Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillLevelId              = GetInt32(new IntPtr(p + 0x020)); // 0270D12ACEC0 0x20 MstPotentialLiveSkillLevelId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
