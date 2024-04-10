using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectionSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectionMstPotentialSkillIdFieldNumber  int IL2CPP_TYPE_I4
    // 018 SelectionMstPotentialSkillId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RemoveMstPotentialSkillIdFieldNumber     int IL2CPP_TYPE_I4
    // 01C RemoveMstPotentialSkillId                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SelectionSupportSkillStatus : DataModel
    {
        public int                                      SelectionMstPotentialSkillId            { get; set; }
        public int                                      RemoveMstPotentialSkillId               { get; set; }

        public static SelectionSupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectionSupportSkillStatus() { Pointer= p0 };

            value.SelectionMstPotentialSkillId              = GetInt32(new IntPtr(p + 0x018)); // 0246610B2250 0x18 SelectionMstPotentialSkillId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RemoveMstPotentialSkillId                 = GetInt32(new IntPtr(p + 0x01C)); // 0246610B2290 0x1C RemoveMstPotentialSkillId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
