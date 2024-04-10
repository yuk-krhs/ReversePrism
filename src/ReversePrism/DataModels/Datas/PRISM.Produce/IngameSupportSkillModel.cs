using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EffectValues                             000185D11F18 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 018 SkillID                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 01C SkillType                                000186613AF0 ModelEnumType SupportSkillType SupportSkillType SupportSkillType Int32
    // 020 SkillBufferDisplay                       000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 028 GrantSkillBufferDisplay                  000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
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

            value.EffectValues                              = GetInt32List(new IntPtr(p + 0x010)); // 024664C17900 0x10 EffectValues                ( 000185D11F18 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.SkillID                                   = GetInt32(new IntPtr(p + 0x018)); // 024664C17920 0x18 SkillID                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.SkillType                                 = (SupportSkillType)GetInt32(new IntPtr(p + 0x01C)); // 024664C17940 0x1C SkillType                   ( 000186613AF0 ModelEnumType SupportSkillType SupportSkillType SupportSkillType Int32 )
            value.SkillBufferDisplay                        = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 024664C17960 0x20 SkillBufferDisplay          ( 000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.GrantSkillBufferDisplay                   = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 024664C17980 0x28 GrantSkillBufferDisplay     ( 000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )

            return value;
        }
    }
}
