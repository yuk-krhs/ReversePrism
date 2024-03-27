using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 effects                                  ListWithKey`2<ProduceInGameEffectType, ProduceInGameEffect> IL2CPP_TYPE_GENERICINST
    // 018 DisplayEffect                            000186556BB0 ModelClassType ProduceInGameEffect ProduceInGameEffect ProduceInGameEffect Pointer
    // 020 GroupID                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceInGameEffectGroup
    {
        public ProduceInGameEffect?                     DisplayEffect                           { get; set; }
        public int                                      GroupID                                 { get; set; }

        public static ProduceInGameEffectGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGameEffectGroup();

            value.DisplayEffect                             = GetObject<ProduceInGameEffect>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceInGameEffect.FromPointer); // 0270D59D5190 0x18 DisplayEffect               ( 000186556BB0 ModelClassType ProduceInGameEffect ProduceInGameEffect ProduceInGameEffect Pointer )
            value.GroupID                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D59D51B0 0x20 GroupID                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
