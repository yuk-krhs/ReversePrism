using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AddedScoreTextPrefab                     ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer
    // 028 AddedScoreTextRoot                       ModelClassType GameObject GameObject GameObject Pointer
    // 030 PreloadCount                             ModelPrimitiveType int int int Int32
    // 038 AddedScoreTextPool                       ModelClassType AddedTextAnimationPool AddedTextAnimationPool AddedTextAnimationPool Pointer
    // 040 BeforeText                               ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer
    public partial class RhythmGameGaugeBase : DataModel
    {
        public AddedScoreText?                          AddedScoreTextPrefab                    { get; set; }
        public GameObject?                              AddedScoreTextRoot                      { get; set; }
        public int                                      PreloadCount                            { get; set; }
        public AddedTextAnimationPool?                  AddedScoreTextPool                      { get; set; }
        public AddedScoreText?                          BeforeText                              { get; set; }

        public static RhythmGameGaugeBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameGaugeBase() { Pointer= p0 };

            value.AddedScoreTextPrefab                      = GetObject<AddedScoreText>(new IntPtr(p + 0x020), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0x20 AddedScoreTextPrefab        ( ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer )
            value.AddedScoreTextRoot                        = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 AddedScoreTextRoot          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PreloadCount                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 PreloadCount                ( ModelPrimitiveType int int int Int32 )
            value.AddedScoreTextPool                        = GetObject<AddedTextAnimationPool>(new IntPtr(p + 0x038), ReversePrism.DataModels.AddedTextAnimationPool.FromPointer); // 0x38 AddedScoreTextPool          ( ModelClassType AddedTextAnimationPool AddedTextAnimationPool AddedTextAnimationPool Pointer )
            value.BeforeText                                = GetObject<AddedScoreText>(new IntPtr(p + 0x040), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0x40 BeforeText                  ( ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer )

            return value;
        }
    }
}
