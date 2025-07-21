using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 effects                                  ListWithKey`2<ProduceInGameEffectType, ProduceInGameEffect> IL2CPP_TYPE_GENERICINST
    // 018 DisplayEffect                            ModelClassType ProduceInGameEffect ProduceInGameEffect ProduceInGameEffect Pointer
    // 020 GroupID                                  ModelPrimitiveType int int int Int32
    public partial class ProduceInGameEffectGroup : DataModel
    {
        public ProduceInGameEffect?                     DisplayEffect                           { get; set; }
        public int                                      GroupID                                 { get; set; }

        public static ProduceInGameEffectGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGameEffectGroup() { Pointer= p0 };

            value.DisplayEffect                             = GetObject<ProduceInGameEffect>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceInGameEffect.FromPointer); // 0x18 DisplayEffect               ( ModelClassType ProduceInGameEffect ProduceInGameEffect ProduceInGameEffect Pointer )
            value.GroupID                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 GroupID                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
