using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefab                                   ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer
    // 018 Parent                                   ModelClassType Transform Transform Transform Pointer
    // 020 Queue                                    ModelClassListType AddedScoreText[] AddedScoreText[] List<AddedScoreText> Pointer
    // 028 RentCount                                ModelPrimitiveType int int int Int32
    // 02C PoolLength                               ModelPrimitiveType int int int Int32
    public partial class AddedTextAnimationPool : DataModel
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
            var value   = new AddedTextAnimationPool() { Pointer= p0 };

            value.Prefab                                    = GetObject<AddedScoreText>(new IntPtr(p + 0x010), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0x10 Prefab                      ( ModelClassType AddedScoreText AddedScoreText AddedScoreText Pointer )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 0x18 Parent                      ( ModelClassType Transform Transform Transform Pointer )
            value.Queue                                     = GetObjectList<AddedScoreText>(new IntPtr(p + 0x020), ReversePrism.DataModels.AddedScoreText.FromPointer); // 0x20 Queue                       ( ModelClassListType AddedScoreText[] AddedScoreText[] List<AddedScoreText> Pointer )
            value.RentCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 RentCount                   ( ModelPrimitiveType int int int Int32 )
            value.PoolLength                                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C PoolLength                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
