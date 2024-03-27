using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DS
    {
        BEGIN,
        N,
        NN,
        D_Nd,
        D_NN,
        D_NNd,
        D_M,
        D_MN,
        D_NM,
        D_MNd,
        D_NDS,
        D_Y,
        D_YN,
        D_YNd,
        D_YM,
        D_YMd,
        D_S,
        T_S,
        T_Nt,
        T_NNt,
        ERROR,
        DX_NN,
        DX_NNN,
        DX_MN,
        DX_NM,
        DX_MNN,
        DX_DS,
        DX_DSN,
        DX_NDS,
        DX_NNDS,
        DX_YNN,
        DX_YMN,
        DX_YN,
        DX_YM,
        TX_N,
        TX_NN,
        TX_NNN,
        TX_TS,
        DX_NNY,
    }
}
