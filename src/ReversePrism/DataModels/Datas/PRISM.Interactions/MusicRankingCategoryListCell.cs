using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CellImage                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 048 CellSprites                              000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 050 LockedObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class MusicRankingCategoryListCell
    {
        public Image?                                   CellImage                               { get; set; }
        public List<Sprite>?                            CellSprites                             { get; set; }
        public GameObject?                              LockedObject                            { get; set; }

        public static MusicRankingCategoryListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingCategoryListCell();

            value.CellImage                                 = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0270DB3CEDB0 0x40 CellImage                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CellSprites                               = GetObjectList<Sprite>(new IntPtr(p + 0x048), ReversePrism.DataModels.Sprite.FromPointer); // 0270DB3CEDD0 0x48 CellSprites                 ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.LockedObject                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3CEDF0 0x50 LockedObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
