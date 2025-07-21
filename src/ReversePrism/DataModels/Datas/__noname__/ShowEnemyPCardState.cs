using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OpponentReleaseHandIndexes               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 EffectDisplayIds                         ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 Presenter                                ModelClassType BasePresenter BasePresenter BasePresenter Pointer
    // 028 OpponentDrawHandCount                    ModelPrimitiveType int int int Int32
    // 02C TotalGetAppealPoint                      ModelPrimitiveType int int int Int32
    public partial class ShowEnemyPCardState : DataModel
    {
        public List<int>?                               OpponentReleaseHandIndexes              { get; set; }
        public List<int>?                               EffectDisplayIds                        { get; set; }
        public BasePresenter?                           Presenter                               { get; set; }
        public int                                      OpponentDrawHandCount                   { get; set; }
        public int                                      TotalGetAppealPoint                     { get; set; }

        public static ShowEnemyPCardState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowEnemyPCardState() { Pointer= p0 };

            value.OpponentReleaseHandIndexes                = GetInt32List(new IntPtr(p + 0x010)); // 0x10 OpponentReleaseHandIndexes  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.EffectDisplayIds                          = GetInt32List(new IntPtr(p + 0x018)); // 0x18 EffectDisplayIds            ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Presenter                                 = GetObject<BasePresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.BasePresenter.FromPointer); // 0x20 Presenter                   ( ModelClassType BasePresenter BasePresenter BasePresenter Pointer )
            value.OpponentDrawHandCount                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 OpponentDrawHandCount       ( ModelPrimitiveType int int int Int32 )
            value.TotalGetAppealPoint                       = GetInt32(new IntPtr(p + 0x02C)); // 0x2C TotalGetAppealPoint         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
