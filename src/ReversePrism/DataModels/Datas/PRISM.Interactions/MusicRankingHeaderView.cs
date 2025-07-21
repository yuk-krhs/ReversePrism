using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RankingBaseImage                         ModelClassType Image Image Image Pointer
    // 028 RankingBaseSprites                       ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 030 RankingTextObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 RankWithUniqueSprite                     ModelPrimitiveType int int int Int32
    public partial class MusicRankingHeaderView : DataModel
    {
        public Image?                                   RankingBaseImage                        { get; set; }
        public List<Sprite>?                            RankingBaseSprites                      { get; set; }
        public List<GameObject>?                        RankingTextObjects                      { get; set; }
        public int                                      RankWithUniqueSprite                    { get; set; }

        public static MusicRankingHeaderView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingHeaderView() { Pointer= p0 };

            value.RankingBaseImage                          = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 RankingBaseImage            ( ModelClassType Image Image Image Pointer )
            value.RankingBaseSprites                        = GetObjectList<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0x28 RankingBaseSprites          ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.RankingTextObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 RankingTextObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RankWithUniqueSprite                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 RankWithUniqueSprite        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
