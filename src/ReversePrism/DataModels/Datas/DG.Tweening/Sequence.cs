using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 120 SequencedTweens                          000185D166C8 ModelClassListType List`1<Tween> List`1<Tween> List<Tween> Pointer
    // 128 SequencedObjs                            000185CCAE88 ModelClassListType List`1<ABSSequentiable> List`1<ABSSequentiable> List<ABSSequentiable> Pointer
    // 130 LastTweenInsertTime                      000186665900 ModelPrimitiveType float float float Single
    public partial class Sequence
    {
        public List<Tween>?                             SequencedTweens                         { get; set; }
        public List<ABSSequentiable>?                   SequencedObjs                           { get; set; }
        public float                                    LastTweenInsertTime                     { get; set; }

        public static Sequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Sequence();

            value.SequencedTweens                           = GetObjectList<Tween>(new IntPtr(p + 0x120), ReversePrism.DataModels.Tween.FromPointer); // 02700436ED20 0x120 SequencedTweens             ( 000185D166C8 ModelClassListType List`1<Tween> List`1<Tween> List<Tween> Pointer )
            value.SequencedObjs                             = GetObjectList<ABSSequentiable>(new IntPtr(p + 0x128), ReversePrism.DataModels.ABSSequentiable.FromPointer); // 02700436ED40 0x128 SequencedObjs               ( 000185CCAE88 ModelClassListType List`1<ABSSequentiable> List`1<ABSSequentiable> List<ABSSequentiable> Pointer )
            value.LastTweenInsertTime                       = GetSingle(new IntPtr(p + 0x130)); // 02700436ED60 0x130 LastTweenInsertTime         ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
