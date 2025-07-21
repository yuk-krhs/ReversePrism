using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MiniCharaActionType
    {
        無効,
        お仕事_ラジオ出演,
        お仕事_テレビ出演,
        お仕事_撮影モデル,
        お仕事_CM出演,
        お仕事_雑誌取材,
        自主練_Vo,
        自主練_Da,
        自主練_Vi,
        お出かけ_遊園地,
        お出かけ_演劇鑑賞,
        お出かけ_映画館,
        お出かけ_占い,
        買い物_洋服,
        買い物_CD,
        買い物_コスメ,
        買い物_食べ物,
        ミニライブ,
        トークショー,
        ミニドラマ_台本読み,
        ミニドラマ_衣装合わせ,
        ミニドラマ_PR活動,
        ミニドラマ_演技指導,
    }
}
