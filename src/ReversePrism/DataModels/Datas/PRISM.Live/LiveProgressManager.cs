using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueName                                  ModelPrimitiveType string string string String
    // 018 Extensions                               ModelClassListType ILiveProgressManagerExtension[] ILiveProgressManagerExtension[] List<ILiveProgressManagerExtension> Pointer
    // 020 Player                                   ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 028 Playback                                 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 02C Time                                     ModelPrimitiveType float float float Single
    // 030 Length                                   ModelPrimitiveType float float float Single
    // 034 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 035 WaitFinishedCancelFlag                   ModelPrimitiveType bool bool bool Bool
    public partial class LiveProgressManager : DataModel
    {
        public string                                   CueName                                 { get; set; }
        public List<ILiveProgressManagerExtension>?     Extensions                              { get; set; }
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public CriAtomExPlayback                        Playback                                { get; set; }
        public float                                    Time                                    { get; set; }
        public float                                    Length                                  { get; set; }
        public bool                                     Disposed                                { get; set; }
        public bool                                     WaitFinishedCancelFlag                  { get; set; }

        public static LiveProgressManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveProgressManager() { Pointer= p0 };

            value.CueName                                   = GetString(new IntPtr(p + 0x010)); // 0x10 CueName                     ( ModelPrimitiveType string string string String )
            value.Extensions                                = GetObjectList<ILiveProgressManagerExtension>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILiveProgressManagerExtension.FromPointer); // 0x18 Extensions                  ( ModelClassListType ILiveProgressManagerExtension[] ILiveProgressManagerExtension[] List<ILiveProgressManagerExtension> Pointer )
            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x20 Player                      ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x028)); // 0x28 Playback                    ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.Time                                      = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Time                        ( ModelPrimitiveType float float float Single )
            value.Length                                    = GetSingle(new IntPtr(p + 0x030)); // 0x30 Length                      ( ModelPrimitiveType float float float Single )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x034)); // 0x34 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.WaitFinishedCancelFlag                    = GetBool(new IntPtr(p + 0x035)); // 0x35 WaitFinishedCancelFlag      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
