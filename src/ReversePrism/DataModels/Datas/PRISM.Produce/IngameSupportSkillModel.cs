using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EffectValues                             ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 018 SkillID                                  ModelPrimitiveType int int int Int32
    // 01C SkillType                                ModelEnumType SupportSkillType SupportSkillType SupportSkillType Int32
    // 020 SkillBufferDisplay                       ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 028 GrantSkillBufferDisplay                  ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    public partial class IngameSupportSkillModel : DataModel
    {
        public List<int>?                               EffectValues                            { get; set; }
        public int                                      SkillID                                 { get; set; }
        public SupportSkillType                         SkillType                               { get; set; }
        public ISkillBufferDisplayStatus?               SkillBufferDisplay                      { get; set; }
        public ISkillBufferDisplayStatus?               GrantSkillBufferDisplay                 { get; set; }

        public static IngameSupportSkillModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameSupportSkillModel() { Pointer= p0 };

            value.EffectValues                              = GetInt32List(new IntPtr(p + 0x010)); // 0x10 EffectValues                ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.SkillID                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 SkillID                     ( ModelPrimitiveType int int int Int32 )
            value.SkillType                                 = (SupportSkillType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C SkillType                   ( ModelEnumType SupportSkillType SupportSkillType SupportSkillType Int32 )
            value.SkillBufferDisplay                        = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 0x20 SkillBufferDisplay          ( ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.GrantSkillBufferDisplay                   = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 0x28 GrantSkillBufferDisplay     ( ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )

            return value;
        }
    }
}
