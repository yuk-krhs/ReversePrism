using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Technique                                ModelEnumType DecalTechniqueOption DecalTechniqueOption DecalTechniqueOption Int32
    // 014 MaxDrawDistance                          ModelPrimitiveType float float float Single
    // 018 DecalLayers                              ModelPrimitiveType bool bool bool Bool
    // 020 DBufferSettings                          ModelClassType DBufferSettings DBufferSettings DBufferSettings Pointer
    // 028 ScreenSpaceSettings                      ModelClassType DecalScreenSpaceSettings DecalScreenSpaceSettings DecalScreenSpaceSettings Pointer
    public partial class DecalSettings : DataModel
    {
        public DecalTechniqueOption                     Technique                               { get; set; }
        public float                                    MaxDrawDistance                         { get; set; }
        public bool                                     DecalLayers                             { get; set; }
        public DBufferSettings?                         DBufferSettings                         { get; set; }
        public DecalScreenSpaceSettings?                ScreenSpaceSettings                     { get; set; }

        public static DecalSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalSettings() { Pointer= p0 };

            value.Technique                                 = (DecalTechniqueOption)GetInt32(new IntPtr(p + 0x010)); // 0x10 Technique                   ( ModelEnumType DecalTechniqueOption DecalTechniqueOption DecalTechniqueOption Int32 )
            value.MaxDrawDistance                           = GetSingle(new IntPtr(p + 0x014)); // 0x14 MaxDrawDistance             ( ModelPrimitiveType float float float Single )
            value.DecalLayers                               = GetBool(new IntPtr(p + 0x018)); // 0x18 DecalLayers                 ( ModelPrimitiveType bool bool bool Bool )
            value.DBufferSettings                           = GetObject<DBufferSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.DBufferSettings.FromPointer); // 0x20 DBufferSettings             ( ModelClassType DBufferSettings DBufferSettings DBufferSettings Pointer )
            value.ScreenSpaceSettings                       = GetObject<DecalScreenSpaceSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.DecalScreenSpaceSettings.FromPointer); // 0x28 ScreenSpaceSettings         ( ModelClassType DecalScreenSpaceSettings DecalScreenSpaceSettings DecalScreenSpaceSettings Pointer )

            return value;
        }
    }
}
