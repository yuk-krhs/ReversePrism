using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TweenType                                ModelEnumType TweenType TweenType TweenType Int32
    // 014 SequencedPosition                        ModelPrimitiveType float float float Single
    // 018 SequencedEndPosition                     ModelPrimitiveType float float float Single
    // 020 OnStart                                  ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    public partial class ABSSequentiable : DataModel
    {
        public TweenType                                TweenType                               { get; set; }
        public float                                    SequencedPosition                       { get; set; }
        public float                                    SequencedEndPosition                    { get; set; }
        public TweenCallback?                           OnStart                                 { get; set; }

        public static ABSSequentiable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ABSSequentiable() { Pointer= p0 };

            value.TweenType                                 = (TweenType)GetInt32(new IntPtr(p + 0x010)); // 0x10 TweenType                   ( ModelEnumType TweenType TweenType TweenType Int32 )
            value.SequencedPosition                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 SequencedPosition           ( ModelPrimitiveType float float float Single )
            value.SequencedEndPosition                      = GetSingle(new IntPtr(p + 0x018)); // 0x18 SequencedEndPosition        ( ModelPrimitiveType float float float Single )
            value.OnStart                                   = GetObject<TweenCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.TweenCallback.FromPointer); // 0x20 OnStart                     ( ModelClassType TweenCallback TweenCallback TweenCallback Pointer )

            return value;
        }
    }
}
