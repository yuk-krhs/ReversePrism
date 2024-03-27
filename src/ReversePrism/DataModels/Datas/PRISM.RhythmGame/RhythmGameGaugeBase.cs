using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AddedScoreTextPrefab                     00018668ADA0 ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer
    // 028 AddedScoreTextRoot                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 PreloadCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 AddedScoreTextPool                       00018668B530 ModelClassType AddedTextAnimationPool AddedTextAnimationPool AddedTextAnimationPool Pointer
    // 040 BeforeText                               00018668ADA0 ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer
    public partial class RhythmGameGaugeBase
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
            var value   = new RhythmGameGaugeBase();

            value.AddedScoreTextPrefab                      = GetObject<AddedScoreText>(new IntPtr(p + 0x020), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0270D50546E8 0x20 AddedScoreTextPrefab        ( 00018668ADA0 ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer )
            value.AddedScoreTextRoot                        = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5054708 0x28 AddedScoreTextRoot          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PreloadCount                              = GetInt32(new IntPtr(p + 0x030)); // 0270D5054728 0x30 PreloadCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AddedScoreTextPool                        = GetObject<AddedTextAnimationPool>(new IntPtr(p + 0x038), ReversePrism.DataModels.AddedTextAnimationPool.FromPointer); // 0270D5054748 0x38 AddedScoreTextPool          ( 00018668B530 ModelClassType AddedTextAnimationPool AddedTextAnimationPool AddedTextAnimationPool Pointer )
            value.BeforeText                                = GetObject<AddedScoreText>(new IntPtr(p + 0x040), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0270D5054768 0x40 BeforeText                  ( 00018668ADA0 ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer )

            return value;
        }
    }
}
