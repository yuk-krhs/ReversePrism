using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstProduceIdolId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 SelectedMstIdolSkillId                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 IdolSkillList                            000185B873D0 ModelClassListType IIdolSkillStatus[] IIdolSkillStatus[] List<IIdolSkillStatus> Pointer
    // 028 EvolutionLevel                           0001865F4260 ModelPrimitiveType int int int Int32
    // 02C IsProduce                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ProducePreparationIdolSkillSelectPopupViewModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      SelectedMstIdolSkillId                  { get; set; }
        public List<IIdolSkillStatus>?                  IdolSkillList                           { get; set; }
        public int                                      EvolutionLevel                          { get; set; }
        public bool                                     IsProduce                               { get; set; }

        public static ProducePreparationIdolSkillSelectPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationIdolSkillSelectPopupViewModel();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x010)); // 0270D6018338 0x10 MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0270D6018358 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x018)); // 0270D6018378 0x18 SelectedMstIdolSkillId      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0270D6018398 0x20 IdolSkillList               ( 000185B873D0 ModelClassListType IIdolSkillStatus[] IIdolSkillStatus[] List<IIdolSkillStatus> Pointer )
            value.EvolutionLevel                            = GetInt32(new IntPtr(p + 0x028)); // 0270D60183B8 0x28 EvolutionLevel              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x02C)); // 0270D60183D8 0x2C IsProduce                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
