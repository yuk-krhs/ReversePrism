using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CharacterBaseIcon                        ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 048 CenterIcon                               ModelClassType GameObject GameObject GameObject Pointer
    // 050 OnStageIcon                              ModelClassType GameObject GameObject GameObject Pointer
    // 058 DuplicatedIcon                           ModelClassType GameObject GameObject GameObject Pointer
    // 060 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LimitedVoiceSeparateIdolListCell : DataModel
    {
        public PFIdolIconView?                          CharacterBaseIcon                       { get; set; }
        public GameObject?                              CenterIcon                              { get; set; }
        public GameObject?                              OnStageIcon                             { get; set; }
        public GameObject?                              DuplicatedIcon                          { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LimitedVoiceSeparateIdolListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedVoiceSeparateIdolListCell() { Pointer= p0 };

            value.CharacterBaseIcon                         = GetObject<PFIdolIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x40 CharacterBaseIcon           ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.CenterIcon                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 CenterIcon                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OnStageIcon                               = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 OnStageIcon                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DuplicatedIcon                            = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 DuplicatedIcon              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 0x60 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
