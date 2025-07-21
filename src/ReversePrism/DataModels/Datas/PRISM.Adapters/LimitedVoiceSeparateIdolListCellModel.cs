using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsCenter                                 ModelPrimitiveType bool bool bool Bool
    // 011 IsOnStage                                ModelPrimitiveType bool bool bool Bool
    // 012 IsDuplicated                             ModelPrimitiveType bool bool bool Bool
    // 014 IconModel                                ModelEnumType CharacterIconDescriptor CharacterIconDescriptor CharacterIconDescriptor Int32
    public partial class LimitedVoiceSeparateIdolListCellModel : DataModel
    {
        public bool                                     IsCenter                                { get; set; }
        public bool                                     IsOnStage                               { get; set; }
        public bool                                     IsDuplicated                            { get; set; }
        public CharacterIconDescriptor                  IconModel                               { get; set; }

        public static LimitedVoiceSeparateIdolListCellModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedVoiceSeparateIdolListCellModel() { Pointer= p0 };

            value.IsCenter                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsCenter                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsOnStage                                 = GetBool(new IntPtr(p + 0x011)); // 0x11 IsOnStage                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsDuplicated                              = GetBool(new IntPtr(p + 0x012)); // 0x12 IsDuplicated                ( ModelPrimitiveType bool bool bool Bool )
            value.IconModel                                 = (CharacterIconDescriptor)GetInt32(new IntPtr(p + 0x014)); // 0x14 IconModel                   ( ModelEnumType CharacterIconDescriptor CharacterIconDescriptor CharacterIconDescriptor Int32 )

            return value;
        }
    }
}
