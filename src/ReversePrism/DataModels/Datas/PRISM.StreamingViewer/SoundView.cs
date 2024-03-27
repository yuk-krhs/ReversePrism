using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 000 PacketLengthSecond                       float IL2CPP_TYPE_R4
    // 000 BufferingTime                            float IL2CPP_TYPE_R4
    // 020 SoundReceiver                            000186538320 ModelClassType SoundReceiver SoundReceiver SoundReceiver Pointer
    // 028 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SoundView
    {
        public SoundReceiver?                           SoundReceiver                           { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static SoundView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundView();

            value.SoundReceiver                             = GetObject<SoundReceiver>(new IntPtr(p + 0x020), ReversePrism.DataModels.SoundReceiver.FromPointer); // 0270D4F280F8 0x20 SoundReceiver               ( 000186538320 ModelClassType SoundReceiver SoundReceiver SoundReceiver Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x028)); // 0270D4F28118 0x28 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
