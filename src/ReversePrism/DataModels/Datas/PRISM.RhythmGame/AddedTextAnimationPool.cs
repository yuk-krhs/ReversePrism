using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefab                                   00018668B050 ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer
    // 018 Parent                                   0001866AADB0 ModelClassType Transform Transform Transform Pointer
    // 020 Queue                                    000185B6F870 ModelClassListType AddedScoreText[] AddedScoreText[] List<AddedScoreText> Pointer
    // 028 RentCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C PoolLength                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AddedTextAnimationPool
    {
        public AddedScoreText?                          Prefab                                  { get; set; }
        public Transform?                               Parent                                  { get; set; }
        public List<AddedScoreText>?                    Queue                                   { get; set; }
        public int                                      RentCount                               { get; set; }
        public int                                      PoolLength                              { get; set; }

        public static AddedTextAnimationPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddedTextAnimationPool();

            value.Prefab                                    = GetObject<AddedScoreText>(new IntPtr(p + 0x010), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0270D5027268 0x10 Prefab                      ( 00018668B050 ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 0270D5027288 0x18 Parent                      ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )
            value.Queue                                     = GetObjectList<AddedScoreText>(new IntPtr(p + 0x020), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0270D50272A8 0x20 Queue                       ( 000185B6F870 ModelClassListType AddedScoreText[] AddedScoreText[] List<AddedScoreText> Pointer )
            value.RentCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D50272C8 0x28 RentCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PoolLength                                = GetInt32(new IntPtr(p + 0x02C)); // 0270D50272E8 0x2C PoolLength                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
