using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 018 SelectedMstIdolSkillId                   ModelPrimitiveType int int int Int32
    // 020 IdolSkillList                            ModelClassListType IIdolSkillStatus[] IIdolSkillStatus[] List<IIdolSkillStatus> Pointer
    // 028 TargetMstIdolSkillId                     ModelPrimitiveType int int int Int32
    // 02C EvolutionLevel                           ModelPrimitiveType int int int Int32
    // 030 IsProduce                                ModelPrimitiveType bool bool bool Bool
    public partial class ProducePreparationIdolSkillSelectPopupViewModel : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      SelectedMstIdolSkillId                  { get; set; }
        public List<IIdolSkillStatus>?                  IdolSkillList                           { get; set; }
        public int                                      TargetMstIdolSkillId                    { get; set; }
        public int                                      EvolutionLevel                          { get; set; }
        public bool                                     IsProduce                               { get; set; }

        public static ProducePreparationIdolSkillSelectPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationIdolSkillSelectPopupViewModel() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 SelectedMstIdolSkillId      ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x20 IdolSkillList               ( ModelClassListType IIdolSkillStatus[] IIdolSkillStatus[] List<IIdolSkillStatus> Pointer )
            value.TargetMstIdolSkillId                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 TargetMstIdolSkillId        ( ModelPrimitiveType int int int Int32 )
            value.EvolutionLevel                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C EvolutionLevel              ( ModelPrimitiveType int int int Int32 )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 IsProduce                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
