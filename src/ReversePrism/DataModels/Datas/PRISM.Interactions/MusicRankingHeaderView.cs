using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RankingBaseImage                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 RankingBaseSprites                       000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 030 RankingTextObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 RankWithUniqueSprite                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MusicRankingHeaderView
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
            var value   = new MusicRankingHeaderView();

            value.RankingBaseImage                          = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DB3CF0A8 0x20 RankingBaseImage            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.RankingBaseSprites                        = GetObjectList<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0270DB3CF0C8 0x28 RankingBaseSprites          ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.RankingTextObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3CF0E8 0x30 RankingTextObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RankWithUniqueSprite                      = GetInt32(new IntPtr(p + 0x038)); // 0270DB3CF108 0x38 RankWithUniqueSprite        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
