using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WillAcquireRP                            0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 SkillId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 01C IconId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 AwakeningLv                              0001865F4260 ModelPrimitiveType int int int Int32
    // 024 IsAcquired                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 <Acquired>k__BackingField                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class AwakeningIdolSKillViewModel
    {
        public BoolReactiveProperty?                    WillAcquireRP                           { get; set; }
        public int                                      SkillId                                 { get; set; }
        public int                                      IconId                                  { get; set; }
        public int                                      AwakeningLv                             { get; set; }
        public bool                                     IsAcquired                              { get; set; }

        public static AwakeningIdolSKillViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningIdolSKillViewModel();

            value.WillAcquireRP                             = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D607EA88 0x10 WillAcquireRP               ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D607EAA8 0x18 SkillId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270D607EAC8 0x1C IconId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AwakeningLv                               = GetInt32(new IntPtr(p + 0x020)); // 0270D607EAE8 0x20 AwakeningLv                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsAcquired                                = GetBool(new IntPtr(p + 0x024)); // 0270D607EB08 0x24 IsAcquired                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
