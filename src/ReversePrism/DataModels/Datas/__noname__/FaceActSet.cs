using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FaceAct                                  ModelClassListType FaceAct[] FaceAct[] List<FaceAct> Pointer
    public partial class FaceActSet : DataModel
    {
        public List<FaceAct>?                           FaceAct                                 { get; set; }

        public static FaceActSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceActSet() { Pointer= p0 };

            value.FaceAct                                   = GetObjectList<FaceAct>(new IntPtr(p + 0x010), ReversePrism.DataModels.FaceAct.FromPointer); // 0x10 FaceAct                     ( ModelClassListType FaceAct[] FaceAct[] List<FaceAct> Pointer )

            return value;
        }
    }
}
