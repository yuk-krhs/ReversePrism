using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceTutorialSetTargetCardEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public int                                      CardId                                  { get; set; }

        public static ProduceTutorialSetTargetCardEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialSetTargetCardEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D4A108 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D5D4A128 0x18 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
