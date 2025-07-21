using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WillAcquireRP                            ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 SkillId                                  ModelPrimitiveType int int int Int32
    // 01C IconId                                   ModelPrimitiveType int int int Int32
    // 020 AwakeningLv                              ModelPrimitiveType int int int Int32
    // 024 IsAcquired                               ModelPrimitiveType bool bool bool Bool
    // 028 <Acquired>k__BackingField                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class AwakeningIdolSKillViewModel : DataModel
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
            var value   = new AwakeningIdolSKillViewModel() { Pointer= p0 };

            value.WillAcquireRP                             = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 WillAcquireRP               ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 SkillId                     ( ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C IconId                      ( ModelPrimitiveType int int int Int32 )
            value.AwakeningLv                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 AwakeningLv                 ( ModelPrimitiveType int int int Int32 )
            value.IsAcquired                                = GetBool(new IntPtr(p + 0x024)); // 0x24 IsAcquired                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
